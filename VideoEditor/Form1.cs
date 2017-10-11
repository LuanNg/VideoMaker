using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class Form1 : Form
    {
        String pathVideo;
        String pathAudio;
        String pathImage;
        String pathKeyImage;
        String mode;
        String pos;
        String size;
        String start;
        String duration;
        String crop;

        public Form1()
        {
            InitializeComponent();
        }

        private void VideoButton_click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".mp4")
                    || openFileDialog1.FileName.Contains(".avi")
                    || openFileDialog1.FileName.Contains(".m4v")
                    || openFileDialog1.FileName.Contains(".mkv"))
                {
                    VideoLabel.Text = "Файл выбран";
                    pathVideo = openFileDialog1.FileName;
                }
                else
                {
                    VideoLabel.Text = "Ошибка в выборе файла";
                }
            }
        }

        private void AudioButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".mp3")
                    || openFileDialog1.FileName.Contains(".ogg")
                    || openFileDialog1.FileName.Contains(".wav")
                    || openFileDialog1.FileName.Contains(".aac"))
                {
                    AudioLabel.Text = "Файл выбран";
                    pathAudio = openFileDialog1.FileName;
                }
                else
                {
                    AudioLabel.Text = "Ошибка в выборе файла";
                }
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".jpg")
                    || openFileDialog1.FileName.Contains(".png")
                    || openFileDialog1.FileName.Contains(".jpeg"))
                {
                    ImageLabel.Text = "Файл выбран";
                    pathImage = openFileDialog1.FileName;
                }
                else
                {
                    ImageLabel.Text = "Ошибка в выборе файла";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".jpg")
                    || openFileDialog1.FileName.Contains(".png")
                    || openFileDialog1.FileName.Contains(".jpeg"))
                {
                    KeyImageLabel.Text = "Файл выбран";
                    pathKeyImage = openFileDialog1.FileName;
                }
                else
                {
                    KeyImageLabel.Text = "Ошибка в выборе файла";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = "preview";
            pictureBox1.Image = null;
            File.Delete("previewFrame.png");
            start = Start_text.Text;
            duration = Duration_text.Text;
            if (Crop_list.SelectedItem.Equals("По правому краю"))
            {
                crop = "right";
            }
            else if (Crop_list.SelectedItem.Equals("По центру"))
            {
                crop = "center";
            }
            else if (Crop_list.SelectedItem.Equals("По левому краю"))
            {
                crop = "left";
            }
            else {
                crop = "none";
            }
            size = "auto";
            pos = "auto " + Color_R.Text + " " + Color_G.Text + " " + Color_B.Text + " " + Accuracy.Text;
            //String args = "preview \r\nmovie_2.mp4 \r\nboy.jpg \r\naudio.mp3 \r\nkeyingImage.jpg \r\n" +
            //              "auto 25 26 254 180 \r\nauto \r\n139.2 \r\n3";
            String args;
            if (crop.Equals("none"))
            {
                args = mode + "\r\n" + pathVideo + "\r\n" + pathImage + "\r\n" + pathAudio + "\r\n" +
                    pathKeyImage + "\r\n" + pos + "\r\n" + size + "\r\n" + start + "\r\n" +
                    duration + "\r\n" + crop;
            }
            else {
                args = mode + "\r\n" + pathVideo + "\r\n" + pathImage + "\r\n" + pathAudio + "\r\n" +
                    pathKeyImage + "\r\n" + pos + "\r\n" + size + "\r\n" + start + "\r\n" +
                    duration;
            }
            System.IO.File.WriteAllText("input.txt", args);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = new System.Diagnostics.ProcessStartInfo("script.py");
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
            pictureBox1.Image = LoadBitmap("previewFrame.png");
            if (LoadBitmap("previewFrame.png").Height > pictureBox1.Height
                || LoadBitmap("previewFrame.png").Width > pictureBox1.Width)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            mode = "render";
            start = Start_text.Text;
            duration = Duration_text.Text;
            crop = Crop_list.SelectedItem.ToString();
            size = "auto";
            //String args = "preview \r\nmovie_2.mp4 \r\nboy.jpg \r\naudio.mp3 \r\nkeyingImage.jpg \r\n" +
            //              "auto 25 26 254 180 \r\nauto \r\n139.2 \r\n3";
            String args = mode + "\r\n" + pathVideo + "\r\n" + pathImage + "\r\n" + pathAudio + "\r\n" +
                pathKeyImage + "\r\n" + pos + "\r\n" + size + "\r\n" + start + "\r\n" +
                duration + "\r\n" + crop;
            System.IO.File.WriteAllText("input.txt", args);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = new System.Diagnostics.ProcessStartInfo("script.py");
            proc.Start();
            pictureBox1.Image = LoadBitmap("previewFrame.png");
            if (LoadBitmap("previewFrame.png").Height > pictureBox1.Height
                || LoadBitmap("previewFrame.png").Width > pictureBox1.Width)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int counter = 0;

                using (StreamReader fs = new StreamReader(openFileDialog1.FileName))
                {
                    while (true)
                    {
                        // Читаем строку из файла во временную переменную.
                        string temp = fs.ReadLine();

                        // Если достигнут конец файла, прерываем считывание.
                        if (temp == null) break;

                        switch (counter) {
                            case 0:
                                break;
                            case 1:
                                pathVideo = temp;
                                VideoLabel.Text = "Файл выбран";
                                break;
                            case 2:
                                pathImage = temp;
                                ImageLabel.Text = "Файл выбран";
                                break;
                            case 3:
                                pathAudio = temp;
                                AudioLabel.Text = "Файл выбран";
                                break;
                            case 4:
                                pathKeyImage = temp;
                                KeyImageLabel.Text = "Файл выбран";
                                break;
                            case 5:
                                temp = Regex.Replace(temp, "auto ", "");
                                int[] array = temp.Split(' ').Select(int.Parse).ToArray();
                                Color_R.Text = array[0].ToString();
                                Color_G.Text = array[1].ToString();
                                Color_B.Text = array[2].ToString();
                                Accuracy.Text = array[3].ToString();
                                break;
                            case 6:
                                break;
                            case 7:
                                start = temp;
                                Start_text.Text = temp;
                                break;
                            case 8:
                                duration = temp;
                                Duration_text.Text = temp;
                                break;
                            case 9:
                                crop = temp;
                                if (crop.Equals("center"))
                                {
                                    Crop_list.SetSelected(1, true);
                                }
                                else if (crop.Equals("right"))
                                {
                                    Crop_list.SetSelected(2, true);
                                }
                                else if (crop.Equals("left"))
                                {
                                    Crop_list.SetSelected(3, true);
                                }
                                else {
                                    Crop_list.SetSelected(0, true);
                                }
                                break;

                        }
                        counter += 1;
                    }
                    if (counter < 7) {
                        MessageBox.Show("Убедитесь, что аргументы в файле указаны верно", "Ошибка при чтении файла",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public Bitmap LoadBitmap(string path)
        {
            if (File.Exists(path))
            {
                // open file in read only mode
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                // get a binary reader for the file stream
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    // copy the content of the file into a memory stream
                    var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                    // make a new Bitmap object the owner of the MemoryStream
                    return new Bitmap(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("Файл не найден", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
