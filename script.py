# libraries
from moviepy.editor import AudioFileClip, VideoFileClip, ImageClip, CompositeVideoClip
from PIL import Image
import sys
import os

# load parameters
'''
video (string)
image (string)
audio (string)
position(top/bottom/left/right or X Y  top left corner)
resize(float 1.0 = 100%)
start image clip (sec)
duration  (sec)
OPTIONAL: crop image (left upper right lower)
'''
# from command line
if len(sys.argv) > 6:
    params = sys.argv
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
    VideoFileClip(params[0])
    check = "image"
    Image.open(params[1])
    check = "audio"
    AudioFileClip(params[2])
except:
    print ("Couldn't load " + check + "file")
    quit()

# set params
try:
    pos = map(int, params[3].split())
except ValueError:
    pos = params[3]
size = float(params[4])
start = int(params[5])
duration = int(params[6])

audio = AudioFileClip(params[2])
video = VideoFileClip(params[0]).set_audio(audio)

# crop image if needed
if len(params) == 8:
    image = Image.open(params[1])
    area = map(int, params[7].split())
    image = image.crop(area)
    image.save(params[1])
image = (ImageClip(params[1]).set_duration(duration).resize(size))

# mix video
if isinstance(pos[0], int):
    final_clip = CompositeVideoClip([video, image.set_pos((pos[0], pos[1])).set_start(start)])
else:
    final_clip = CompositeVideoClip([video, image.set_pos(pos).set_start(start)])
final_clip.write_videofile("output.mp4")
