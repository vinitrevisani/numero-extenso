﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExtenso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtExtenso.Clear();
        }

        private void btnEscrever_Click(object sender, EventArgs e)
        {
            Extenso X = new Extenso();
            txtExtenso.Text = X.Escrever(txtNumero.Text);
        }
    }
}
