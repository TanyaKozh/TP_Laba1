﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TP_Laba1
{
    public partial class Form1 : Form
    {
        private ArrayList myAL;
        public Form1(ArrayList myList)
        {
            InitializeComponent();
            this.myAL = myList;
        }

        // Сделайте некоторые случайные данные.
      

        private void Chart1_Paint(object sender, PaintEventArgs e)
        {
            int i;
            for (i = 0; i < myAL.Count; i++)
            {

                chart1.Series["Series1"].Points.DataBindY(myAL);
            }
            chart1.Series["Series1"].IsVisibleInLegend = false;
            chart1.Series["Series1"]["PointWidth"] = "1";
        }
    }
}
