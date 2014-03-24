namespace Week2JoshuavossIndividual
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnQuick = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnfrequency = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label2freq = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3freq = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4freq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5freq = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label6freq = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7freq = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labe8freq = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9freq = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labe10freq = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11freq = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12freq = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dice2
            // 
            this.Dice2.Image = ((System.Drawing.Image)(resources.GetObject("Dice2.Image")));
            this.Dice2.Location = new System.Drawing.Point(68, 34);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(50, 50);
            this.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice2.TabIndex = 2;
            this.Dice2.TabStop = false;
            // 
            // Dice1
            // 
            this.Dice1.Image = ((System.Drawing.Image)(resources.GetObject("Dice1.Image")));
            this.Dice1.Location = new System.Drawing.Point(12, 34);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(50, 50);
            this.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice1.TabIndex = 1;
            this.Dice1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(124, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 82);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(124, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(304, 119);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(13, 119);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(105, 23);
            this.btnQuick.TabIndex = 7;
            this.btnQuick.Text = "Quick Roll";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnfrequency
            // 
            this.btnfrequency.Location = new System.Drawing.Point(431, 119);
            this.btnfrequency.Name = "btnfrequency";
            this.btnfrequency.Size = new System.Drawing.Size(75, 23);
            this.btnfrequency.TabIndex = 9;
            this.btnfrequency.Text = "Frequency";
            this.btnfrequency.UseVisualStyleBackColor = true;
            this.btnfrequency.Click += new System.EventHandler(this.btnfrequency_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "2";
            // 
            // label2freq
            // 
            this.label2freq.AutoSize = true;
            this.label2freq.Location = new System.Drawing.Point(407, 31);
            this.label2freq.Name = "label2freq";
            this.label2freq.Size = new System.Drawing.Size(13, 13);
            this.label2freq.TabIndex = 11;
            this.label2freq.Text = "0";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(426, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(34, 69);
            this.listBox2.TabIndex = 12;
            this.listBox2.Visible = false;
            // 
            // label3freq
            // 
            this.label3freq.AutoSize = true;
            this.label3freq.Location = new System.Drawing.Point(407, 44);
            this.label3freq.Name = "label3freq";
            this.label3freq.Size = new System.Drawing.Size(13, 13);
            this.label3freq.TabIndex = 14;
            this.label3freq.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "3";
            // 
            // label4freq
            // 
            this.label4freq.AutoSize = true;
            this.label4freq.Location = new System.Drawing.Point(407, 57);
            this.label4freq.Name = "label4freq";
            this.label4freq.Size = new System.Drawing.Size(13, 13);
            this.label4freq.TabIndex = 16;
            this.label4freq.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "4";
            // 
            // label5freq
            // 
            this.label5freq.AutoSize = true;
            this.label5freq.Location = new System.Drawing.Point(407, 71);
            this.label5freq.Name = "label5freq";
            this.label5freq.Size = new System.Drawing.Size(13, 13);
            this.label5freq.TabIndex = 18;
            this.label5freq.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "5";
            // 
            // label6freq
            // 
            this.label6freq.AutoSize = true;
            this.label6freq.Location = new System.Drawing.Point(407, 84);
            this.label6freq.Name = "label6freq";
            this.label6freq.Size = new System.Drawing.Size(13, 13);
            this.label6freq.TabIndex = 20;
            this.label6freq.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "6";
            // 
            // label7freq
            // 
            this.label7freq.AutoSize = true;
            this.label7freq.Location = new System.Drawing.Point(407, 97);
            this.label7freq.Name = "label7freq";
            this.label7freq.Size = new System.Drawing.Size(13, 13);
            this.label7freq.TabIndex = 22;
            this.label7freq.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "7";
            // 
            // labe8freq
            // 
            this.labe8freq.AutoSize = true;
            this.labe8freq.Location = new System.Drawing.Point(492, 34);
            this.labe8freq.Name = "labe8freq";
            this.labe8freq.Size = new System.Drawing.Size(13, 13);
            this.labe8freq.TabIndex = 24;
            this.labe8freq.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "8";
            // 
            // label9freq
            // 
            this.label9freq.AutoSize = true;
            this.label9freq.Location = new System.Drawing.Point(492, 47);
            this.label9freq.Name = "label9freq";
            this.label9freq.Size = new System.Drawing.Size(13, 13);
            this.label9freq.TabIndex = 26;
            this.label9freq.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(472, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "9";
            // 
            // labe10freq
            // 
            this.labe10freq.AutoSize = true;
            this.labe10freq.Location = new System.Drawing.Point(492, 60);
            this.labe10freq.Name = "labe10freq";
            this.labe10freq.Size = new System.Drawing.Size(13, 13);
            this.labe10freq.TabIndex = 28;
            this.labe10freq.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(472, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "10";
            // 
            // label11freq
            // 
            this.label11freq.AutoSize = true;
            this.label11freq.Location = new System.Drawing.Point(492, 73);
            this.label11freq.Name = "label11freq";
            this.label11freq.Size = new System.Drawing.Size(13, 13);
            this.label11freq.TabIndex = 30;
            this.label11freq.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(472, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "11";
            // 
            // label12freq
            // 
            this.label12freq.AutoSize = true;
            this.label12freq.Location = new System.Drawing.Point(493, 84);
            this.label12freq.Name = "label12freq";
            this.label12freq.Size = new System.Drawing.Size(13, 13);
            this.label12freq.TabIndex = 32;
            this.label12freq.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(472, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 154);
            this.Controls.Add(this.label12freq);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label11freq);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labe10freq);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9freq);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labe8freq);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7freq);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6freq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5freq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4freq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3freq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2freq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfrequency);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dice Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnfrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label2freq;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3freq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4freq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5freq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label6freq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7freq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labe8freq;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9freq;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labe10freq;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11freq;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12freq;
        private System.Windows.Forms.Label label20;
    }
}

