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
            formaPreviewBox_changer();
            baseBox.Visible = true;
            baseLabel.Visible = true;
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
                        baseLabel.Visible = false;
                        baseBox.Visible = false;
                        alturaLabel.Visible = false;
                        alturaBox.Visible = false;
                        break;
                    }
            }

        }

        private void formaPreviewBox_changer()
        {
            switch (formaBox.SelectedIndex)
            {
                case 0:
                    {
                        switch (operacionBox.SelectedIndex)
                        {
                            case 0:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.RectanguloPerimetro;
                                    break;
                                }
                            case 1:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.RectanguloArea;
                                    break;
                                }
                            default:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.Rectangulo;
                                    break;
                                }
                        }
                        break;
                    }

                case 1:
                    {
                        switch (operacionBox.SelectedIndex)
                        {
                            case 0:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.CuadradoPerimetro;
                                    break;
                                }
                            case 1:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.CuadradoArea;
                                    break;
                                }
                            default:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.Cuadrado;
                                    break;
                                }
                        }
                        break;
                    }

                case 2:
                    {
                        switch (operacionBox.SelectedIndex)
                        {
                            case 0:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.CirculoPerimetro;
                                    break;
                                }
                            case 1:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.CirculoArea;
                                    break;
                                }
                            default:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.Circulo;
                                    break;
                                }
                        }
                        break;
                    }

                case 3:
                    {
                        switch (operacionBox.SelectedIndex)
                        {
                            case 0:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.TrianguloPerimetro;
                                    break;
                                }
                            case 1:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.TrianguloArea;
                                    break;
                                }
                            default:
                                {
                                    formaPreviewBox.Image = Ejercitacion.Properties.Resources.Triangulo;
                                    break;
                                }
                        }
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

        private void operacionBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            formaPreviewBox_changer();
        }

        private void reset_MouseClick(object sender, MouseEventArgs e)
        {
            formaBox.SelectedItem = null;
            operacionBox.SelectedItem = null;
            baseLabel.Visible = false;
            alturaLabel.Visible = false;
            baseBox.Visible = false;
            alturaBox.Visible = false;
            baseBox.Text = "";
            alturaBox.Text = "";
            resultado.Text = "";
            operacionLabel.Text = "";
            formaPreviewBox.Image = Ejercitacion.Properties.Resources.Nada;
        }
    }
}
