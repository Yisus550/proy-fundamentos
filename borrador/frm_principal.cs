﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrador
{
    public partial class frm_principal : Form
    {
        Boolean loginSucces = false;

        public frm_principal()
        {
            InitializeComponent();
            openChildForm(new frm_login());
        }

        public void closeLogin()
        {
            panelChildForm.Controls.Clear();
        }

        public static Form MainForm { get; set; }

        private static Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistroMascotas_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_registro_mascotas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelMenu2.Visible = false;
        }
    }
}
