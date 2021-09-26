using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica230921
{
    public partial class Form1 : Form
    {
        private Timer ti;
        public Form1()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime Hoy = DateTime.Now;
            lblReloj.Text = Hoy.ToString("hh:mm:ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instancia de la clase Edificio
            //Edificio edificio = new Edificio();

            //edificio.direcion = "Av. Rosveelt, calle 7ma poniente";
            //edificio.cantDepartamentos = 45;
            //edificio.depRentados = 35;

            //mostramos
            //MessageBox.Show(edificio.direcion + edificio.cantDepartamentos + edificio.depRentados);

            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            Edificio edificio = new Edificio(tbNombreEdi.Text , tbDireccion.Text , tbCantidad.Text, tbRentados.Text);

            listBox1.Items.Add(edificio.getInformacion());
            tbNombreEdi.Text  = "";
            tbDireccion.Text  = "";
            tbCantidad.Text = "";
            tbRentados.Text = "";

            tbNombreEdi.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
