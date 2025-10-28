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
    public partial class FormularioIntereses : Form
    {
        public FormularioIntereses()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<string> intereses = new List<string>();

            if (chkMusica.Checked) intereses.Add("Música");
            if (chkDeporte.Checked) intereses.Add("Deporte");
            if (chkLectura.Checked) intereses.Add("Lectura");
            if (chkCine.Checked) intereses.Add("Cine");

            lblIntereses.Text = "Te interesan: " + string.Join(", ", intereses);
        }
    }
}
