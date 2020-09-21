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
        string _Mensaje;
        string _Titulo;
        public int FilaSeleccionada;
        public string FilaID;
        public string FilaNombre;
        public string FilaTelefono;

        MessageBoxButtons _BotonesYesNo = MessageBoxButtons.YesNo;
        DialogResult _Resultado;

        public DataTable dataTable = new DataTable();
        AgregarForm agregarForm = new AgregarForm();
        
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Teléfono", typeof(string));

            List<Conctacto> conctactos = new List<Conctacto>()
            {
                new Conctacto(1, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(2, "Gonzalo Castillo", "(809) 510-8844"),
                new Conctacto(3, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(4, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(5, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(6, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(7, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(8, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(9, "Miguel Matos", "(809) 510-8844"),
                new Conctacto(10, "Miguel Matos", "(809) 510-8844")

            };

            for (int i = 0; i < conctactos.Count; i++)
            {
                dataTable.Rows.Add(conctactos[i].ID, conctactos[i].Nombre, conctactos[i].Telefono);
            }

            dgContactos.DataSource = dataTable;
            this.dgContactos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgContactos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgContactos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dgContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;

            FilaSeleccionada = e.RowIndex;
            DataGridViewRow fila = dgContactos.Rows[FilaSeleccionada];

            FilaID = fila.Cells[0].Value.ToString();
            FilaNombre = fila.Cells[1].Value.ToString();
            FilaTelefono = fila.Cells[2].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarForm.Show();
            agregarForm.btnAgregar.Visible = true;
            if (agregarForm.tbNombre.Text != string.Empty || agregarForm.tbTelefono.Text != string.Empty)
            {
                agregarForm.tbNombre.Text = string.Empty;
                agregarForm.tbTelefono.Text = string.Empty;
            }
            agregarForm.tbNombre.Focus();
            agregarForm.tbID.Text = Convert.ToString(dgContactos.Rows.Count + 1);
            gbMenu.Enabled = false;
        }

       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            agregarForm.btnActualizar.Visible = true;
            agregarForm.tbID.Text = FilaID;
            agregarForm.tbNombre.Text = FilaNombre;
            agregarForm.tbTelefono.Text = FilaTelefono;
            agregarForm.Show();
            agregarForm.tbNombre.Focus();
            gbMenu.Enabled = false;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _Mensaje = "¿Seguro que desea salir?";
            _Titulo = "Cerrar Programa";

            _Resultado = MessageBox.Show(_Mensaje, _Titulo, _BotonesYesNo);
            if (_Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
