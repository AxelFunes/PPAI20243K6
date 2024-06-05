using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI20243K6.Clases
{
    internal class GestorGenerarRankingVinos
    {
        public PantallaRankingVinos PantallaAsociada;
        public int reportesAGenerar { get; set; }
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        public bool fechasValidas;
        List<Vino> arrayVinos = new List<Vino>();
        List<Vino> vinosConReseña = new List<Vino>();

        private float precioVino;
        private string nombreVino;
        private string datosBodega;
        private string varietal;
        private double calificacionGral;


        public GestorGenerarRankingVinos(PantallaRankingVinos pantalla)
        {
            
            PantallaAsociada = pantalla;

        }
        public void generarRanking()
        {
            //cargar los objetos



            PantallaAsociada.solicitarFechasDesdeHasta();
            // Implementación del método para generar ranking
        }

        public void fechasConsideracionReseñas(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Implementación del método para considerar fechas de reseñas
            validarFechas(fechaDesde,fechaHasta);
        }

        public void validarFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Implementación del método para validar fechas
            if (fechaDesde<fechaHasta)
            {
                this.fechaDesde = fechaDesde;
                this.fechaHasta = fechaHasta;
                fechasValidas = true;
            }
            else
            {
                fechasValidas = false;
            }
        }

        public void buscarTiposReseña()
        {
            // Implementación del método para buscar tipos de reseña
        }

        public void tomarTipoReseña(string tipoReseña)
        {
            // Implementación del método para tomar tipo de reseña

            PantallaAsociada.pedirSeleccionFormasVisualizacion();

        }

        public string tomarTipoFormasVisualizacion(bool chkExcel, bool chkpdf, bool chkpantalla)
        {
            // Implementación del método para tomar tipo de formas de visualización
            string tipoVis = "";
            if (chkExcel)
            {
                tipoVis = "excel";
            }
            else
            {
                if (chkpdf)
                {
                    tipoVis = "pdf";
                }
                else
                {
                    if (chkpantalla)
                    {
                        tipoVis = "pantalla";
                    }

                }
            }
            return tipoVis;
        }

        public void tomarConfirmacion(string tipoReseña, string tipoVisualizacion)
        {
            // Implementación del método para tomar confirmación
            bool premium = false;
            if (tipoReseña=="Sommelier")
            {
                premium= true;
            }
            buscarVinosReseñasPeriodo(premium, tipoVisualizacion);
            /*
            if (tipoVisualizacion== "pantalla")
            {
                foreach (var item in vinosConReseña)
                {
                    DataGridViewRow fila = new DataGridViewRow();

                    DataGridViewTextBoxCell celdaId = new DataGridViewTextBoxCell();
                    celdaId.Value = item.;
                    fila.Cells.Add(celdaId);

                    DataGridViewTextBoxCell celdaCliente = new DataGridViewTextBoxCell();
                    celdaCliente.Value = datosLlamadaSeleccionada[0];
                    fila.Cells.Add(celdaCliente);

                    DataGridViewTextBoxCell celdaEstadoActual = new DataGridViewTextBoxCell();
                    celdaEstadoActual.Value = datosLlamadaSeleccionada[1];
                    fila.Cells.Add(celdaEstadoActual);

                    DataGridViewTextBoxCell celdaDuracion = new DataGridViewTextBoxCell();
                    celdaDuracion.Value = datosLlamadaSeleccionada[2];
                    fila.Cells.Add(celdaDuracion);

                    DataGridViewTextBoxCell celdaDescEnc = new DataGridViewTextBoxCell();
                    celdaDescEnc.Value = descEncuesta;
                    fila.Cells.Add(celdaDescEnc);
                }
            }
            */

        }

        public void buscarVinosReseñasPeriodo(bool premium, string tipoVis)
        {
            if (arrayVinos == null)
            {
                arrayVinos = new List<Vino>();
            }
            Vino vino1 = new Vino
                (2023,
                new DateTime(2023,07,13),
                true,
                "Norton",
                7,
                2850,
                "192.233.22" ,
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Norton," ,
                200, "Luján de Cuyo", "Descripcion region", "ARGENTINA");
            Vino vino2 = new Vino(2023,
                new DateTime(2023, 07, 13),
                true,
                "Trapiche",
                7,
                6050,
                "192.233.22",
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Bodega Trapiche,",
                200, "Maipú y Valle de Uco", "Descripcion region", "ARGENTINA");
            Vino vino3 = new Vino(2023,
                new DateTime(2023, 07, 13),
                true,
                "PORTILLO",
                7,
                7776,
                "192.233.22",
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Salentein,",
                200, "Valle de Uco", "Descripcion region", "ARGENTINA");
            Vino vino4 = new Vino(2023,
                new DateTime(2023, 07, 13),
                true,
                "Susana Balbo",
                7,
                16694,
                "192.233.22",
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Susana Balbo Wine,",
                200, "Luján de Cuyo y Valle de Uco", "Descripcion region", "ARGENTINA");
            Vino vino5 = new Vino(2023, new DateTime(2023, 07, 13), true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Santa Julia,", 200, "Maipú y Valle de Uco", "Descripcion region", "ARGENTINA");
            
            Vino vino6 = new Vino(2023, new DateTime(2023, 07, 13), true, "El Enemigo", 7, 28791, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "La Aleanna,", 200, "Gualtallary, Valle de Uco", "Descripcion region", "ARGENTINA");
            
            Vino vino7 = new Vino(2023, new DateTime(2023, 07, 13), true, "Luigi Bosca De Sangre", 7, 19579, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", " Finca El Paraíso - Bodega Luigi Bosca,", 200, "Maipú", "Descripcion region", "ARGENTINA");
            
            Vino vino8 = new Vino(2023, new DateTime(2023, 07, 13), true, "Quimerino Tinto", 7, 35000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Achaval Ferrer,", 200, "Luján de Cuyo y Valle de Uco", "Descripcion region", "ARGENTINA");
            
            Vino vino9 = new Vino(2023, new DateTime(2023, 07, 13), true, "Viña Cobos", 7, 34320, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Viña Cobos,", 200, "Luján de Cuyo y Valle de Uco", "Descripcion region", "ARGENTINA");
            
            Vino vino10 = new Vino(2023, new DateTime(2023, 07, 13), true, "Zuccardi", 7, 24901, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Zuccardi,", 200, "Valle de Uco", "Descripcion region", "ARGENTINA");
            
            Varietal var1 = new Varietal("Torrontés", 25); //v5

            Varietal var2 = new Varietal("Chañares Estate Malbec", 20); //viñacobosv9

            Varietal var3 = new Varietal("Felino Red Blend", 20); //viñacobos v9

            Varietal var4 = new Varietal("Bonarda", 15); //zuccardi v10

            Varietal var5 = new Varietal("Cabernet Sauvignon", 13);//zuccardi v10 // Susana Balbo v4 Salentein v3

            Varietal var6 = new Varietal("Malbec", 20); //Susana Balbo v4 Salentein v3 v2 v1

            Varietal var7 = new Varietal("Merlot", 20); //Salentein v3 v1

            Varietal var8 = new Varietal("Chardonnay", 20);//Salentein v3 v1

            Varietal var9 = new Varietal("Cabernet Franc", 20);

            Varietal var10 = new Varietal("Petit Verdot", 20);
            

            Reseña res1 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res2 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res3 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res4 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res5 = new Reseña("Comentario Reseñas", false, new DateTime(2023, 07, 13), 2);
            Reseña res6 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res7 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res8 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res9 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);
            Reseña res10 = new Reseña("Comentario Reseñas", true, new DateTime(2023, 07, 13), 9);

            vino1.agregarVarietal(var6);
            vino1.agregarVarietal(var7);
            vino1.agregarVarietal(var8);

            vino2.agregarVarietal(var6);

            vino3.agregarVarietal(var5);
            vino3.agregarVarietal(var6);
            vino3.agregarVarietal(var7);
            vino3.agregarVarietal(var8);

            vino4.agregarVarietal(var5);
            vino4.agregarVarietal(var6);

            vino5.agregarVarietal(var1);

            vino6.agregarVarietal(var9);

            vino7.agregarVarietal(var6);

            vino8.agregarVarietal(var6);
            vino8.agregarVarietal(var9);
            vino8.agregarVarietal(var7);
            vino8.agregarVarietal(var5);
            vino8.agregarVarietal(var10);

            vino9.agregarVarietal(var2);
            vino9.agregarVarietal(var3);

            vino10.agregarVarietal(var4);
            vino10.agregarVarietal(var5);

            vino1.agregarReseña(res1);
            vino1.agregarReseña(res5);
            vino2.agregarReseña(res2);
            vino3.agregarReseña(res3);
            vino4.agregarReseña(res4);
            vino5.agregarReseña(res5);
            vino6.agregarReseña(res6);
            vino6.agregarReseña(res7);
            vino7.agregarReseña(res9);
            vino8.agregarReseña(res10);
            vino9.agregarReseña(res4);
            vino10.agregarReseña(res5);

            //Agregamos los vinos al array

            arrayVinos.Add(vino1);
            arrayVinos.Add(vino2);
            arrayVinos.Add(vino3);
            arrayVinos.Add(vino4);
            arrayVinos.Add(vino5);
            arrayVinos.Add(vino6);
            arrayVinos.Add(vino7);
            arrayVinos.Add(vino8);
            arrayVinos.Add(vino9);
            arrayVinos.Add(vino10);

            //List<Vino> vinosConReseña = new List<Vino>();
           

            //vinosConReseña = Vino.buscarVinosConReseñaB(arrayVinos, fechaDesde, fechaHasta);------------------
            for (int i = 0; i < arrayVinos.Count; i++)
            {
                

                if (arrayVinos[i].buscarVinosConReseña(fechaDesde, fechaHasta, premium))
                {
                    vinosConReseña.Add(arrayVinos[i]);
                    
                }
          
            }
            calcularPromedioDeSommelierEnPeriodo(vinosConReseña);
            vinosConReseña=ordenarVinoPorPromedio(vinosConReseña);

            for (int i = 0; i < vinosConReseña.Count; i++)
            {
                precioVino= vinosConReseña[i].getPrecio();
                nombreVino= vinosConReseña[i].getNombre();
                datosBodega = vinosConReseña[i].buscarBodega();
                varietal = vinosConReseña[i].buscarVarietal();
                calificacionGral = vinosConReseña[i].getPromedio();

                if (tipoVis == "pantalla")
                {
                    
                    DataGridViewRow fila = new DataGridViewRow();
                    DataGridViewTextBoxCell nombre = new DataGridViewTextBoxCell();
                    nombre.Value = nombreVino;
                    fila.Cells.Add(nombre);

                    DataGridViewTextBoxCell precio = new DataGridViewTextBoxCell();
                    precio.Value = precioVino;
                    fila.Cells.Add(precio);


                    DataGridViewTextBoxCell bodega = new DataGridViewTextBoxCell();
                    bodega.Value = datosBodega;
                    fila.Cells.Add(bodega);

                    DataGridViewTextBoxCell datoVarietal = new DataGridViewTextBoxCell();
                    datoVarietal.Value = varietal;
                    fila.Cells.Add(datoVarietal);

                    PantallaAsociada.agregarFilaGrd(fila);

                }

            }
            
            //--------------
        }
        public List<Vino> ordenarVinoPorPromedio(List<Vino> vinos)
        {
            // Implementación del método para ordenar vino por promedio
            List<Vino> listaOrdenada = new List<Vino>();
            listaOrdenada = vinos.OrderByDescending(v => v.getPromedio()).ToList();

            return listaOrdenada;
        }
        public void calcularPromedioDeSommelierEnPeriodo(List<Vino> vinos)
        {
            for (int i = 0; i < vinos.Count; i++)
            {
                vinos[i].setPromedio(vinos[i].calcularPromedioDeSommelierEnPeriodo()); 
            }

        }

        public void FinCU()
        {
            // Implementación del método para finalizar el caso de uso
        }
    }
}
