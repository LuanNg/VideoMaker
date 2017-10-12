namespace VideoEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.VideoButton = new System.Windows.Forms.Button();
            this.VideoLabel = new System.Windows.Forms.Label();
            this.AudioLabel = new System.Windows.Forms.Label();
            this.AudioButton = new System.Windows.Forms.Button();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.ImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_text = new System.Windows.Forms.TextBox();
            this.Duration_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.KeyImageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Crop_list = new System.Windows.Forms.ListBox();
            this.RenderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Color_R = new System.Windows.Forms.TextBox();
            this.Color_G = new System.Windows.Forms.TextBox();
            this.Color_B = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Accuracy = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoButton
            // 
            this.VideoButton.Location = new System.Drawing.Point(43, 40);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(115, 41);
            this.VideoButton.TabIndex = 0;
            this.VideoButton.Text = "Нажмите, чтобы выбрать видео";
            this.VideoButton.UseVisualStyleBackColor = true;
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_click);
            // 
            // VideoLabel
            // 
            this.VideoLabel.AutoSize = true;
            this.VideoLabel.Location = new System.Drawing.Point(49, 9);
            this.VideoLabel.Name = "VideoLabel";
            this.VideoLabel.Size = new System.Drawing.Size(100, 13);
            this.VideoLabel.TabIndex = 1;
            this.VideoLabel.Text = "Видео не выбрано";
            // 
            // AudioLabel
            // 
            this.AudioLabel.AutoSize = true;
            this.AudioLabel.Location = new System.Drawing.Point(50, 97);
            this.AudioLabel.Name = "AudioLabel";
            this.AudioLabel.Size = new System.Drawing.Size(99, 13);
            this.AudioLabel.TabIndex = 2;
            this.AudioLabel.Text = "Аудио не выбрано";
            // 
            // AudioButton
            // 
            this.AudioButton.Location = new System.Drawing.Point(43, 128);
            this.AudioButton.Name = "AudioButton";
            this.AudioButton.Size = new System.Drawing.Size(115, 41);
            this.AudioButton.TabIndex = 3;
            this.AudioButton.Text = "Нажмите, чтобы выбрать аудио";
            this.AudioButton.UseVisualStyleBackColor = true;
            this.AudioButton.Click += new System.EventHandler(this.AudioButton_Click);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(31, 188);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(139, 13);
            this.ImageLabel.TabIndex = 4;
            this.ImageLabel.Text = "Изображение не выбрано";
            // 
            // ImageButton
            // 
            this.ImageButton.Location = new System.Drawing.Point(43, 217);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(115, 59);
            this.ImageButton.TabIndex = 5;
            this.ImageButton.Text = "Нажмите, чтобы выбрать изображение";
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 314);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Время вставки изображения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Длительность";
            // 
            // Start_text
            // 
            this.Start_text.Location = new System.Drawing.Point(197, 470);
            this.Start_text.Name = "Start_text";
            this.Start_text.Size = new System.Drawing.Size(152, 20);
            this.Start_text.TabIndex = 9;
            this.Start_text.Text = "0";
            // 
            // Duration_text
            // 
            this.Duration_text.Location = new System.Drawing.Point(404, 470);
            this.Duration_text.Name = "Duration_text";
            this.Duration_text.Size = new System.Drawing.Size(81, 20);
            this.Duration_text.TabIndex = 10;
            this.Duration_text.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Показать превью";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 70);
            this.button2.TabIndex = 12;
            this.button2.Text = "Нажмите, чтобы выбрать изображение с областью обрезки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KeyImageLabel
            // 
            this.KeyImageLabel.AutoSize = true;
            this.KeyImageLabel.Location = new System.Drawing.Point(31, 288);
            this.KeyImageLabel.Name = "KeyImageLabel";
            this.KeyImageLabel.Size = new System.Drawing.Size(139, 13);
            this.KeyImageLabel.TabIndex = 13;
            this.KeyImageLabel.Text = "Изображение не выбрано";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Обрезка";
            // 
            // Crop_list
            // 
            this.Crop_list.FormattingEnabled = true;
            this.Crop_list.Items.AddRange(new object[] {
            "Нет",
            "По центру",
            "По правому краю",
            "По левому краю"});
            this.Crop_list.Location = new System.Drawing.Point(540, 451);
            this.Crop_list.Name = "Crop_list";
            this.Crop_list.Size = new System.Drawing.Size(120, 56);
            this.Crop_list.TabIndex = 15;
            // 
            // RenderButton
            // 
            this.RenderButton.Location = new System.Drawing.Point(521, 338);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(196, 26);
            this.RenderButton.TabIndex = 16;
            this.RenderButton.Text = "Рендер(Сохранить как output.mp4)";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Цвет для обрезки";
            // 
            // Color_R
            // 
            this.Color_R.Location = new System.Drawing.Point(43, 461);
            this.Color_R.Name = "Color_R";
            this.Color_R.Size = new System.Drawing.Size(34, 20);
            this.Color_R.TabIndex = 18;
            this.Color_R.Text = "R";
            // 
            // Color_G
            // 
            this.Color_G.Location = new System.Drawing.Point(83, 461);
            this.Color_G.Name = "Color_G";
            this.Color_G.Size = new System.Drawing.Size(34, 20);
            this.Color_G.TabIndex = 19;
            this.Color_G.Text = "G";
            // 
            // Color_B
            // 
            this.Color_B.Location = new System.Drawing.Point(124, 461);
            this.Color_B.Name = "Color_B";
            this.Color_B.Size = new System.Drawing.Size(34, 20);
            this.Color_B.TabIndex = 20;
            this.Color_B.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Допуск";
            // 
            // Accuracy
            // 
            this.Accuracy.Location = new System.Drawing.Point(103, 487);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(55, 20);
            this.Accuracy.TabIndex = 22;
            this.Accuracy.Text = "30";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 56);
            this.button3.TabIndex = 23;
            this.button3.Text = "Загрузить настройки из файла";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Made by Itis.team";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 26);
            this.button4.TabIndex = 25;
            this.button4.Text = "Рендер(Сохранить как...)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.mp4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 532);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Color_B);
            this.Controls.Add(this.Color_G);
            this.Controls.Add(this.Color_R);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.Crop_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyImageLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Duration_text);
            this.Controls.Add(this.Start_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImageButton);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.AudioButton);
            this.Controls.Add(this.AudioLabel);
            this.Controls.Add(this.VideoLabel);
            this.Controls.Add(this.VideoButton);
            this.Name = "Form1";
            this.Text = "VideoMaker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VideoButton;
        private System.Windows.Forms.Label VideoLabel;
        private System.Windows.Forms.Label AudioLabel;
        private System.Windows.Forms.Button AudioButton;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Start_text;
        private System.Windows.Forms.TextBox Duration_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label KeyImageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Crop_list;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Color_R;
        private System.Windows.Forms.TextBox Color_G;
        private System.Windows.Forms.TextBox Color_B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Accuracy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

