using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web;

namespace PPAI20243K6.Clases
{
    internal class Vino
    {
        private int añada { get; set; }
        private DateTime fechaActualizacion { get; set; }
        private bool imagenEtiqueta { get; set; }
        private string nombre { get; set; }
        private int notaDeCataBodega { get; set; }
        private float precioARS { get; set; }
        private List<Reseña> Reseñas;

        private List<Varietal> Varietal;
        private Bodega Bodega;
        private double promedio;
        List<int> puntajes = new List<int>();



        public Vino(int añada, DateTime fechaActualizacion, bool imagenEtiqueta, string nombre, int notaCata, float precioARS, string coordUbicacionBodega, string descripBodega, string historiaBodega, string nombreBodega, int periodoActualizacionBodega,string nombreReg, string descripcionReg, string nomPais)
        {
           
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta= imagenEtiqueta;
            this.nombre= nombre;
            this.notaDeCataBodega = notaCata;
            this.precioARS = precioARS;
            Varietal= new List<Varietal>();
            Reseñas = new List<Reseña>();
            Bodega = new Bodega(coordUbicacionBodega, descripBodega, historiaBodega, nombreBodega, periodoActualizacionBodega, nombreReg, descripcionReg, nomPais);
           

        }
        public void setPromedio(double prom)
        {
            this.promedio = prom;
        }
        public double getPromedio()
        {
            return this.promedio;
        }
        public float getPrecio()
        {
            return this.precioARS;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string buscarVarietal()
        {
            List<string> listDesc = new List<string>();
            foreach (var i in Varietal)
            {
                listDesc.Add(i.getDescripcion());
            }
            string resultado = string.Join(", ", listDesc);
            return resultado;
        }
        public string buscarBodega()
        {
            string nom=this.Bodega.getNombre();
            string reg = this.Bodega.buscarRegionYPais();
            return nom+","+reg;
        }

        public void agregarVarietal(Varietal var)
        {
            Varietal.Add(var);
        }

        public void agregarReseña(Reseña res)
        {
            Reseñas.Add(res);
        }

        public void CalcularRanking()
        {
            // Implementación del método para calcular ranking
        }

        public void CompararEtiqueta()
        {
            // Implementación del método para comparar etiqueta
        }

        public bool EsDeBodega()
        {
            // Implementación del método para verificar si es de bodega
            return true;
        }

        public bool EsDeRegionVitivinicola()
        {
            // Implementación del método para verificar si es de región vitivinícola
            return false;
        }

        

        public bool buscarVinosConReseña(DateTime fechaDesde, DateTime fechaHasta, bool premium)
        {
            // Implementación del método para buscar vinos con reseña
            bool reseñaValida = false;
            for (int i = 0; i < this.Reseñas.Count; i++)
            {
                if (this.Reseñas[i].esFechaValida(fechaDesde, fechaHasta)&& this.Reseñas[i].sosDeSommelier(premium))
                {
                    reseñaValida = true;
                }
            }
            return reseñaValida;

        }
        public double calcularPromedioDeSommelierEnPeriodo(bool premium)
        {
            // Implementación del método para calcular puntaje promedio
            double promedio = calcularPuntajePromedio(premium);
            return Math.Round(promedio, 1);
        }
        public double calcularPuntajePromedio(bool premium)
        {
            // Implementación del método para calcular puntaje promedio
            List<int> puntajes = new List<int>();
            List<int> puntajesNoPremium = new List<int>();
            for (int i = 0; i < this.Reseñas.Count; i++)
            {
                if (Reseñas[i].EsPremium())//== premium)
                {
                    puntajes.Add(this.Reseñas[i].getPuntaje());
                }
                else
                {
                    puntajesNoPremium.Add(this.Reseñas[i].getPuntaje());
                }
                                                  
            }
            if (puntajes == null || puntajes.Count == 0)
            {
                //throw new ArgumentException("La lista no puede estar vacía o ser nula");
            }

            double suma = 0;
            double prom = 0;
            if (premium)
            {
                foreach (double numero in puntajes)
                {
                    suma += numero;
                }
                prom= suma / puntajes.Count;
            }
            else
            {
                foreach (double numero in puntajesNoPremium)
                {
                    suma += numero;
                }
                prom = suma / puntajesNoPremium.Count;
            }


            return prom;
        }
        public string getArrayPuntajes(bool premium)
        {
            // Implementación del método para obtener los puntajes de las reseñas
            List<int> puntajes = new List<int>();
            List<int> puntajesNoPremium = new List<int>();

            for (int i = 0; i < this.Reseñas.Count; i++)
            {
                if (this.Reseñas[i].EsPremium())
                {
                    puntajes.Add(this.Reseñas[i].getPuntaje());
                }
                else
                {
                    puntajesNoPremium.Add(this.Reseñas[i].getPuntaje());
                }
                
            }
            

            if (puntajes == null || puntajes.Count == 0)
            {
                //throw new ArgumentException("La lista no puede estar vacía o ser nula");
            }

            string resultado;

            if (premium)
            {
                resultado = string.Join(", ", puntajes);
            }
            else
            {
                resultado = string.Join(", ", puntajesNoPremium);
            }

            return resultado;

            
        }
    }
}
