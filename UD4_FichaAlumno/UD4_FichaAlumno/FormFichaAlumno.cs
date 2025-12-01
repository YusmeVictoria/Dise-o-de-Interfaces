using System;
using System.Windows.Forms;

namespace UD4_FichaAlumno
{
    public partial class FormFichaAlumno : Form
    {
        public FormFichaAlumno()
        {
            InitializeComponent();
        }

        private void FormFichaAlumno_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "Sofía";
            txtApellidos.Text = "Pérez Rodríguez";
            numEdad.Value = 20;
            txtCiclo.Text = "DAM2";
            chkRepetidor.Checked = false;
        }
    }
}
