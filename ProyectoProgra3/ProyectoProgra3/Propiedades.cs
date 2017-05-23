using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Propiedades
    {
        private string t_propiedad;
        private string codigo;
        private int m_cuadrados;
        private string nit;
        private List<string> porcentajes;

        public string T_propiedad
        {
            get
            {
                return t_propiedad;
            }

            set
            {
                t_propiedad = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Cuadrados
        {
            get
            {
                return Cuadrados1;
            }

            set
            {
                Cuadrados1 = value;
            }
        }

        public List<string> Porcentajes
        {
            get
            {
                return porcentajes;
            }

            set
            {
                porcentajes = value;
            }
        }

        public int Cuadrados1
        {
            get
            {
                return m_cuadrados;
            }

            set
            {
                m_cuadrados = value;
            }
        }
    }
}
