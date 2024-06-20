using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehiculos.Logica;

namespace Vehiculos
{
    public partial class Form1 : Form
    {
        List<Automovil> listaAutomoviles = new List<Automovil>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Automovil a1=  new Automovil();
            a1.Marca = marca.Text;
            a1.Modelo = modelo.Text;
            a1.CantidadPuerta=  Convert.ToInt32(puertas.Text);
         
            a1.Año = Convert.ToInt32(año.Text);
            a1.TipoCombustible = tipoCombustible.Text;

            ListViewItem items = new ListViewItem();
            items.Text = a1.Marca;
            items.SubItems.Add(a1.Modelo);
            items.SubItems.Add(a1.CantidadPuerta.ToString());
            items.SubItems.Add(a1.Año.ToString());
            items.SubItems.Add(a1.TipoCombustible);

            listView1.Items.Add(items);

            listaAutomoviles.Add(a1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0; i<listaAutomoviles.Count; i++)
            {

                MessageBox.Show(listaAutomoviles[i].Mostrar(),"Vehículos",MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);


            }
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listaAutomoviles.Count; i++) {

                if (matricula.Text == listaAutomoviles[i].Matricula)
                {
                    modelo.Text = listaAutomoviles[i].Modelo;
                    marca.Text = listaAutomoviles[i].Marca;
                    año.Text = listaAutomoviles[i].Año.ToString();
                    puertas.Text = listaAutomoviles[i].CantidadPuerta.ToString();
                    tipoCombustible.Text = listaAutomoviles[i].TipoCombustible;
                }

            
            }




        }
    }
}
