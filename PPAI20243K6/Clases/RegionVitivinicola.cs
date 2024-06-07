using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class RegionVitivinicola
    {
        private string descripcionReg { get; set; }
        private string nombreReg { get; set; }

        private Provincia provincia { get; set; }
        private Pais pais { get; set; }

        public RegionVitivinicola(string descripcion, string nombre, string nombrePais)
        {
           
            descripcionReg = descripcion;
            
            nombreReg = nombre;
           
            pais = new Pais(nombrePais);
        }
        public int ContarBodegas()
        {
            // Implementación del método para contar bodegas
            return 0;
        }
        public void agregarProvincia( string nombreProv, string nomPais)
        {
            this.provincia = new Provincia(nombreProv, nomPais);
        }

        public string getNombre()
        {
            return nombreReg;
        }
        public string getDescripcion()
        {
            return descripcionReg;
        }
        public string buscarProvPais()
        {
            {
                if (provincia != null)
                {
                    return provincia.buscarPais();
                }
                else
                {
                    return pais.getNombre();
                }
            }
        }
    }
}
