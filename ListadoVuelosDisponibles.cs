﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes_Prototipo_G5
{
    public partial class ListadoVuelosDisponibles : Form
    {
        public ListadoVuelosDisponibles()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiciosExtraVuelos formServicioExtraVuelos = new ServiciosExtraVuelos();
            formServicioExtraVuelos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerParadasVuelos formVerParadasVuelos = new VerParadasVuelos();
            formVerParadasVuelos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
