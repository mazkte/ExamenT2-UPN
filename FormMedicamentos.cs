using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace ExamenT2
{
    public partial class FormMedicamentos : Form
    {


        GestorMedicamento v_gestorMedicamento = new GestorMedicamento();

        public FormMedicamentos()
        {
            InitializeComponent();
            v_lbl_titulo.Text = "Bievenidos al Juego del miedo";
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

           
            

        }

        private void NuevoRegistro(object sender, EventArgs e)
        {
            

            

        }

        private void v_btn_registrar_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento
            {
                Codigo = v_txt_codigo.Text,
                Nombre = v_txtNombre.Text,
                Cantidad = int.Parse(v_txt_cantidad.Text),
                PrecioUnitario = double.Parse(v_txt_precio.Text)                
            };

            if( v_gestorMedicamento.Registrar(medicamento))
            {
                MessageBox.Show("Se registro correctamente el medicamento : " + v_txt_nombre.Text);
                LimpiarControles();
                return;
            }

        }

        private void LimpiarControles()
        {
            v_txt_codigo.Clear();
            v_txtNombre.Clear();
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
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void FocusLeave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void v_btn_menu_registrar_Click(object sender, EventArgs e)
        {
            v_lbl_titulo.Text = "Registrar medicamento";
        }

        private void v_btn_menu_buscar_Click(object sender, EventArgs e)
        {
            v_lbl_titulo.Text = "Buscar medicamento";
        }

        private void v_btn_menu_eliminar_Click(object sender, EventArgs e)
        {
            v_lbl_titulo.Text = "Eliminar medicamento";
        }

  
    }
}
