using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        string operador = "";
        double numero1 = 0;
        double numero2 = 0;
        

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            numero1 = 0;
            numero2 = 0;
            operador = "";
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            //TextLength indica la longitud en este caso del texbox 
            if (textBox1.TextLength == 1)
            {
                textBox1.Text = "0";

            }
            else
            {
                //de esta manera borro un valor de la cadena
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") 
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonCero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            //covert: convierte lo que esta en texbox a un double
            numero1 = Convert.ToDouble(textBox1.Text);
            //y luego de que se use el operador me devuelva la pantalla a 0
            textBox1.Text = "0";

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "X";
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox1.Text);
            
            if(operador == "+")
            {
                textBox1.Text = $"{numero1 + numero2}";
            }
            else
            {
                if(operador == "-")
                {
                    textBox1.Text = $"{numero1 - numero2}";
                }
                else
                {
                    if(operador == "X")
                    {
                        textBox1.Text = $"{numero1 * numero2}";
                    }
                    else
                    {
                        if(operador == "/") {
                            textBox1.Text = $"{numero1 / numero2}";
                        }
                        else
                        {
                            if (operador == "%")
                            {
                                double porcentaje = 0;
                                porcentaje = Convert.ToDouble(textBox1.Text);
                                porcentaje = (numero2 * numero1) / 100;

                                textBox1.Text = $"{porcentaje}";
                            }
                        }
                    }
                }
            }
        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            operador = "x^2";
            numero1 = Convert.ToDouble(textBox1.Text);
            if (operador == "x^2")
            {


                textBox1.Text = $"{numero1 * numero1}";
            }
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            operador = "√";
            numero1 = Convert.ToDouble(textBox1.Text);
            if (operador == "√")
            {
                

                textBox1.Text = $"{Math.Sqrt(numero1) }";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operador = "%";
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonMasMeno_Click(object sender, EventArgs e)
        {
            operador = "±";
            numero1 = Convert.ToDouble(textBox1.Text);
            if(operador == "±")
            {
                if (numero1 > 0)
                {
                    textBox1.Text =  $"{-numero1}";
                }

                if (numero1 < 0)
                {
                    textBox1.Text = $"{numero1}";
                }
            }
        }
    }
}
