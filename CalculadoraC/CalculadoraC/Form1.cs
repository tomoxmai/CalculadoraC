using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraC
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void Btncero_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Btnmulti_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            operacion = "raiz";
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla.Text = Math.Sqrt(primero).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
