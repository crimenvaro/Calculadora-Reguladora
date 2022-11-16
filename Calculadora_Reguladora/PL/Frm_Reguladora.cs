using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL.Entidades;
using BLL.Logica;

namespace PL
{
    public partial class Frm_Reguladora : Form
    {
        public Frm_Reguladora()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            //Correo
            //Fecha
            //Cedula
            DAL_Calculadora objDAL = new DAL_Calculadora();

            objDAL.sVerificacion = txtVer.Text;

            if (cbVerificadora.SelectedItem.ToString().Trim() == "Correo")
            {
                if (Regex.IsMatch(objDAL.sVerificacion, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") == true)
                {
                    txtRes.Text = "El correo " + txtVer.Text + " es valido";
                }
                else
                {
                    txtRes.Text = "El correo " + txtVer.Text + " no es valido";
                }
            }

            if (cbVerificadora.SelectedItem.ToString().Trim() == "Fecha")
            {
                if (Regex.IsMatch(objDAL.sVerificacion, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|[2-9][0-9])\d\d$") == true)
                {
                    txtRes.Text = "La fecha " + txtVer.Text + " es valida";
                }
                else
                {
                    txtRes.Text = "La fecha " + txtVer.Text + " no es valida";
                }
            }

            if (cbVerificadora.SelectedItem.ToString().Trim() == "Cedula")
            {
                if (Regex.IsMatch(objDAL.sVerificacion, @"^[1-9]-?\d{4}-?\d{4}$") == true)
                {
                    txtRes.Text = "La cedula " + txtVer.Text + " es valida";
                }
                else
                {
                    txtRes.Text = "La cedula " + txtVer.Text + " no es valida";
                }
            }

            txtVer.Text = string.Empty;
        }
    }
}
