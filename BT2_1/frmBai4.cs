﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_1
{
    public partial class frmBai4 : Form
    {
        
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int so;
            for (int i = 0; i <= 10; i++)
            {
                so = rand.Next(1, 100);
                libDSSo.Items.Add(so);
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            lblKetQua.Text = "Không tìm thấy";
            foreach (int so in libDSSo.Items) 
            { 
                if (so == soCanTim)
                    lblKetQua.Text = "Tìm thấy";
                break;
            }
        }
    }
}
