using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Rectangulo
    {
        public float rectanguloArea(float _base, float altura)
        {
            return _base * altura;
        }

        public float rectanguloPerimetro(float _base, float altura)
        {
            return 2 * _base + 2 * altura;
        }
    }

    public class Circulo
    {
        public float circuloArea(float radio)
        {
            return (float)Math.PI * radio * radio;
        }

        public float circuloPerimetro(float radio)
        {
            return (float)Math.PI * radio * 2;
        }
    }
    public class Triangulo
    {
        public float trianguloArea(float _base, float altura)
        {
            return _base * altura / 2;
        }

        public float trianguloPerimetro(float _base, float altura)
        {
            return _base + altura * 2;
        }
    }
}
