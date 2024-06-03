using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class GestorGenerarRankingVinos
    {
        public PantallaRankingVinos PantallaAsociada;
        public int reportesAGenerar { get; set; }
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        public bool fechasValidas;
        private List<Vino> arrayVinos;
       

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

        public void tomarConfirmacion()
        {
            // Implementación del método para tomar confirmación
            buscarVinosReseñasPeriodo();
        }

        public void buscarVinosReseñasPeriodo()
        {
            List<Vino> vinos = arrayVinos;
            Vino vino1 = new Vino
                (2023,
                DateTime.Now,
                true,
                "Santa Julia",
                7,
                5000,
                "192.233.22" ,
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Rincon del Sabor," ,
                200);
            Vino vino2 = new Vino(2023,
                DateTime.Now,
                true,
                "Santa Julia",
                7,
                5000,
                "192.233.22",
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Rincon del Sabor,",
                200);
            Vino vino3 = new Vino(2023,
                DateTime.Now,
                true,
                "Santa Julia",
                7,
                5000,
                "192.233.22",
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Rincon del Sabor,",
                200);
            Vino vino4 = new Vino(2023,
                DateTime.Now,
                true,
                "Santa Julia",
                7,
                5000,
                "192.233.22",
                "Ubicada en el corazón del encantador barrio de San Telmo," +
                " \"El Rincón del Sabor\" es una bodega que transporta a sus " +
                "visitantes a una época donde la tradición y la calidad eran la norma.",
                "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" +
                " a Argentina con sueños de traer consigo un pedazo de su tierra natal," +
                " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" +
                " barrio de San Telmo.",
                "Rincon del Sabor,",
                200);
            Vino vino5 = new Vino(2023, DateTime.Now, true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Rincon del Sabor,", 200);
            
            Vino vino6 = new Vino(2023, DateTime.Now, true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Rincon del Sabor,", 200);
            
            Vino vino7 = new Vino(2023, DateTime.Now, true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Rincon del Sabor,", 200);
            
            Vino vino8 = new Vino(2023, DateTime.Now, true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Rincon del Sabor,", 200);
            
            Vino vino9 = new Vino(2023, DateTime.Now, true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Rincon del Sabor,", 200);
            
            Vino vino10 = new Vino(2023, DateTime.Now, true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Rincon del Sabor,", 200);
            
            Varietal var1 = new Varietal("Descripcion Varietal", 20);

            Varietal var2 = new Varietal("Descripcion Varietal", 20);

            Varietal var3 = new Varietal("Descripcion Varietal", 20);

            Varietal var4 = new Varietal("Descripcion Varietal", 20);

            Varietal var5 = new Varietal("Descripcion Varietal", 20);

            Varietal var6 = new Varietal("Descripcion Varietal", 20);

            Varietal var7 = new Varietal("Descripcion Varietal", 20);

            Varietal var8 = new Varietal("Descripcion Varietal", 20);

            Varietal var9 = new Varietal("Descripcion Varietal", 20);

            Varietal var10 = new Varietal("Descripcion Varietal", 20);

            Reseña res1 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res2 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res3 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res4 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res5 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res6 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res7 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res8 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res9 = new Reseña("Comentario Reseñas", true, 13082023, 9);
            Reseña res10 = new Reseña("Comentario Reseñas", true, 13082023, 9);

            vino1.agregarVarietal(var1);
            vino2.agregarVarietal(var2);
            vino3.agregarVarietal(var3);
            vino4.agregarVarietal(var4);
            vino5.agregarVarietal(var5);
            vino6.agregarVarietal(var6);
            vino6.agregarVarietal(var7);
            vino7.agregarVarietal(var9);
            vino8.agregarVarietal(var10);
            vino9.agregarVarietal(var4);
            vino10.agregarVarietal(var5);

            vino1.agregarReseña(res1);
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

            
            for (int i = 0; i < arrayVinos.Count; i++)
            {
                arrayVinos[i].buscarVinosConReseña(fechaDesde, fechaHasta);
                
                arrayVinos.Add(arrayVinos[i]);
                    
                

            }


        }
        public void ordenarVinoPorPromedio()
        {
            // Implementación del método para ordenar vino por promedio
        }

        public void FinCU()
        {
            // Implementación del método para finalizar el caso de uso
        }
    }
}
