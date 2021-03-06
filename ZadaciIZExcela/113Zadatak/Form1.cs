﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _113Zadatak
{
    public partial class Form1 : Form
    {
        Sort sort = new Sort();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInputList_Click(object sender, EventArgs e)
        {
            sort.AddToLIst(txtNumber.Text);
            RefreshList();
        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            sort.SortedList();
            RefreshList();
        }

        private void btnOriginalList_Click(object sender, EventArgs e)
        {
            sort.OriginalList();
            RefreshList();
        }

        private void RefreshList()
        {
            lbNumbers.DataSource = null;
            lbNumbers.DataSource = sort.numberList;
        }
    }
}
