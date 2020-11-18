using Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limitadorInput(object sender, KeyPressEventArgs tecla)
        {
            if ((!char.IsControl(tecla.KeyChar)) && (!char.IsDigit(tecla.KeyChar)) && (tecla.KeyChar != ','))
            {
                tecla.Handled = true;
            }
        }

        private void calcular_MouseClick(object sender, MouseEventArgs e)
        {
            if (!controlCamposCompletos(formaBox.SelectedIndex == 0 || formaBox.SelectedIndex == 3))
            {
                cambiarVisibilidades(faltanDatos);
                return;
            }

            float resultadoFinal;
            switch (formaBox.SelectedIndex)
            {
                case 0:
                    {
                        Rectangulo operacion = new Rectangulo();
                        if (operacionBox.SelectedIndex == 0)
                        {
                            resultadoFinal = operacion.rectanguloPerimetro(float.Parse(baseBox.Text), float.Parse(alturaBox.Text));
                        }
                        else
                        {
                            resultadoFinal = operacion.rectanguloArea(float.Parse(baseBox.Text), float.Parse(alturaBox.Text));
                        }
                        break;
                    }

                case 1:
                    {
                        Rectangulo operacion = new Rectangulo();
                        if (operacionBox.SelectedIndex == 0)
                        {
                            resultadoFinal = operacion.rectanguloPerimetro(float.Parse(baseBox.Text), float.Parse(baseBox.Text));
                        }
                        else
                        {
                            resultadoFinal = operacion.rectanguloArea(float.Parse(baseBox.Text), float.Parse(baseBox.Text));
                        }
                        break;
                    }

                case 2:
                    {
                        Circulo operacion = new Circulo();
                        if (operacionBox.SelectedIndex == 0)
                        {
                            resultadoFinal = operacion.circuloPerimetro(float.Parse(baseBox.Text));
                        }
                        else
                        {
                            resultadoFinal = operacion.circuloArea(float.Parse(baseBox.Text));
                        }
                        break;
                    }

                case 3:
                    {
                        Triangulo operacion = new Triangulo();
                        if (operacionBox.SelectedIndex == 0)
                        {
                            resultadoFinal = operacion.trianguloPerimetro(float.Parse(baseBox.Text), float.Parse(alturaBox.Text));
                        }
                        else
                        {
                            resultadoFinal = operacion.trianguloArea(float.Parse(baseBox.Text), float.Parse(alturaBox.Text));
                        }
                        break;
                    }

                default:
                    {
                        return;
                    }

            }

            resultado.Text = resultadoFinal.ToString();
            cambiarVisibilidades(resultado);
            operacionLabel.Text = operacionBox.Text;
        }

        private void cambiarVisibilidades(Label guia)
        {
            if (!guia.Visible)
            {
                resultado.Visible = (resultado.Visible == false);
                operacionLabel.Visible = (operacionLabel.Visible == false);
            }
                
            faltanDatos.Visible = (resultado.Visible == false);
        }

        private void formaBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (formaBox.SelectedIndex)
            {
                case 0:
                case 3:
                    {
                        baseLabel.Text = "Base";
                        alturaLabel.Text = "Altura";
                        alturaLabel.Visible = true;
                        alturaBox.Visible = true;
                        break;
                    }

                case 1:
                    {
                        baseLabel.Text = "Lado";
                        alturaLabel.Visible = false;
                        alturaBox.Visible = false;
                        break;
                    }

                case 2:
                    {
                        baseLabel.Text = "Radio";
                        alturaLabel.Visible = false;
                        alturaBox.Visible = false;
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

        }

        private bool controlCamposCompletos(bool dobleVariable)
        {
            bool baseBoxCompleto = !(string.IsNullOrWhiteSpace(baseBox.Text));
            bool alturaBoxCompleto = !(string.IsNullOrWhiteSpace(alturaBox.Text));
            bool formaBoxCompleto = formaBox.SelectedIndex != -1;
            bool operacionBoxCompleto = operacionBox.SelectedIndex != -1;

            if(dobleVariable)
            {
                if (baseBoxCompleto && alturaBoxCompleto && formaBoxCompleto && operacionBoxCompleto) 
                    return true;
            }
            else
            {
                if (baseBoxCompleto && formaBoxCompleto && operacionBoxCompleto)
                    return true;
            }
            
            return false;
        }
    }
}
