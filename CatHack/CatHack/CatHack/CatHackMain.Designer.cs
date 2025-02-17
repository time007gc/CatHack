﻿
namespace CatHack
{
    partial class CatHackMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatHackMain));
            this.checkNormalModeBox = new System.Windows.Forms.CheckBox();
            this.checkKiteModeBox = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkExMachinaMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.useAttackSpeedCheckBox = new System.Windows.Forms.CheckBox();
            this.attackSpeedScreenshotCheckBox = new System.Windows.Forms.CheckBox();
            this.keycodeLink = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cathackStart = new System.Windows.Forms.CheckBox();
            this.championBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.extraWindupBox = new System.Windows.Forms.TextBox();
            this.kalistaExploitCheckBox = new System.Windows.Forms.CheckBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.windupModifierLabel = new System.Windows.Forms.Label();
            this.baseWindupTimeLabel = new System.Windows.Forms.Label();
            this.windupPercentLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.championPic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.championPic)).BeginInit();
            this.SuspendLayout();
            // 
            // checkNormalModeBox
            // 
            this.checkNormalModeBox.AutoSize = true;
            this.checkNormalModeBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkNormalModeBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkNormalModeBox.Location = new System.Drawing.Point(17, 40);
            this.checkNormalModeBox.Name = "checkNormalModeBox";
            this.checkNormalModeBox.Size = new System.Drawing.Size(245, 17);
            this.checkNormalModeBox.TabIndex = 0;
            this.checkNormalModeBox.Text = "Normal Mode (More DPS, less spacing, stable)";
            this.checkNormalModeBox.UseVisualStyleBackColor = false;
            this.checkNormalModeBox.CheckedChanged += new System.EventHandler(this.normalModeBox_CheckedChanged);
            // 
            // checkKiteModeBox
            // 
            this.checkKiteModeBox.AutoSize = true;
            this.checkKiteModeBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkKiteModeBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkKiteModeBox.Location = new System.Drawing.Point(17, 82);
            this.checkKiteModeBox.Name = "checkKiteModeBox";
            this.checkKiteModeBox.Size = new System.Drawing.Size(199, 17);
            this.checkKiteModeBox.TabIndex = 1;
            this.checkKiteModeBox.Text = "Kite Mode (Less DPS, more spacing)";
            this.checkKiteModeBox.UseVisualStyleBackColor = false;
            this.checkKiteModeBox.CheckedChanged += new System.EventHandler(this.kiteModeBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orb Walking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.checkExMachinaMode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkKiteModeBox);
            this.panel1.Controls.Add(this.checkNormalModeBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(21, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 169);
            this.panel1.TabIndex = 4;
            // 
            // checkExMachinaMode
            // 
            this.checkExMachinaMode.AutoSize = true;
            this.checkExMachinaMode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkExMachinaMode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkExMachinaMode.Location = new System.Drawing.Point(18, 125);
            this.checkExMachinaMode.Name = "checkExMachinaMode";
            this.checkExMachinaMode.Size = new System.Drawing.Size(239, 17);
            this.checkExMachinaMode.TabIndex = 4;
            this.checkExMachinaMode.Text = "Ex Machina Mode (Best DPS, cancels autos)";
            this.checkExMachinaMode.UseVisualStyleBackColor = false;
            this.checkExMachinaMode.CheckedChanged += new System.EventHandler(this.exMachinaModeBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(107, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.useAttackSpeedCheckBox);
            this.panel2.Controls.Add(this.attackSpeedScreenshotCheckBox);
            this.panel2.Controls.Add(this.keycodeLink);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(21, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 205);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(55, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Use saved location of your ping?";
            // 
            // useAttackSpeedCheckBox
            // 
            this.useAttackSpeedCheckBox.AutoSize = true;
            this.useAttackSpeedCheckBox.Location = new System.Drawing.Point(26, 141);
            this.useAttackSpeedCheckBox.Name = "useAttackSpeedCheckBox";
            this.useAttackSpeedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.useAttackSpeedCheckBox.TabIndex = 18;
            this.useAttackSpeedCheckBox.UseVisualStyleBackColor = true;
            this.useAttackSpeedCheckBox.CheckedChanged += new System.EventHandler(this.useAttackSpeedCheckBox_CheckedChanged);
            // 
            // attackSpeedScreenshotCheckBox
            // 
            this.attackSpeedScreenshotCheckBox.AutoSize = true;
            this.attackSpeedScreenshotCheckBox.Location = new System.Drawing.Point(26, 169);
            this.attackSpeedScreenshotCheckBox.Name = "attackSpeedScreenshotCheckBox";
            this.attackSpeedScreenshotCheckBox.Size = new System.Drawing.Size(15, 14);
            this.attackSpeedScreenshotCheckBox.TabIndex = 15;
            this.attackSpeedScreenshotCheckBox.UseVisualStyleBackColor = true;
            this.attackSpeedScreenshotCheckBox.CheckedChanged += new System.EventHandler(this.attackSpeedScreenshotCheckBox_CheckedChanged);
            // 
            // keycodeLink
            // 
            this.keycodeLink.AutoSize = true;
            this.keycodeLink.LinkColor = System.Drawing.Color.White;
            this.keycodeLink.Location = new System.Drawing.Point(55, 56);
            this.keycodeLink.Name = "keycodeLink";
            this.keycodeLink.Size = new System.Drawing.Size(212, 13);
            this.keycodeLink.TabIndex = 8;
            this.keycodeLink.TabStop = true;
            this.keycodeLink.Text = "OrbWalk Keycode (What key to start kiting)";
            this.keycodeLink.UseWaitCursor = true;
            this.keycodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.keycodeLink_LinkClicked);
            // 
            // rageLabelParent
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(55, 169);
            this.label8.Name = "rageLabelParent";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Save the location of your ping?";
            // 
            // kiteLabelParent
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(55, 161);
            this.label7.Name = "kiteLabelParent";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(55, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AS Threshold (Orb Walk at target AS)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.userOrbWalkBind_TextChanged);
            // 
            // cathackStart
            // 
            this.cathackStart.AutoSize = true;
            this.cathackStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cathackStart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cathackStart.Location = new System.Drawing.Point(100, 208);
            this.cathackStart.Name = "cathackStart";
            this.cathackStart.Size = new System.Drawing.Size(110, 17);
            this.cathackStart.TabIndex = 6;
            this.cathackStart.Text = "Activate CatHack";
            this.cathackStart.UseVisualStyleBackColor = false;
            this.cathackStart.CheckedChanged += new System.EventHandler(this.cathackStart_CheckedChanged);
            // 
            // championBox
            // 
            this.championBox.BackColor = System.Drawing.Color.Tomato;
            this.championBox.DropDownHeight = 50;
            this.championBox.FormattingEnabled = true;
            this.championBox.IntegralHeight = false;
            this.championBox.Items.AddRange(new object[] {
            "Aphelios",
            "Ashe",
            "Azir",
            "Bard",
            "Caitlyn",
            "Corki",
            "Draven",
            "Ezreal",
            "Gnar",
            "Jayce",
            "Jinx",
            "Kai\'Sa",
            "Kalista",
            "Kayle",
            "Kennen",
            "Kindred",
            "Kog\'Maw",
            "Lucian",
            "Miss Fortune",
            "Neeko",
            "Quinn",
            "Samira",
            "Soraka",
            "Sivir",
            "Teemo",
            "Tristana",
            "Twitch",
            "Twisted Fate",
            "Varus",
            "Vayne",
            "Xayah",
            "Zilean"});
            this.championBox.Location = new System.Drawing.Point(14, 42);
            this.championBox.Name = "championBox";
            this.championBox.Size = new System.Drawing.Size(319, 21);
            this.championBox.TabIndex = 7;
            this.championBox.SelectionChangeCommitted += new System.EventHandler(this.championBox_SelectionChangeCommitted);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.extraWindupBox);
            this.panel3.Controls.Add(this.kalistaExploitCheckBox);
            this.panel3.Controls.Add(this.hScrollBar1);
            this.panel3.Controls.Add(this.windupModifierLabel);
            this.panel3.Controls.Add(this.baseWindupTimeLabel);
            this.panel3.Controls.Add(this.windupPercentLabel);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.championPic);
            this.panel3.Controls.Add(this.championBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(326, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 401);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(113, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Extra Windup Override";
            // 
            // extraWindupBox
            // 
            this.extraWindupBox.Location = new System.Drawing.Point(119, 350);
            this.extraWindupBox.Name = "extraWindupBox";
            this.extraWindupBox.Size = new System.Drawing.Size(100, 20);
            this.extraWindupBox.TabIndex = 8;
            // 
            // kalistaExploitCheckBox
            // 
            this.kalistaExploitCheckBox.AutoSize = true;
            this.kalistaExploitCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.kalistaExploitCheckBox.Location = new System.Drawing.Point(14, 82);
            this.kalistaExploitCheckBox.Name = "kalistaExploitCheckBox";
            this.kalistaExploitCheckBox.Size = new System.Drawing.Size(240, 17);
            this.kalistaExploitCheckBox.TabIndex = 15;
            this.kalistaExploitCheckBox.Text = "Use Wavedash Exploit? (Unsafe/Detectable)";
            this.kalistaExploitCheckBox.UseVisualStyleBackColor = true;
            this.kalistaExploitCheckBox.CheckedChanged += new System.EventHandler(this.kalistaExploitCheckBox_CheckedChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(7, 309);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(333, 14);
            this.hScrollBar1.TabIndex = 7;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // windupModifierLabel
            // 
            this.windupModifierLabel.AutoSize = true;
            this.windupModifierLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.windupModifierLabel.Location = new System.Drawing.Point(261, 213);
            this.windupModifierLabel.Name = "windupModifierLabel";
            this.windupModifierLabel.Size = new System.Drawing.Size(0, 13);
            this.windupModifierLabel.TabIndex = 14;
            // 
            // baseWindupTimeLabel
            // 
            this.baseWindupTimeLabel.AutoSize = true;
            this.baseWindupTimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.baseWindupTimeLabel.Location = new System.Drawing.Point(261, 166);
            this.baseWindupTimeLabel.Name = "baseWindupTimeLabel";
            this.baseWindupTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.baseWindupTimeLabel.TabIndex = 13;
            // 
            // windupPercentLabel
            // 
            this.windupPercentLabel.AutoSize = true;
            this.windupPercentLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.windupPercentLabel.Location = new System.Drawing.Point(261, 119);
            this.windupPercentLabel.Name = "windupPercentLabel";
            this.windupPercentLabel.Size = new System.Drawing.Size(0, 13);
            this.windupPercentLabel.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(153, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Windup Percent:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(153, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Base Windup Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(153, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Windup Modifier:";
            // 
            // championPic
            // 
            this.championPic.Image = global::CatHack.Properties.Resources.rsz_1mak_logo_2_nobg;
            this.championPic.Location = new System.Drawing.Point(14, 118);
            this.championPic.Name = "championPic";
            this.championPic.Size = new System.Drawing.Size(112, 108);
            this.championPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.championPic.TabIndex = 8;
            this.championPic.TabStop = false;
            // 
            // orbLabelParent
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(137, 9);
            this.label6.Name = "orbLabelParent";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Champion Selector";
            // 
            // CatHackMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(700, 454);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cathackStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatHackMain";
            this.Text = "CatHackMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.championPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkNormalModeBox;
        private System.Windows.Forms.CheckBox checkKiteModeBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cathackStart;
        private System.Windows.Forms.ComboBox championBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel keycodeLink;
        private System.Windows.Forms.CheckBox attackSpeedScreenshotCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox useAttackSpeedCheckBox;
        private System.Windows.Forms.PictureBox championPic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label windupModifierLabel;
        private System.Windows.Forms.Label baseWindupTimeLabel;
        private System.Windows.Forms.Label windupPercentLabel;
        private System.Windows.Forms.CheckBox kalistaExploitCheckBox;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox extraWindupBox;
        private System.Windows.Forms.CheckBox checkExMachinaMode;
        private System.Windows.Forms.Label label3;
    }
}