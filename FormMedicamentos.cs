using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laboratorio
{
    public partial class FormMedicamentos : Form
    {


        GestorMedicamento v_gestorMedicamento = new GestorMedicamento();

        public FormMedicamentos()
        {
            InitializeComponent();
            v_lbl_titulo.Text = "Gestor de medicamentos";
            this.v_panel_container.Controls[0].Visible = false;
            this.v_panel_container.Controls[1].Visible = false;
            this.v_panel_container.Controls[2].Visible = false;
        }

        private void CargarMedicamentos()
        {
            v_dg_medicamentos.DataSource = v_gestorMedicamento.Listar();
        }


        private void v_btn_registrar_Click(object sender, EventArgs e)
        {
            

            if (ValidarData())
            {

                Medicamento medicamento = new Medicamento
                {
                    Codigo = v_txt_codigo.Text,
                    Nombre = v_txt_nombre.Text,
                    Cantidad = int.Parse(v_txt_cantidad.Text),
                    PrecioUnitario = double.Parse(v_txt_precio.Text),

                };

                if (v_gestorMedicamento.Registrar(medicamento))
                {
                    MessageBox.Show("Se registro correctamente el medicamento : " + v_txt_nombre.Text);
                    LimpiarControles();
                    return;
                }

            }

            

        }

        private void LimpiarControles()
        {
            v_txt_codigo.Clear();
            v_txt_nombre.Clear();
            v_txt_cantidad.Clear();
            v_txt_precio.Clear();
            v_txt_codigo.Focus();
        }

        private void v_btn_menu_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void v_btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void FocusEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LightYellow;
        }

        private void PlaceHolderEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LightYellow;
            ((TextBox)sender).Text = string.Empty;
        }

        private void FocusLeave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void v_btn_menu_registrar_Click(object sender, EventArgs e)
        {
            v_lbl_titulo.Text = "Registrar medicamento";
            this.v_panel_container.Controls[0].Visible = true;
            this.v_panel_container.Controls[1].Visible = false;
            this.v_panel_container.Controls[2].Visible = false;

        }

        private void v_btn_menu_buscar_Click(object sender, EventArgs e)
        {
            v_lbl_titulo.Text = "Buscar medicamento";
            this.v_panel_container.Controls[0].Visible = false;
            this.v_panel_container.Controls[1].Visible = true;
            this.v_panel_container.Controls[2].Visible = false;

            CargarMedicamentos();
        }

        private void v_btn_menu_eliminar_Click(object sender, EventArgs e)
        {
            v_lbl_titulo.Text = "Eliminar medicamento";

            this.v_panel_container.Controls[0].Visible = false;
            this.v_panel_container.Controls[1].Visible = false;
            this.v_panel_container.Controls[2].Visible = true;
        }

        private void v_btn_buscar_Click(object sender, EventArgs e)
        {
            v_dg_medicamentos.DataSource = v_gestorMedicamento.BuscarPorNombre(v_txt_buscar.Text);
            v_dg_medicamentos.Refresh();

            v_txt_buscar.Clear();
        }

        private void v_btn_ordenar_Click(object sender, EventArgs e)
        {
            v_dg_medicamentos.DataSource = v_gestorMedicamento.OrdenarPorNombre();
            v_dg_medicamentos.Refresh();
        }

        private void v_btn_eliminar_Click(object sender, EventArgs e)
        {
            Medicamento v_medicamento = v_gestorMedicamento.BuscarPorCodigo(v_txt_eliminar.Text);

            if (string.IsNullOrEmpty(v_medicamento.Nombre))
            {
                MessageBox.Show($"El Medicamento buscado {v_txt_eliminar.Text} no existe.");
                return;
            }
            else
            {
               var result = ((int)MessageBox.Show($"Desea eliminar el siguiente medicamente {v_medicamento.Nombre}",
                    "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question));

                if(result == 1)
                {
                    v_gestorMedicamento.Eliminar(v_medicamento);
                    MessageBox.Show($"El Medicamento {v_medicamento.Nombre} ha sido eliminado correctamente.");

                }
                
            }
            v_txt_eliminar.Clear();

        }
    
        private bool ValidarData()
        {

            var v_contador_errores = 0;
            
            if (!int.TryParse(v_txt_cantidad.Text, out int x) || x <= 0)
            {
                errorProvider1.SetError(v_txt_cantidad, $"{v_txt_cantidad.Text} no es una cantidad valida");
                v_contador_errores++;
            }

            if (!double.TryParse(v_txt_precio.Text, out double y) || y <= 0)
            {
                errorProvider1.SetError(v_txt_precio, $"{v_txt_precio.Text} no es un precio valido");
                v_contador_errores++;
            }

            return (v_contador_errores == 0 );


        }
    
    }
}
