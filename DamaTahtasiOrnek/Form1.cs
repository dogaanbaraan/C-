﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;
            for (int i = 1; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 1; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i,j].Height = 50;
                    this.Controls.Add(buttons[i,j]);
                    buttons[i, j].Left = left;
                    buttons[i,j].Top = top;
                    left += 50;

                }
                top += 50;
                left = 0;
                
            }
        }
    }
}
