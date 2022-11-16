using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entidades;
using BLL.Logica;

namespace PL
{
    public partial class Frm_Calculadora : Form
    {
        public Frm_Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL_Calculadora objDAL = new DAL_Calculadora();
            BLL_Calculadora objBLL = new BLL_Calculadora();

            objDAL.sNumero1 = txtN1.Text.Trim();
            objDAL.sNumero2 = txtN2.Text.Trim();
            objDAL.sOperador = "+";

            objBLL.Verificar_Operación(ref objDAL);

            if (objDAL.sObservacion == "")
                objDAL.sObservacion = "Expresiones correctas";

            var index = this.dgvClientes.Rows.Add();
            this.dgvClientes.Rows[index].Cells[0].Value = objDAL.sNumero1;
            this.dgvClientes.Rows[index].Cells[1].Value = objDAL.sOperador;
            this.dgvClientes.Rows[index].Cells[2].Value = objDAL.sNumero2;
            this.dgvClientes.Rows[index].Cells[3].Value = objDAL.sObservacion;

            txtN1.Text = string.Empty;
            txtN2.Text = string.Empty;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            DAL_Calculadora objDAL = new DAL_Calculadora();
            BLL_Calculadora objBLL = new BLL_Calculadora();

            objDAL.sNumero1 = txtN1.Text.Trim();
            objDAL.sNumero2 = txtN2.Text.Trim();
            objDAL.sOperador = "-";

            objBLL.Verificar_Operación(ref objDAL);

            if (objDAL.sObservacion == "")
                objDAL.sObservacion = "Expresiones correctas";

            var index = this.dgvClientes.Rows.Add();
            this.dgvClientes.Rows[index].Cells[0].Value = objDAL.sNumero1;
            this.dgvClientes.Rows[index].Cells[1].Value = objDAL.sOperador;
            this.dgvClientes.Rows[index].Cells[2].Value = objDAL.sNumero2;
            this.dgvClientes.Rows[index].Cells[3].Value = objDAL.sObservacion;

            txtN1.Text = string.Empty;
            txtN2.Text = string.Empty;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            DAL_Calculadora objDAL = new DAL_Calculadora();
            BLL_Calculadora objBLL = new BLL_Calculadora();

            objDAL.sNumero1 = txtN1.Text.Trim();
            objDAL.sNumero2 = txtN2.Text.Trim();
            objDAL.sOperador = "*";

            objBLL.Verificar_Operación(ref objDAL);

            if (objDAL.sObservacion == "")
                objDAL.sObservacion = "Expresiones correctas";

            var index = this.dgvClientes.Rows.Add();
            this.dgvClientes.Rows[index].Cells[0].Value = objDAL.sNumero1;
            this.dgvClientes.Rows[index].Cells[1].Value = objDAL.sOperador;
            this.dgvClientes.Rows[index].Cells[2].Value = objDAL.sNumero2;
            this.dgvClientes.Rows[index].Cells[3].Value = objDAL.sObservacion;

            txtN1.Text = string.Empty;
            txtN2.Text = string.Empty;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            DAL_Calculadora objDAL = new DAL_Calculadora();
            BLL_Calculadora objBLL = new BLL_Calculadora();

            objDAL.sNumero1 = txtN1.Text.Trim();
            objDAL.sNumero2 = txtN2.Text.Trim();
            objDAL.sOperador = "/";

            objBLL.Verificar_Operación(ref objDAL);

            if (objDAL.sObservacion == "")
                objDAL.sObservacion = "Expresiones correctas";

            var index = this.dgvClientes.Rows.Add();
            this.dgvClientes.Rows[index].Cells[0].Value = objDAL.sNumero1;
            this.dgvClientes.Rows[index].Cells[1].Value = objDAL.sOperador;
            this.dgvClientes.Rows[index].Cells[2].Value = objDAL.sNumero2;
            this.dgvClientes.Rows[index].Cells[3].Value = objDAL.sObservacion;

            txtN1.Text = string.Empty;
            txtN2.Text = string.Empty;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtN1.Text = string.Empty;
            txtN2.Text = string.Empty;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
        }
    }
}
