﻿using RebelScum.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RebelScum.Engine;

namespace RebelScum
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MissionsButton_Click(object sender, EventArgs e)
        {
            var missionsScreen = new Screens.MissionsScreen();
            missionsScreen.Owner = this;
            missionsScreen.Show();
            this.Hide();
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Engine.RebelEngine.Save();
            Application.Exit();
        }

        private void btnLoadGame_MouseClick(object sender, MouseEventArgs e)
        {
            Engine.RebelEngine.Load();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            Engine.RebelEngine.Save();
        }

        private void btnAdvanceDay_Click(object sender, EventArgs e)
        {
            RebelEngine.CalendarEngine.UpdateDate(1);
        }

        private void btnAdvanceWeek_Click(object sender, EventArgs e)
        {
            RebelEngine.CalendarEngine.UpdateDate(7);
        }

        private void btnAdvanceMonth_Click(object sender, EventArgs e)
        {
            RebelEngine.CalendarEngine.UpdateDate(30);
        }

        private void btnAdvanceSemester_Click(object sender, EventArgs e)
        {
            RebelEngine.CalendarEngine.UpdateDate(30*6);
        }
    }
}
