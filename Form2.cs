using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_atividade_final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Nome: FLavia Nascimento Ribeiro

        private void btncalcule_Click(object sender, EventArgs e)
        {
            //variaveis
            double peso, planeta;


            //entrada - convertendo a interaçao do usuario
            peso = double.Parse(txtpesoterra.Text);
            txtpesoterra.Text = peso.ToString();      
            

            //processo de if e else
            if (rdmerc.Checked)
            {
                planeta = peso * 0.37;
                MessageBox.Show("seu peso e: " + planeta);
            }

            else if (rdmarte.Checked)
            {
                planeta = peso * 0.88;
                MessageBox.Show("seu peso e: " + planeta);
            }

            else if (rdsat.Checked)
            {
                planeta = peso * 0.38;
                MessageBox.Show("seu peso e: " + planeta);
            }

            else if (rdvenus.Checked)
            {
                planeta = peso * 2.64;
                MessageBox.Show("seu peso e: " + planeta);
            }

            else if (rdjupiter.Checked)  
            {
                planeta = peso * 1.15;
                MessageBox.Show("seu peso e: " + planeta);
            }

            else if (rdurano.Checked)
            {
                planeta = peso * 1.17;
                MessageBox.Show("seu peso e: " + planeta);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
