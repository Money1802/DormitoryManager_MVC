﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormChart
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            crp_DoanhThu cry = new crp_DoanhThu();
            crystalReportViewer1.ReportSource = cry;
            crystalReportViewer1.Refresh();
        }
    }
}
