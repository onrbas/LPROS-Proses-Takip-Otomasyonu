﻿using LPROS.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms.Table.Update
{
    public partial class Update_Renk : Form
    {
        public Update_Renk()
        {
            InitializeComponent();
        }

        private void Update_Renk_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);
        }
    }
}
