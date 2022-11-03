namespace RemoteControlLamp
{
    partial class btnGreenMed
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnGreenMed));
            this.btnRedLow = new System.Windows.Forms.Button();
            this.btnRedMed = new System.Windows.Forms.Button();
            this.btnRedMax = new System.Windows.Forms.Button();
            this.btnGreenLow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGreenMax = new System.Windows.Forms.Button();
            this.btnBlueLow = new System.Windows.Forms.Button();
            this.btnBlueMed = new System.Windows.Forms.Button();
            this.btnBlueMax = new System.Windows.Forms.Button();
            this.btnXmasMode = new System.Windows.Forms.Button();
            this.btnConnectMQTT = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.AnhLamp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRedLow
            // 
            this.btnRedLow.BackColor = System.Drawing.Color.Transparent;
            this.btnRedLow.Location = new System.Drawing.Point(30, 25);
            this.btnRedLow.Name = "btnRedLow";
            this.btnRedLow.Size = new System.Drawing.Size(85, 73);
            this.btnRedLow.TabIndex = 0;
            this.btnRedLow.Text = "RED *";
            this.btnRedLow.UseVisualStyleBackColor = false;
            this.btnRedLow.Click += new System.EventHandler(this.btnRedLow_Click);
            // 
            // btnRedMed
            // 
            this.btnRedMed.Location = new System.Drawing.Point(121, 25);
            this.btnRedMed.Name = "btnRedMed";
            this.btnRedMed.Size = new System.Drawing.Size(85, 73);
            this.btnRedMed.TabIndex = 1;
            this.btnRedMed.Text = "RED **";
            this.btnRedMed.UseVisualStyleBackColor = true;
            this.btnRedMed.Click += new System.EventHandler(this.btnRedMed_Click);
            // 
            // btnRedMax
            // 
            this.btnRedMax.Location = new System.Drawing.Point(212, 25);
            this.btnRedMax.Name = "btnRedMax";
            this.btnRedMax.Size = new System.Drawing.Size(85, 73);
            this.btnRedMax.TabIndex = 2;
            this.btnRedMax.Text = "RED ***";
            this.btnRedMax.UseVisualStyleBackColor = true;
            this.btnRedMax.Click += new System.EventHandler(this.btnRedMax_Click);
            // 
            // btnGreenLow
            // 
            this.btnGreenLow.Location = new System.Drawing.Point(30, 104);
            this.btnGreenLow.Name = "btnGreenLow";
            this.btnGreenLow.Size = new System.Drawing.Size(85, 73);
            this.btnGreenLow.TabIndex = 3;
            this.btnGreenLow.Text = "GREEN *";
            this.btnGreenLow.UseVisualStyleBackColor = true;
            this.btnGreenLow.Click += new System.EventHandler(this.btnGreenLow_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "GREEN **";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGreenMax
            // 
            this.btnGreenMax.Location = new System.Drawing.Point(212, 104);
            this.btnGreenMax.Name = "btnGreenMax";
            this.btnGreenMax.Size = new System.Drawing.Size(85, 73);
            this.btnGreenMax.TabIndex = 5;
            this.btnGreenMax.Text = "GREEN ***";
            this.btnGreenMax.UseVisualStyleBackColor = true;
            this.btnGreenMax.Click += new System.EventHandler(this.btnGreenMax_Click);
            // 
            // btnBlueLow
            // 
            this.btnBlueLow.Location = new System.Drawing.Point(30, 183);
            this.btnBlueLow.Name = "btnBlueLow";
            this.btnBlueLow.Size = new System.Drawing.Size(85, 73);
            this.btnBlueLow.TabIndex = 6;
            this.btnBlueLow.Text = "BLUE *";
            this.btnBlueLow.UseVisualStyleBackColor = true;
            this.btnBlueLow.Click += new System.EventHandler(this.btnBlueLow_Click);
            // 
            // btnBlueMed
            // 
            this.btnBlueMed.Location = new System.Drawing.Point(121, 183);
            this.btnBlueMed.Name = "btnBlueMed";
            this.btnBlueMed.Size = new System.Drawing.Size(85, 73);
            this.btnBlueMed.TabIndex = 7;
            this.btnBlueMed.Text = "BLUE **";
            this.btnBlueMed.UseVisualStyleBackColor = true;
            this.btnBlueMed.Click += new System.EventHandler(this.btnBlueMed_Click);
            // 
            // btnBlueMax
            // 
            this.btnBlueMax.Location = new System.Drawing.Point(212, 183);
            this.btnBlueMax.Name = "btnBlueMax";
            this.btnBlueMax.Size = new System.Drawing.Size(85, 73);
            this.btnBlueMax.TabIndex = 8;
            this.btnBlueMax.Text = "BLUE ***";
            this.btnBlueMax.UseVisualStyleBackColor = true;
            this.btnBlueMax.Click += new System.EventHandler(this.btnBlueMax_Click);
            // 
            // btnXmasMode
            // 
            this.btnXmasMode.Location = new System.Drawing.Point(30, 271);
            this.btnXmasMode.Name = "btnXmasMode";
            this.btnXmasMode.Size = new System.Drawing.Size(267, 43);
            this.btnXmasMode.TabIndex = 9;
            this.btnXmasMode.Text = "X-MAS MODE";
            this.btnXmasMode.UseVisualStyleBackColor = true;
            this.btnXmasMode.Click += new System.EventHandler(this.btnXmasMode_Click);
            // 
            // btnConnectMQTT
            // 
            this.btnConnectMQTT.Location = new System.Drawing.Point(30, 384);
            this.btnConnectMQTT.Name = "btnConnectMQTT";
            this.btnConnectMQTT.Size = new System.Drawing.Size(267, 38);
            this.btnConnectMQTT.TabIndex = 10;
            this.btnConnectMQTT.Text = "Connect to MQTT";
            this.btnConnectMQTT.UseVisualStyleBackColor = true;
            this.btnConnectMQTT.Click += new System.EventHandler(this.btnConnectMQTT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(321, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 318);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(690, 25);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(85, 73);
            this.btnOff.TabIndex = 12;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 476);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mr Tuan\'s Remote";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(558, 104);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(217, 318);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // AnhLamp
            // 
            this.AnhLamp.Location = new System.Drawing.Point(30, 330);
            this.AnhLamp.Name = "AnhLamp";
            this.AnhLamp.Size = new System.Drawing.Size(267, 38);
            this.AnhLamp.TabIndex = 17;
            this.AnhLamp.Text = "Turn ON Anh\'s Lamp";
            this.AnhLamp.UseVisualStyleBackColor = true;
            this.AnhLamp.Click += new System.EventHandler(this.AnhLamp_Click);
            // 
            // btnGreenMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnhLamp);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnConnectMQTT);
            this.Controls.Add(this.btnXmasMode);
            this.Controls.Add(this.btnBlueMax);
            this.Controls.Add(this.btnBlueMed);
            this.Controls.Add(this.btnBlueLow);
            this.Controls.Add(this.btnGreenMax);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGreenLow);
            this.Controls.Add(this.btnRedMax);
            this.Controls.Add(this.btnRedMed);
            this.Controls.Add(this.btnRedLow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "btnGreenMed";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRedLow;
        private System.Windows.Forms.Button btnRedMed;
        private System.Windows.Forms.Button btnRedMax;
        private System.Windows.Forms.Button btnGreenLow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGreenMax;
        private System.Windows.Forms.Button btnBlueLow;
        private System.Windows.Forms.Button btnBlueMed;
        private System.Windows.Forms.Button btnBlueMax;
        private System.Windows.Forms.Button btnXmasMode;
        private System.Windows.Forms.Button btnConnectMQTT;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button AnhLamp;
    }
}
