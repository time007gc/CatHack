﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatHack.GUI;
using System.Windows.Forms;
using CatHack.modules;

namespace CatHack.GUI
{

    public partial class CatHackGUIOrb : Form
    {
        private static bool orbCheck;
        private static int extraWindup;
        private bool mouseDown;
        private static bool fpsFixChecked;
        private Point offset;

        public CatHackGUIOrb()
        {
            InitializeComponent();
            OrbwalkToggle.IsOn = Properties.Settings.Default.orbToggleIsOn;
            KiteModeToggle.IsOn = Properties.Settings.Default.orbKiteIsOn;
            NormalModeToggle.IsOn = Properties.Settings.Default.orbNormalIsOn;
            RageModeToggle.IsOn = Properties.Settings.Default.orbRageIsOn;
            orbCheck = Properties.Settings.Default.orbCheck;
            extraWindup = Properties.Settings.Default.extraWindup;

            System.Diagnostics.Debug.WriteLine(extraWindup + " | " + orbCheck);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public static int getExtraWindup()
        {
            return extraWindup;
        }

        public static bool getOrbCheck()
        {
            return orbCheck;
        }

        private void KiteModeToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (KiteModeToggle.IsOn == true)
            {
                NormalModeToggle.IsOn = false;
                RageModeToggle.IsOn = false;
                extraWindup = 0;

                KiteSettingTextbox.Text = getExtraWindup().ToString();
            }
        }

        private void NormalModeToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (NormalModeToggle.IsOn == true)
            {
                KiteModeToggle.IsOn = false;
                RageModeToggle.IsOn = false;
                extraWindup = 5;

                NormalSettingTextbox.Text = getExtraWindup().ToString();
            }
        }

        private void RageModeToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (RageModeToggle.IsOn == true)
            {
                KiteModeToggle.IsOn = false;
                NormalModeToggle.IsOn = false;
                extraWindup = 10;

                RageSettingTextbox.Text = getExtraWindup().ToString();
            }
        }

        private void OrbwalkToggle_sliderValueChanged(object sender, EventArgs e)
        {
            if (OrbwalkToggle.IsOn == true)
            {
                orbCheck = true;
            }
            else
            {
                orbCheck = false;
            }
        }

        public static bool getFpsCheck()
        {
            return fpsFixChecked;
        }

        private void RestoreWindowPosition()
        {
            if (Properties.Settings.Default.HasSetDefaults)
            {
                this.WindowState = Properties.Settings.Default.WindowState;
                this.Location = Properties.Settings.Default.Location;
                this.Size = Properties.Settings.Default.Size;
            }
        }

        private void SaveWindowPosition()
        {
            Properties.Settings.Default.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = this.Location;
                Properties.Settings.Default.Size = this.Size;
            }
            else
            {
                Properties.Settings.Default.Location = this.RestoreBounds.Location;
                Properties.Settings.Default.Size = this.RestoreBounds.Size;
            }

            Properties.Settings.Default.HasSetDefaults = true;

            Properties.Settings.Default.Save();
        }

        private void exitPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.orbCheck = getOrbCheck();
            Properties.Settings.Default.extraWindup = getExtraWindup();
            Properties.Settings.Default.orbKiteIsOn = KiteModeToggle.IsOn;
            Properties.Settings.Default.orbToggleIsOn = OrbwalkToggle.IsOn;
            Properties.Settings.Default.orbNormalIsOn = NormalModeToggle.IsOn;
            Properties.Settings.Default.orbRageIsOn = RageModeToggle.IsOn;
            Properties.Settings.Default.Save();

            CatHackGUI mainForm = new CatHackGUI();
            mainForm.Show();
            this.Hide();

            this.SaveWindowPosition();
        }

        private void CatHackGUIOrb_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
        }

        private void OrbwalkSettingClick(object sender, EventArgs e)
        {
            if (FpsFixButton.Visible == false)
            {
                FpsFixButton.Visible = true;
                orbLabelParent.Visible = true;
            }
            else
            {
                FpsFixButton.Visible = false;
                orbLabelParent.Visible = false;
            }

            if (orbLabelParent.Visible == true && kiteLabelParent.Visible == true && normalLabelParent.Visible == true && rageLabelParent.Visible == true)
            {
                windupOverride.Visible = true;
            }
            else
            {
                windupOverride.Visible = false;
            }
        }

        private void KiteSettingClick(object sender, EventArgs e)
        {
            if (KiteSettingTextbox.Visible == false)
            {
                KiteSettingTextbox.Visible = true;
                kiteLabelParent.Visible = true;
            }
            else
            {
                KiteSettingTextbox.Visible = false;
                kiteLabelParent.Visible = false;
            }

            if (orbLabelParent.Visible == true && kiteLabelParent.Visible == true && normalLabelParent.Visible == true && rageLabelParent.Visible == true)
            {
                windupOverride.Visible = true;
            }
            else
            {
                windupOverride.Visible = false;
            }
        }

        private void NormalSettingClick(object sender, EventArgs e)
        {
            if (NormalSettingTextbox.Visible == false)
            {
                NormalSettingTextbox.Visible = true;
                normalLabelParent.Visible = true;
            }
            else
            {
                NormalSettingTextbox.Visible = false;
                normalLabelParent.Visible = false;
            }

            if (orbLabelParent.Visible == true && kiteLabelParent.Visible == true && normalLabelParent.Visible == true && rageLabelParent.Visible == true)
            {
                windupOverride.Visible = true;
            }
            else
            {
                windupOverride.Visible = false;
            }
        }

        private void RageSettingClick(object sender, EventArgs e)
        {
            if (RageSettingTextbox.Visible == false)
            {
                RageSettingTextbox.Visible = true;
                rageLabelParent.Visible = true;
            }
            else
            {
                RageSettingTextbox.Visible = false;
                rageLabelParent.Visible = false;
            }

            if (orbLabelParent.Visible == true && kiteLabelParent.Visible == true && normalLabelParent.Visible == true && rageLabelParent.Visible == true)
            {
                windupOverride.Visible = true;
            }
            else
            {
                windupOverride.Visible = false;
            }
        }

        private void WindupOverrideClick(object sender, MouseEventArgs e)
        {
            if (WindupOverrideTextbox.Visible == false)
            {
                WindupOverrideTextbox.Visible = true;
            }
        }

        private void FpsFixButton_sliderValueChanged(object sender, EventArgs e)
        {
            if (FpsFixButton.IsOn)
            {
                fpsFixChecked = true;
            }
            else
            {
                fpsFixChecked = false;
            }
        }
    }
}