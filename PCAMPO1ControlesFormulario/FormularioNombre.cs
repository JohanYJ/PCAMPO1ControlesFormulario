﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAMPO1ControlesFormulario
{
    public partial class FormularioNombre : Form
    {
        public FormularioNombre()
        {
            InitializeComponent();
        }

        private void FormularioNombre_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblResultado.Text = "Hola, " + nombre;
        }
    }
}
