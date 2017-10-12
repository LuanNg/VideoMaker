# libraries
import os
import sys

from PIL import Image
from moviepy.editor import *

# load parameters
'''
parameter /value/

mode /preview/ or /render/
video /string/
image /string/
audio /string/
keyImage /none/ or /path/
position /top/bottom/left/right/ or /X Y/  top left corner or /auto R G B/ + /int/ accuracy
resize /float/ 1.0 = 100% or /auto/ need position auto
start image clip /sec/
duration  /sec/
saveDirectory /path/
OPTIONAL: crop image /left upper right lower/ or /left/center/right/ need position auto
'''
# from command line
if len(sys.argv) > 6:
    params = sys.argv
    del params[0]
# or from file
elif os.path.isfile("input.txt"):
    with open("input.txt") as file:
        params = [row.strip() for row in file]
else:
    print ("Cannot load parameters")
    quit()

# check files
try:
    check = "video"
    os.path.isfile(params[1])
    check = "image"
    os.path.isfile(params[2])
    check = "audio"
    os.path.isfile(params[3])
except:
    print ("Couldn't load " + check + "file")
    quit()

# set params
autoPos = False
autoSize = False
keyingArea = [0, 0], [0, 0], [0, 0], [0, 0]
try:
    pos = map(int, params[5].split())
except ValueError:
    if "auto" in params[5]:
        pos = params[5]
        pos = pos[5:len(pos)]
        autoPos = True
    else:
        pos = params[5]
try:
    size = float(params[6])
except ValueError:
    if "auto" in params[6]:
        autoSize = True
start = float(params[7])
duration = float(params[8])

audio = AudioFileClip(params[3])
video = VideoFileClip(params[1]).set_audio(audio)

# auto positioning image
if autoPos:
    if params[5] != "none":
        imageKeying = Image.open(params[4])
    else:
        video.save_frame("keyingImage.jpg", t=start)
    colorToKey = map(int, pos.split())
    accuracy = colorToKey[3]
    del colorToKey[3]
    firstPixelDetected = False;
    pixels = list(imageKeying.getdata())
    width, height = imageKeying.size
    rgb_im = imageKeying.convert('RGB')
    for y in range(height):
        if firstPixelDetected:
            rgb = rgb_im.getpixel((keyingArea[0][0], y))
            if (rgb[0] < colorToKey[0] + accuracy and rgb[0] > colorToKey[0] - accuracy
                and rgb[1] < colorToKey[1] + accuracy and rgb[1] > colorToKey[1] - accuracy
                and rgb[2] < colorToKey[2] + accuracy and rgb[2] > colorToKey[2] - accuracy):
                keyingArea[2][0] = keyingArea[0][0]
                keyingArea[2][1] = y
        else:
            for x in range(width):
                rgb = rgb_im.getpixel((x, y))
                if (rgb[0] < colorToKey[0] + accuracy and rgb[0] > colorToKey[0] - accuracy
                    and rgb[1] < colorToKey[1] + accuracy and rgb[1] > colorToKey[1] - accuracy
                    and rgb[2] < colorToKey[2] + accuracy and rgb[2] > colorToKey[2] - accuracy
                    and not firstPixelDetected):
                    keyingArea[0][0] = x
                    keyingArea[0][1] = y
                    firstPixelDetected = True
                elif (rgb[0] < colorToKey[0] + accuracy and rgb[0] > colorToKey[0] - accuracy
                      and rgb[1] < colorToKey[1] + accuracy and rgb[1] > colorToKey[1] - accuracy
                      and rgb[2] < colorToKey[2] + accuracy and rgb[2] > colorToKey[2] - accuracy
                      and firstPixelDetected):
                    keyingArea[1][0] = x
                    keyingArea[1][1] = y
                else:
                    if (firstPixelDetected
                        and keyingArea[1][0] - keyingArea[0][0] < 100):
                        firstPixelDetected = False
                        keyingArea[0][0] = 0
                        keyingArea[0][1] = 0
                        keyingArea[1][0] = 0
                        keyingArea[1][1] = 0

    keyingArea[3][0] = keyingArea[1][0]
    keyingArea[3][1] = keyingArea[2][1]
    pos = keyingArea[0]

image = ImageClip(params[2]).set_duration(duration)

# autoscale image
if autoSize:
    size = float(round((keyingArea[2][1] - keyingArea[0][1]), 100) / image.h)

image = image.resize(size)
image.save_frame("1.jpg", t=0)

# crop image if needed
if len(params) > 10:
    image = Image.open("1.jpg")
    width, height = image.size
    widthNeed = keyingArea[3][0] - keyingArea[0][0]
    try:
        area = map(int, params[10].split())
    except ValueError:
        if "center" in params[10]:
            area = [0 + (width - widthNeed) / 2, 0, width - (width - widthNeed) / 2,
                    keyingArea[3][1] - keyingArea[0][1]]
        elif "left" in params[10]:
            area = [0, 0, widthNeed, keyingArea[3][1] - keyingArea[0][1]]
        elif "right" in params:
            area = [0 + (width - widthNeed), 0, width - 1, keyingArea[3][1] - keyingArea[0][1]]
    image = image.crop(area)
    image.save(params[2])
image = ImageClip(params[2]).set_duration(duration)

# mix video

if params[0] == "render":
    if isinstance(pos[0], int):
        final_clip = CompositeVideoClip([video, image.set_pos((pos[0], pos[1])).set_start(start)])
    else:
        final_clip = CompositeVideoClip([video, image.set_pos(pos).set_start(start)])
    final_clip.write_videofile(params[9])
else:
    video = video.subclip(start, start + 10)
    if isinstance(pos[0], int):
        final_clip = CompositeVideoClip([video, image.set_pos((pos[0], pos[1]))])
    else:
        final_clip = CompositeVideoClip([video, image.set_pos(pos)])
    final_clip.save_frame("previewFrame.png", t=1)
