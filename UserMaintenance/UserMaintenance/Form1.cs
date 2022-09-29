﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<Entities.User> users = new BindingList<Entities.User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.FullName;
            
            btnAdd.Text = Resource1.Add;
            btnSave.Text = Resource1.Save;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new Entities.User()
            {
                FullName = textBox1.Text,
                

            };
            users.Add(u);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var u in users)
                {
                    sw.Write(u.ID);
                    sw.Write(";");
                    sw.Write(u.FullName);
                    sw.Write(";");
                    sw.WriteLine();
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = listUsers.SelectedIndex;
            users.RemoveAt(id);
            
        }
    }
}
