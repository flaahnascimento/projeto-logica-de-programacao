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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Nome: Maysa Soares dos Santos

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //variaveis
            int val01, val02, val03, val04, val05, val06, val07, val08, val09, val10, val11, val12;

            //entradas
            val01 = int.Parse(txt01.Text);
            val02 = int.Parse(txt02.Text);
            val03 = int.Parse(txt03.Text);
            val04 = int.Parse(txt04.Text);
            val05 = int.Parse(txt05.Text);
            val06 = int.Parse(txt06.Text);
            val07 = int.Parse(txt07.Text);
            val08 = int.Parse(txt08.Text);
            val09 = int.Parse(txt09.Text);
            val10 = int.Parse(txt10.Text);
            val11 = int.Parse(txt11.Text);
            val12 = int.Parse(txt12.Text);

            ///saida com if, else if
            //time1
            if (val01 > val02)
            {
                txtresul01.Text = ("Grêmio").ToString();
            }
            else if (val01 < val02)
            {
                txtresul01.Text = ("Juventude").ToString();
            }
            else if (val01 == val02)
            {
                txtresul01.Text = ("Empate").ToString();

            }

            //saida dos times 02


            if (val03 > val04)
            {
                txtresul02.Text = ("Palmeiras").ToString();
            }
            else if (val03 < val04)
            {
                txtresul02.Text = ("Internacional").ToString();
            }
            else if (val03 == val04)
            {
                txtresul02.Text = ("Empate").ToString();
            }

            //saida dos times 03


            if (val05 > val06)
            {
                txtresul03.Text = ("Santos").ToString();
            }
            else if (val05 < val06)
            {
                txtresul03.Text = ("Botafogo").ToString();
            }
            else if (val05 == val06)
            {
                txtresul03.Text = ("Empate").ToString();
            }

            //saida dos times 04


            if (val07 > val08)
            {
                txtresul04.Text = ("Corinthians").ToString();
            }
            else if (val07 < val08)
            {
                txtresul04.Text = ("Sâo Paulo").ToString();
            }
            else if (val07 == val08)
            {
                txtresul04.Text = ("Empate").ToString();
            }

            //saida dos times 05


            if (val09 > val10)
            {
                txtresul05.Text = ("Ponte Preta").ToString();
            }
            else if (val09 < val10)
            {
                txtresul05.Text = ("Vasco").ToString();
            }
            else if (val09 == val10)
            {
                txtresul05.Text = ("Empate").ToString();
            }

            //saida dos times 06


            if (val11 > val12)
            {
                txtresul06.Text = ("Flamengo").ToString();
            }
            else if (val11 < val12)
            {
                txtresul06.Text = ("Cruzeiro").ToString();
            }
            else if (val11 == val12)
            {
                txtresul06.Text = ("Empate").ToString();
            }
        }
    }
} 
