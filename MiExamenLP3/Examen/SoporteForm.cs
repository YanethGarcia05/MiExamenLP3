using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class SoporteForm : Form
    {
        public SoporteForm()
        {
            InitializeComponent();
        }

        string tipoOperacion = string.Empty;
        Soporte soporte;
        SoporteDatos userDatos = new SoporteDatos();

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            TipoSoporteComboBox.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            TipoSoporteComboBox.Enabled = false;
        }

        private void SoporteForm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Nuevo";
            HabilitarControles();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
            if (SoporteDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = SoporteDataGridView.CurrentRow.Cells["Id"].Value.ToString();
                TipoSoporteComboBox.Text = SoporteDataGridView.CurrentRow.Cells["TipoSoporte"].Value.ToString();

                HabilitarControles();
                CodigoTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void GuardarButton_Click(object sender, EventArgs e)
        {
            soporte = new Soporte();

            if (tipoOperacion == "Nuevo")
            {
                if (CodigoTextBox.Text == "")
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese un id");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TipoSoporteComboBox.Text))
                {
                    errorProvider1.SetError(TipoSoporteComboBox, "Ingrese un tipo de soporte");
                    TipoSoporteComboBox.Focus();
                    return;
                }

                soporte.Id = Convert.ToInt32(CodigoTextBox.Text);
                soporte.TipoSoporte = TipoSoporteComboBox.Text;

                bool inserto = await userDatos.InsertarAsync(soporte);

                if (inserto)
                {
                    LlenarDataGrid();
                    LimpiarControles();
                    DeshabilitarControles();
                    MessageBox.Show("Soporte guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el soporte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tipoOperacion == "Modificar")
            {
                if (CodigoTextBox.Text == "")
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese un id");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TipoSoporteComboBox.Text))
                {
                    errorProvider1.SetError(TipoSoporteComboBox, "Ingrese un tipo soporte");
                    TipoSoporteComboBox.Focus();
                    return;
                }

                soporte.Id = Convert.ToInt32(CodigoTextBox.Text);
                soporte.TipoSoporte = TipoSoporteComboBox.Text;

                bool modifico = await userDatos.ActualizarAsync(soporte);
                if (modifico)
                {
                    LlenarDataGrid();
                    LimpiarControles();
                    DeshabilitarControles();
                    MessageBox.Show("Soporte modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el soporte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void LlenarDataGrid()
        {
            SoporteDataGridView.DataSource = await userDatos.DevolverListaAsync();
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            TipoSoporteComboBox.Text = String.Empty;
        }

        private async void EliminarButton_Click(object sender, EventArgs e)
        {
            if (SoporteDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = await userDatos.EliminarAsync(SoporteDataGridView.CurrentRow.Cells["Id"].Value.ToString());
                if (elimino)
                {
                    LlenarDataGrid();
                    MessageBox.Show("Soporte eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el soporte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }
    }
}
