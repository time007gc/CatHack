﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHack
{
    public partial class CatHackMain : Form
    {
        private static bool checkSpaceGlide;
        private static bool checkKiteMode;
        private static bool thresholdCheck;
        private static bool cathackCheck;
        private static string userKeycode;
        private static string userPing;
        private static string selectedChampion;
        private static float WindupPercent;
        private static float bWindupTime;
        private static float WindupModifier;

        public CatHackMain()
        {
            InitializeComponent();
        }

        private void spaceGlideBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSpaceGlideBox.Checked)
            {
                checkSpaceGlide = true;
                checkKiteMode = false;
                thresholdCheck = false;
                checkKiteModeBox.Checked = false;
                thresholdCheckBox.Checked = false;
            }
        }

        private void kiteModeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKiteModeBox.Checked)
            {
                checkKiteMode = true;
                checkSpaceGlide = false;
                thresholdCheck = false;
                checkSpaceGlideBox.Checked = false;
                thresholdCheckBox.Checked = false;
            }
        }

        private void thresholdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thresholdCheckBox.Checked)
            {
                checkSpaceGlide = false;
                checkKiteMode = true;
                thresholdCheck = true;        
                checkSpaceGlideBox.Checked = false;
                checkKiteModeBox.Checked = true;
            }
        }

        private void userPingBox_TextChanged(object sender, EventArgs e)
        {
            userPing = textBox1.Text;
        }

        private void userOrbWalkBind_TextChanged(object sender, EventArgs e)
        {
            userKeycode = textBox2.Text;
        }

        private void cathackStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cathackStart.Checked)
            {
                cathackCheck = true;
            }
            else
            {
                cathackCheck = false;
            }
        }

        public bool getCatHack()
        {
            return cathackCheck;
        }

        public bool getSpaceGlide()
        {
            return checkSpaceGlide;
        }

        public bool getKiteMode()
        {
            return checkKiteMode;
        }

        public bool getThresholdCheck()
        {
            return thresholdCheck;
        }

        public float getWindupPercent()
        {
            return WindupPercent;
        }

        public float getBaseWindupTime()
        {
            return bWindupTime;
        }

        public float getWindupModifier()
        {
            return WindupModifier;
        }

        public string getUserPing()
        {
            return userPing;
        }

        public string getUserKeycode()
        {
            return userKeycode;
        }
        private void championBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedChampion = championBox.Items[championBox.SelectedIndex].ToString();

            if(selectedChampion == "Aphelios")
            {
                WindupPercent = 15.333f;
                bWindupTime = 0.64f;
            }
            if(selectedChampion == "Ashe")
            {
                WindupPercent = 21.93f;
                bWindupTime = 0.658f;
            }
            if(selectedChampion == "Azir")
            {
                WindupPercent = 15.625f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Bard")
            {
                WindupPercent = 18.75f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Caitlyn")
            {
                WindupPercent = 17.708f;
                bWindupTime = 0.681f;
            }
            if(selectedChampion == "Corki")
            {
                WindupPercent = 10.00f;
                bWindupTime = 0.638f;
            }
            if(selectedChampion == "Draven")
            {
                WindupPercent = 15.614f;
                bWindupTime = 0.679f;
            }
            if(selectedChampion == "Ezreal")
            {
                WindupPercent = 18.839f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Gnar")
            {
                WindupPercent = 14.6f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Jayce") // SPECIAL CASE
            {
                WindupPercent = 9.5f;
                bWindupTime = 0.658f;
                WindupModifier = 0.005f;
            }
            if(selectedChampion == "Jinx")
            {
                WindupPercent = 16.875f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Kai'Sa")
            {
                WindupPercent = 16.108f;
                bWindupTime = 0.644f;
            }
            if(selectedChampion == "Kalista") // SPECIAL CASE
            {
                WindupPercent = 36.000f;
                bWindupTime = 0.694f;
                WindupModifier = 0.75f;
            }
            if(selectedChampion == "Kayle")
            {
                WindupPercent = 19.355f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Kennen")
            {
                WindupPercent = 20.00f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Kindred")
            {
                WindupPercent = 17.544f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Kog'Maw")
            {
                WindupPercent = 16.622f;
                bWindupTime = 0.665f;
            }
            if(selectedChampion == "Lucian")
            {
                WindupPercent = 15.00f;
                bWindupTime = 0.638f;
            }
            if(selectedChampion == "Miss Fortune")
            {
                WindupPercent = 14.801f;
                bWindupTime = 0.656f;
            }
            if(selectedChampion == "Neeko")
            {
                WindupPercent = 21.484f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Samira")
            {
                WindupPercent = 15.00f;
                bWindupTime = 0.658f;
            }
            if(selectedChampion == "Quinn")
            {
                WindupPercent = 17.544f;
                bWindupTime = 0.668f;
            }
            if(selectedChampion == "Sivir")
            {
                WindupPercent = 12.00f;
                bWindupTime = 0.625f;
            }
            if(selectedChampion == "Teemo")
            {
                WindupPercent = 21.574f;
                bWindupTime = 0.69f;
            }
            if (selectedChampion == "Tristana")
            {
                WindupPercent = 14.801f;
                bWindupTime = 0.656f;
            }
            if (selectedChampion == "Twitch")
            {
                WindupPercent = 20.192f;
                bWindupTime = 0.679f;
            }
            if (selectedChampion == "Twisted Fate")
            {
                WindupPercent = 24.404f;
                bWindupTime = 0.651f;
            }
            if (selectedChampion == "Varus")
            {
                WindupPercent = 17.544f;
                bWindupTime = 0.658f;
            }
            if (selectedChampion == "Vayne")
            {
                WindupPercent = 17.544f;
                bWindupTime = 0.658f;
            }
            if (selectedChampion == "Xayah")
            {
                WindupPercent = 17.687f;
                bWindupTime = 0.625f;
            }
        }

        private void keycodeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cathackcodes.weebly.com/");
        }
    }
}
