using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class AgregarForm : Form
    {
        PrincipalForm principalForm = (PrincipalForm)Application.OpenForms["PrincipalForm"];
        //PrincipalForm principalForm = new PrincipalForm();
        public AgregarForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conctacto conctacto = new Conctacto(Convert.ToInt32(tbID.Text), tbNombre.Text, tbTelefono.Text);
            Hide();
            
            principalForm.Show();

            //principalForm.dgContactos.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
