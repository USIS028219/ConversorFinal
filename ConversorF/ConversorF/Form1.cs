using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorF
{
    public partial class Form1 : Form
    {
        ConversorClase objConversorF = new ConversorClase();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipo.Items.AddRange(objConversorF.Tipo);
            cboTipo.SelectedIndex = 0;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = "Valor: " + objConversorF.convertir(cboDe.SelectedIndex, cboA.SelectedIndex, double.Parse(txtCantidad.Text), cboTipo.SelectedIndex) + " " + objConversorF.etiquetas[cboTipo.SelectedIndex][cboA.SelectedIndex];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();
            cboDe.Items.AddRange(objConversorF.etiquetas[cboTipo.SelectedIndex]);
            cboA.Items.AddRange(objConversorF.etiquetas[cboTipo.SelectedIndex]);
            lbltipoConversor.Text = "Convertidor de " + objConversorF.Tipo[cboTipo.SelectedIndex];
            cboDe.SelectedIndex = 0;
            cboA.SelectedIndex = 1;
            lblRespuesta.Text = "?";
            txtCantidad.Text = "1";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboTipo.Items.AddRange(objConversorF.Tipo);
            cboTipo.SelectedIndex = 0;
        }
    }
}
