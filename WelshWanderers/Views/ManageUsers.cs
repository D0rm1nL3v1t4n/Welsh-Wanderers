﻿using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            TableManageUsers.MultiSelect = false;
            LoadTableData();
        }
        
        private void LoadTableData()
        {
            StreamReader fileA = new StreamReader("userAccountDetails.txt");
            StreamReader fileB = new StreamReader("userPersonalDetails.txt");
            string lineA;
            string lineB;
            while (null != (lineA = fileA.ReadLine()) && null != (lineB = fileB.ReadLine()))
            {
                string[] sectionA = lineA.Split('|');
                string[] sectionB = lineB.Split('|');
                if (sectionA[3] == InputAccessLevel.Text || InputAccessLevel.Text == null)
                {
                    if ((sectionB[2] + " " + sectionB[3]).Contains(InputName.Text) || InputName.Text == null)
                    {
                        TableManageUsers.Rows.Add(sectionA[0], sectionA[1], sectionB[2], sectionB[3], sectionA[3], sectionA[4]);
                    }
                }
            }
            fileA.Close();
            fileB.Close();
        }

        private void EventFilter_Click(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        private void NavView_Click(object sender, EventArgs e)
        {
            new WelshWanderers.ViewUser(TableManageUsers.SelectedRows[0].Cells[0].Value.ToString()).Show();
            this.Hide();
        }

        private void EventDelete_Click(object sender, EventArgs e)
        {
            new Views.DeleteUserConfirm(TableManageUsers.SelectedRows[0].Cells[0].Value.ToString()).Show();
        }
    }
}
