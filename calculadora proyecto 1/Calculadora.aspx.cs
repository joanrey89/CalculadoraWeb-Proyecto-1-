using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeBcalculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        // Métodos para dígitos
        protected void b1_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "1";
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "2";
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "3";
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "4";
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "5";
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "6";
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "7";
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "8";
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "9";
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "0";
        }

        // Operaciones binarias 
        protected void bsuma_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Session["Valor1"] = valor;
                Session["Operacion"] = "Suma";
                lresultado.Text = string.Empty;
            }
        }

        protected void bresta_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Session["Valor1"] = valor;
                Session["Operacion"] = "Resta";
                lresultado.Text = string.Empty;
            }
        }

        protected void bmulti_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Session["Valor1"] = valor;
                Session["Operacion"] = "Multiplicacion";
                lresultado.Text = string.Empty;
            }
        }

        protected void bdivi_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Session["Valor1"] = valor;
                Session["Operacion"] = "Division";
                lresultado.Text = string.Empty;
            }
        }

        // Operaciones unarias (se ejecutan inmediatamente)
        protected void bpotencia2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Exponente2 operacion = new Exponente2();
                float resultado = operacion.Calcular(valor);
                lresultado.Text = resultado.ToString();
            }
        }

        protected void bpotencia3_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Exponente3 operacion = new Exponente3();
                float resultado = operacion.Calcular(valor);
                lresultado.Text = resultado.ToString();
            }
        }

        protected void braiz_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                RaizCuadrada operacion = new RaizCuadrada();
                float resultado = operacion.Calcular(valor);
                lresultado.Text = resultado.ToString("0.##");
            }
        }

        protected void bfibonachi_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Fibonacci operacion = new Fibonacci();
                float resultado = operacion.Calcular(valor);
                lresultado.Text = resultado.ToString();
            }
        }

        protected void bfactorial_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                Factorial operacion = new Factorial();
                float resultado = operacion.Calcular(valor);
                lresultado.Text = resultado.ToString();
            }
        }

        // Botón de resultado
        protected void bresultado_Click(object sender, EventArgs e)
        {
            if (Session["Operacion"] != null && Session["Valor1"] != null &&
                float.TryParse(lresultado.Text, out float valor2))
            {
                float valor1 = (float)Session["Valor1"];
                string operacion = Session["Operacion"].ToString();
                float resultado = 0;

                switch (operacion)
                {
                    case "Suma":
                        resultado = new Suma().Calcular(valor1, valor2);
                        break;
                    case "Resta":
                        resultado = new Resta().Calcular(valor1, valor2);
                        break;
                    case "Multiplicacion":
                        resultado = new Multiplicacion().Calcular(valor1, valor2);
                        break;
                    case "Division":
                        resultado = new Division().Calcular(valor1, valor2);
                        break;
                }

                lresultado.Text = resultado.ToString();

                // Limpiar session
                Session["Operacion"] = null;
                Session["Valor1"] = null;
            }
        }

        // Botón de limpiar
        protected void bclear_Click(object sender, EventArgs e)
        {
            lresultado.Text = string.Empty;
            Session["Operacion"] = null;
            Session["Valor1"] = null;
        }
    }
}