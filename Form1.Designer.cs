﻿namespace jth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.proxylist_tbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_tbox = new System.Windows.Forms.TextBox();
            this.combolist_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checker_radio = new System.Windows.Forms.RadioButton();
            this.bruteforce_radio = new System.Windows.Forms.RadioButton();
            this.attack_btn = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.RichTextBox();
            this.configselect_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.config_tbox = new System.Windows.Forms.TextBox();
            this.passwordlistselect_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordlist_tbox = new System.Windows.Forms.TextBox();
            this.username_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jth.Properties.Resources.jth;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 252);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 322);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Github : github.com/hanicraft\r\nInstagram : mohamadhanijanaty85\r\nReddit : HaniSoft" +
    "wares\r\nEmail : mohamadhanijanaty85@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version 1\r\nCreated By Mohamad Hani Janaty\r\nLicense : MIT\r\nNote : the author is no" +
    "t responsible for any \r\ndamages done to other people\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.proxylist_tbox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.combo_tbox);
            this.panel2.Controls.Add(this.combolist_btn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.checker_radio);
            this.panel2.Controls.Add(this.bruteforce_radio);
            this.panel2.Controls.Add(this.attack_btn);
            this.panel2.Controls.Add(this.results);
            this.panel2.Controls.Add(this.configselect_btn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.config_tbox);
            this.panel2.Controls.Add(this.passwordlistselect_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.passwordlist_tbox);
            this.panel2.Controls.Add(this.username_tbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(265, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 558);
            this.panel2.TabIndex = 2;
            // 
            // proxylist_tbox
            // 
            this.proxylist_tbox.Location = new System.Drawing.Point(6, 244);
            this.proxylist_tbox.Name = "proxylist_tbox";
            this.proxylist_tbox.Size = new System.Drawing.Size(298, 20);
            this.proxylist_tbox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Proxy List HTTP";
            // 
            // combo_tbox
            // 
            this.combo_tbox.Enabled = false;
            this.combo_tbox.Location = new System.Drawing.Point(6, 166);
            this.combo_tbox.Name = "combo_tbox";
            this.combo_tbox.Size = new System.Drawing.Size(298, 20);
            this.combo_tbox.TabIndex = 15;
            // 
            // combolist_btn
            // 
            this.combolist_btn.Enabled = false;
            this.combolist_btn.Location = new System.Drawing.Point(6, 192);
            this.combolist_btn.Name = "combolist_btn";
            this.combolist_btn.Size = new System.Drawing.Size(75, 23);
            this.combolist_btn.TabIndex = 14;
            this.combolist_btn.Text = "Select File";
            this.combolist_btn.UseVisualStyleBackColor = true;
            this.combolist_btn.Click += new System.EventHandler(this.combolist_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Combo List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mode :";
            // 
            // checker_radio
            // 
            this.checker_radio.AutoSize = true;
            this.checker_radio.Location = new System.Drawing.Point(181, 381);
            this.checker_radio.Name = "checker_radio";
            this.checker_radio.Size = new System.Drawing.Size(65, 17);
            this.checker_radio.TabIndex = 11;
            this.checker_radio.Text = "Checker";
            this.checker_radio.UseVisualStyleBackColor = true;
            this.checker_radio.CheckedChanged += new System.EventHandler(this.checker_radio_CheckedChanged);
            // 
            // bruteforce_radio
            // 
            this.bruteforce_radio.AutoSize = true;
            this.bruteforce_radio.Checked = true;
            this.bruteforce_radio.Location = new System.Drawing.Point(52, 381);
            this.bruteforce_radio.Name = "bruteforce_radio";
            this.bruteforce_radio.Size = new System.Drawing.Size(77, 17);
            this.bruteforce_radio.TabIndex = 10;
            this.bruteforce_radio.TabStop = true;
            this.bruteforce_radio.Text = "BruteForce";
            this.bruteforce_radio.UseVisualStyleBackColor = true;
            // 
            // attack_btn
            // 
            this.attack_btn.Location = new System.Drawing.Point(100, 404);
            this.attack_btn.Name = "attack_btn";
            this.attack_btn.Size = new System.Drawing.Size(100, 23);
            this.attack_btn.TabIndex = 9;
            this.attack_btn.Text = "Start Attack";
            this.attack_btn.UseVisualStyleBackColor = true;
            this.attack_btn.Click += new System.EventHandler(this.attack_btn_Click);
            // 
            // results
            // 
            this.results.Enabled = false;
            this.results.Location = new System.Drawing.Point(6, 436);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(298, 119);
            this.results.TabIndex = 8;
            this.results.Text = "";
            // 
            // configselect_btn
            // 
            this.configselect_btn.Location = new System.Drawing.Point(9, 346);
            this.configselect_btn.Name = "configselect_btn";
            this.configselect_btn.Size = new System.Drawing.Size(75, 23);
            this.configselect_btn.TabIndex = 7;
            this.configselect_btn.Text = "Select File";
            this.configselect_btn.UseVisualStyleBackColor = true;
            this.configselect_btn.Click += new System.EventHandler(this.configselect_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Config";
            // 
            // config_tbox
            // 
            this.config_tbox.Location = new System.Drawing.Point(9, 320);
            this.config_tbox.Name = "config_tbox";
            this.config_tbox.Size = new System.Drawing.Size(298, 20);
            this.config_tbox.TabIndex = 5;
            // 
            // passwordlistselect_btn
            // 
            this.passwordlistselect_btn.Location = new System.Drawing.Point(6, 104);
            this.passwordlistselect_btn.Name = "passwordlistselect_btn";
            this.passwordlistselect_btn.Size = new System.Drawing.Size(75, 23);
            this.passwordlistselect_btn.TabIndex = 4;
            this.passwordlistselect_btn.Text = "Select File";
            this.passwordlistselect_btn.UseVisualStyleBackColor = true;
            this.passwordlistselect_btn.Click += new System.EventHandler(this.passwordlistselect_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password List";
            // 
            // passwordlist_tbox
            // 
            this.passwordlist_tbox.Location = new System.Drawing.Point(6, 78);
            this.passwordlist_tbox.Name = "passwordlist_tbox";
            this.passwordlist_tbox.Size = new System.Drawing.Size(298, 20);
            this.passwordlist_tbox.TabIndex = 2;
            // 
            // username_tbox
            // 
            this.username_tbox.Location = new System.Drawing.Point(6, 28);
            this.username_tbox.Name = "username_tbox";
            this.username_tbox.Size = new System.Drawing.Size(298, 20);
            this.username_tbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files|*.txt";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Config Files|*.ini";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jack The Hacker By Mohamad Hani Janaty";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button passwordlistselect_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordlist_tbox;
        private System.Windows.Forms.TextBox username_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button attack_btn;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Button configselect_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox config_tbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton checker_radio;
        private System.Windows.Forms.RadioButton bruteforce_radio;
        private System.Windows.Forms.TextBox combo_tbox;
        private System.Windows.Forms.Button combolist_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox proxylist_tbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

