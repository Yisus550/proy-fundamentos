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
    public partial class RegistroMascotas : Form
    {
        public RegistroMascotas()
        {
            InitializeComponent();
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            new frm_historial_clinico().ShowDialog();
            this.Hide();
        }
    }
}
