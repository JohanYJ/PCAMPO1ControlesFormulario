using System;
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
    public partial class FormularioCarrera : Form
    {
        public FormularioCarrera()
        {
            InitializeComponent();
        }

        private void FormularioCarrera_Load(object sender, EventArgs e)
        {
            cmbCarrera.Items.AddRange(new string[]
            {
             "Ingeniería",
             "Medicina",
             "Derecho",
             "Arquitectura"
            });
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string carrera = cmbCarrera.SelectedItem?.ToString();
            lblSeleccion.Text = $"Has elegido: {carrera}";
        }
    }
}
