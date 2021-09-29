using System;
using System.Windows.Forms;

namespace NuevoCCCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*----------------------------------------------------
         * ---------------------Variables---------------------
         -----------------------------------------------------*/
        double result;
        double conver;


        //no tiene funcion
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {              
            //condicionales
            if (cboList.Text != "" && txtValor.Text != "")
            {

            if (cboList.Text == "C->F")
            {
                result = (conver * 9 / 5) + 32;
                lblFinal.Text = Convert.ToString(result);
            }
            else if (cboList.Text == "F->C")
            {
                result = (conver - 32) * 5 / 9;
                lblFinal.Text = Convert.ToString(result);
            }
            else if (cboList.Text == "C->K")
            {
                result = (conver + 273.15);
                lblFinal.Text = Convert.ToString(result);
            }
            else if (cboList.Text == "F->K")
            {
                result = (conver + 459.67) * 5 / 9;
                lblFinal.Text = Convert.ToString(result);
            }
            else if (cboList.Text == "K->F")
            {
                result = (conver - 273.15) * 1.8000 + 32;
                lblFinal.Text = Convert.ToString(result);
            }

            }else
            {
                if (cboList.Text != "") MessageBox.Show("Error: EL campo numerico esta vacio");
                if (txtValor.Text != "") MessageBox.Show("Error: EL campo converisión esta vacio");

            }
            
        }
    }
}
