using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class RegionVitivinicola
    {
        public string descripcionReg { get; set; }
        public string nombreReg { get; set; }

        private Provincia provincia { get; set; }

        public RegionVitivinicola(string descripcion, string nombre)
        {
           
            descripcionReg = descripcion;
            
            nombreReg = nombre;
           
            Pais pais= new Pais(nombre);
        }
        public int ContarBodegas()
        {
            // Implementación del método para contar bodegas
            return 0;
        }
        public void agregarProvincia( string nombre)
        {
            this.provincia = new Provincia(nombre);
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
            string pais= provincia.buscarPais();
            return pais;
        }
    }
}
