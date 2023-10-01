using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;                       
using System.Windows.Forms;

namespace ExamenT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel_uno.Visible = false;
            panel_dos.Visible = false;
            panel_contenedor.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel_contenedor.Controls[0].Visible = true;
            panel_contenedor.Controls[1].Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_contenedor.Controls[1].Visible = true;
            panel_contenedor.Controls[0].Visible = false;

        }
    }
}
