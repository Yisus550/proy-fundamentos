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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            new frm_principal().closeLogin();
            new frm_principal().setPanelMenuEnable(true);
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
