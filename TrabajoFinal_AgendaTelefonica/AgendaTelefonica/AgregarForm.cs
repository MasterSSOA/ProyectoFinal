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
        string _Mensaje;
        string _Titulo;
        MessageBoxButtons _BotonesYesNo = MessageBoxButtons.YesNo;
        DialogResult _Resultado;

        public AgregarForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PrincipalForm principalForm = (PrincipalForm)Application.OpenForms["PrincipalForm"];

            if (tbNombre.Text == string.Empty || tbTelefono.Text == string.Empty)
            {
                _Mensaje = "No se puede tener campos vacios.";
                _Titulo = "Aviso";
                MessageBox.Show(_Mensaje, _Titulo, MessageBoxButtons.OK);
                if (tbNombre.Text == string.Empty)
                    tbNombre.Focus();
                else
                    tbTelefono.Focus();
            }
            else
            {
                if (tbTelefono.Text.Length >= 10)
                {
                    Conctacto conctacto = new Conctacto(Convert.ToInt32(tbID.Text), tbNombre.Text, ConvertidorFormatoTel(tbTelefono.Text));
                    principalForm.dataTable.Rows.Add(conctacto.ID, conctacto.Nombre, conctacto.Telefono);

                    _Mensaje = "El contacto se ha agregado de forma exitosa.";
                    _Titulo = "Contacto";
                    MessageBox.Show(_Mensaje, _Titulo, MessageBoxButtons.OK);

                    _Mensaje = "¿Desea agregar otro contacto?";
                    _Titulo = "Contacto";

                    _Resultado = MessageBox.Show(_Mensaje, _Titulo, _BotonesYesNo);
                    if (_Resultado != DialogResult.Yes)
                    {
                        this.Hide();
                        principalForm.gbMenu.Enabled = true;
                    }
                    else
                        tbID.Text = Convert.ToString(Convert.ToInt32(tbID.Text) + 1);
                    tbNombre.Clear();
                    tbNombre.Focus();
                    tbTelefono.Clear();
                }
                else
                {
                    MessageBox.Show("Número Invalido. Debe colocar el teléfono completo.");
                    tbTelefono.Focus();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PrincipalForm principalForm = (PrincipalForm)Application.OpenForms["PrincipalForm"];

            _Mensaje = "¿Esta seguro que desea actualizar este registro?";
            _Titulo = "Actualización";

            _Resultado = MessageBox.Show(_Mensaje, _Titulo, _BotonesYesNo);
            if (_Resultado == DialogResult.Yes)
            {
                if (tbTelefono.Text.Length >= 10)
                {
                    DataGridViewRow RegistroActualizacion = principalForm.dgContactos.Rows[principalForm.FilaSeleccionada];
                    RegistroActualizacion.Cells[0].Value = tbID.Text;
                    RegistroActualizacion.Cells[1].Value = tbNombre.Text;
                    RegistroActualizacion.Cells[2].Value = ConvertidorFormatoTel(tbTelefono.Text);
                    principalForm.gbMenu.Enabled = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Número Invalido. Debe colocar el teléfono completo.");
                    tbTelefono.Focus();
                }
            }
            else
                tbNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrincipalForm principalForm = (PrincipalForm)Application.OpenForms["PrincipalForm"];

            _Mensaje = "¿Seguro que desea salir?";
            _Titulo = "Contacto";

            _Resultado = MessageBox.Show(_Mensaje, _Titulo, _BotonesYesNo);
            if (_Resultado == DialogResult.Yes)
            {
                this.Hide();
                principalForm.gbMenu.Enabled = true;
                tbNombre.Clear();
                tbNombre.Focus();
                tbTelefono.Clear();
                if (btnAgregar.Visible == true)
                    btnAgregar.Visible = false;
                else
                    btnActualizar.Visible = false;

            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Método sobre conversión de número telefónico.
        string ConvertidorFormatoTel(string NumeroTel)
        {
            string Area;
            string PrimeraParte;
            string SegundaParte;
            string Resto = "";
            string FullNumber;

            Area = NumeroTel.Substring(0, 3);
            PrimeraParte = NumeroTel.Substring(3, 3);
            SegundaParte = NumeroTel.Substring(6, 4);
            FullNumber = "(" + Area + ") " + PrimeraParte + "-" + SegundaParte + "";

            if (NumeroTel.Length > 10)
            {
                Resto = NumeroTel.Substring(10);
                FullNumber += "-" + Resto + "";
            }

            return FullNumber;
        }
    }
}
