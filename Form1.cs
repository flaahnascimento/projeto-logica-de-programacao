using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvdd_Pratica_Logica_de_Programação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Nome: Maysa Soares dos Santos
        private void button1_Click(object sender, EventArgs e)
        {
            //variaveis
            int val01, val02, val03;
            

            //entrada - variavel recebendo o texto do usuario
            val01 = int.Parse(txtval01.Text);
            val02 = int.Parse(txtval02.Text);
            val03 = int.Parse(txtval03.Text);


            //saidas com if e else if

            //maior
            if(val01 >= val02 && val01>= val03)
            {
                txtmaior.Text = val01.ToString();
            }
            else if(val02 >= val03)
            {
                txtmaior.Text = val02.ToString();
            }
            else if (val03 >= val01)
            {
                txtmaior.Text = val03.ToString();
            }

            //menor
            if (val01 <= val02 && val01 <= val03)
            {
                txtmenor.Text = val01.ToString();
            }
            else if (val02 <= val03)
            {
                txtmenor.Text = val02.ToString();
            }
            else if (val03 <= val01)
            {
                txtmenor.Text = val03.ToString();
            }
        }
    }
}
