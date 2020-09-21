using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class PrincipalForm : Form
    {
        DataTable dataTable = new DataTable();
        AgregarForm agregarForm = new AgregarForm();
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Teléfono", typeof(string));

            List<Conctacto> conctactos = new List<Conctacto>()
            {
                new Conctacto(1, "Miguel Matos", "(809)510-8844"),
                new Conctacto(2, "Gonzalo Castillo", "(809)510-8844"),
                new Conctacto(3, "Miguel Matos", "(809)510-8844"),
                new Conctacto(4, "Miguel Matos", "(809)510-8844"),
                new Conctacto(5, "Miguel Matos", "(809)510-8844"),
                new Conctacto(6, "Miguel Matos", "(809)510-8844"),
                new Conctacto(7, "Miguel Matos", "(809)510-8844"),
                new Conctacto(8, "Miguel Matos", "(809)510-8844"),
                new Conctacto(9, "Miguel Matos", "(809)510-8844"),
                new Conctacto(10, "Miguel Matos", "(809)510-8844")

            };

            for (int i = 0; i < conctactos.Count; i++)
            {
                dataTable.Rows.Add(conctactos[i].ID, conctactos[i].Nombre, conctactos[i].Telefono);
            }

            dgContactos.DataSource = dataTable;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarForm.Show();
            Hide();
            agregarForm.tbID.Text = Convert.ToString(dgContactos.Rows.Count + 1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgContactos.Refresh();
        }
    }
}
