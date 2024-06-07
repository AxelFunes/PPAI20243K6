using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI20243K6.Clases
{
    internal class GestorGenerarRankingVinos
    {
        public PantallaRankingVinos PantallaAsociada;
        private int reportesAGenerar { get; set; }
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        public bool fechasValidas;
        List<Vino> arrayVinos = new List<Vino>();
        List<Vino> vinosConReseña = new List<Vino>();
        string arrPuntajes;

        private double promedioVino;
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
            //----
            vinosConReseña.Clear();
          
            //----
            bool premium = false;
            if (tipoReseña=="Sommelier")
            {
                premium= true;
            }
            buscarVinosReseñasPeriodo(premium, tipoVisualizacion);
            

        }

        public void buscarVinosReseñasPeriodo(bool premium, string tipoVis)
        {
            if (arrayVinos.Count == 0)
            {
                arrayVinos = new List<Vino>();
            //}
            //En esta parte del codigo lo que hacemos es instanciar la clase Vino con los diferentes vinos con sus atributos
            Vino vino1 = new Vino(2023, new DateTime(2023, 07, 13), true, "Norton", 7, 2850, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo, \"El Rincón del Sabor\" es una bodega que transporta a sus visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó a Argentina con sueños de traer consigo un pedazo de su tierra natal, la bodega ha sido un testigo silencioso del crecimiento y la evolución del barrio de San Telmo.", "Norton,", 200, "Luján de Cuyo", "Descripcion region", "ARGENTINA");

            Vino vino2 = new Vino(2023, new DateTime(2023, 07, 13), true, "Trapiche", 7, 6050, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo, \"El Rincón del Sabor\" es una bodega que transporta a sus visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó a Argentina con sueños de traer consigo un pedazo de su tierra natal, la bodega ha sido un testigo silencioso del crecimiento y la evolución del barrio de San Telmo.", "Bodega Trapiche,", 200, "Maipú y Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino3 = new Vino(2023, new DateTime(2023, 07, 13), true, "PORTILLO", 7, 7776, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo, \"El Rincón del Sabor\" es una bodega que transporta a sus visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó a Argentina con sueños de traer consigo un pedazo de su tierra natal, la bodega ha sido un testigo silencioso del crecimiento y la evolución del barrio de San Telmo.", "Salentein,", 200, "Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino4 = new Vino(2023, new DateTime(2023, 07, 13), true, "Susana Balbo", 7, 16694, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo, \"El Rincón del Sabor\" es una bodega que transporta a sus visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó a Argentina con sueños de traer consigo un pedazo de su tierra natal, la bodega ha sido un testigo silencioso del crecimiento y la evolución del barrio de San Telmo.", "Susana Balbo Wine,", 200, "Luján de Cuyo y Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino5 = new Vino(2023, new DateTime(2023, 07, 13), true, "Santa Julia", 7, 5000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Santa Julia,", 200, "Maipú y Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino6 = new Vino(2023, new DateTime(2023, 07, 13), true, "El Enemigo", 7, 28791, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "La Aleanna,", 200, "Gualtallary, Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino7 = new Vino(2023, new DateTime(2023, 07, 13), true, "Luigi Bosca De Sangre", 7, 19579, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", " Finca El Paraíso - Bodega Luigi Bosca,", 200, "Maipú", "Descripcion region", "ARGENTINA");

            Vino vino8 = new Vino(2023, new DateTime(2023, 07, 13), true, "Quimerino Tinto", 7, 35000, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Achaval Ferrer,", 200, "Luján de Cuyo y Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino9 = new Vino(2023, new DateTime(2023, 07, 13), true, "Viña Cobos", 7, 34320, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Viña Cobos,", 200, "Luján de Cuyo y Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino10 = new Vino(2023, new DateTime(2023, 07, 13), true, "Zuccardi", 7, 24901, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Zuccardi,", 200, "Valle de Uco", "Descripcion region", "ARGENTINA");

            Vino vino11 = new Vino(2023, new DateTime(2023, 07, 13), true, "Vino Toro", 7, 2000, "192.233.22", "Ubicada en el corazón de Argentina del buen sabor," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un ARGENTINO PURO que llegó" + " con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Vino Toro,", 200, "Sabra dios", "Descripcion region", "ARGENTINA");

            Vino vino12 = new Vino(2023, new DateTime(2023, 07, 13), true, "Zumua", 7, 800, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Zumua,", 200, "El lugar mas recondito", "Descripcion region", "ARGENTINA");
            
            Vino vino13 = new Vino(2023, new DateTime(2023, 07, 13), true, "Termidor", 7, 1500, "192.233.22", "Ubicada en el corazón del encantador barrio de San Telmo," + " \"El Rincón del Sabor\" es una bodega que transporta a sus " + "visitantes a una época donde la tradición y la calidad eran la norma.", "Fundada en 1952 por Don Manuel Rivera, un inmigrante español que llegó" + " a Argentina con sueños de traer consigo un pedazo de su tierra natal," + " la bodega ha sido un testigo silencioso del crecimiento y la evolución del" + " barrio de San Telmo.", "Termidor,", 200, "De donde vino terminator", "Descripcion region", "ARGENTINA");

            //Instanciamos la clase Varietal y creamos los distintos varietales
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

            //Instanciamos la clase reseña e indicamos sus valores
            Reseña res1 = new Reseña("¡Excelente vino! Rico aroma y sabor a frutas.", true, new DateTime(2024, 01, 05), 9);
            Reseña res2 = new Reseña("Un vino suave y elegante, perfecto para una cena romántica.", true, new DateTime(2024, 01, 10), 8);
            Reseña res3 = new Reseña("Impresionante calidad. Sin duda, lo compraré de nuevo.", true, new DateTime(2024, 01, 15), 10);
            Reseña res4 = new Reseña("Sabor equilibrado, me dejó una sensación muy agradable.", true, new DateTime(2024, 01, 20), 9);
            Reseña res5 = new Reseña("¡Un vino excepcional! Mi nuevo favorito sin duda alguna.", true, new DateTime(2024, 01, 25), 10);
            Reseña res6 = new Reseña("Me sorprendió gratamente este vino, superó mis expectativas.", true, new DateTime(2024, 02, 01), 9);
            Reseña res7 = new Reseña("Buena relación calidad-precio. Lo recomendaría a amigos.", true, new DateTime(2024, 02, 05), 7);
            Reseña res8 = new Reseña("Un vino muy versátil, perfecto para cualquier ocasión.", true, new DateTime(2024, 02, 10), 8);
            Reseña res9 = new Reseña("Excelente servicio al cliente y un vino de alta calidad.", true, new DateTime(2024, 02, 15), 9);
            Reseña res10 = new Reseña("Este vino es una joya oculta, ¡definitivamente lo recomiendo!", true, new DateTime(2024, 02, 20), 9);
            Reseña res11 = new Reseña("Gran vino, excelente relación calidad-precio.", true, new DateTime(2024, 01, 05), 8);
            Reseña res12 = new Reseña("Un vino excepcional, definitivamente volvería a comprarlo.", true, new DateTime(2024, 01, 10), 9);
            Reseña res13 = new Reseña("Buen vino, pero un poco caro para mi gusto.", true, new DateTime(2024, 01, 15), 7);
            Reseña res14 = new Reseña("¡Increíble! Este vino superó todas mis expectativas.", true, new DateTime(2024, 01, 20), 10);
            Reseña res15 = new Reseña("No me gustó mucho, esperaba más por el precio.", true, new DateTime(2024, 01, 25), 5);
            Reseña res16 = new Reseña("Una experiencia decepcionante, no recomendaría este vino.", true, new DateTime(2024, 02, 05), 3);
            Reseña res17 = new Reseña("Para ser sincero, este vino no valió la pena.", true, new DateTime(2024, 02, 10), 4);
            Reseña res18 = new Reseña("Un vino decente, pero hay opciones mejores por ahí.", true, new DateTime(2024, 02, 15), 6);
            Reseña res19 = new Reseña("¡Fantástico! Definitivamente uno de mis vinos favoritos.", true, new DateTime(2024, 02, 20), 9);
            Reseña res20 = new Reseña("No me impresionó mucho, esperaba más sabor.", true, new DateTime(2024, 02, 25), 6);
            Reseña res21 = new Reseña("Buen vino para ocasiones especiales, lo recomendaría.", false, new DateTime(2024, 03, 05), 7); //NO PREMIUM
            Reseña res22 = new Reseña("No soy un gran fan de este vino, prefiero otros.", false, new DateTime(2024, 03, 10), 4);//NO PREMIUM
            Reseña res23 = new Reseña("Buena relación calidad-precio, pero no es excepcional.", false, new DateTime(2024, 03, 15), 6);//NO PREMIUM
            Reseña res24 = new Reseña("Para mí, este vino fue una decepción total.", false, new DateTime(2024, 03, 20), 2);//NO PREMIUM
            Reseña res25 = new Reseña("Excelente vino, definitivamente compraría de nuevo.", false, new DateTime(2024, 03, 25), 9);//NO PREMIUM
            Reseña res26 = new Reseña("Malardo, hasta con rexona te abandona.", true, new DateTime(2024, 03, 25), 1);// PREMIUM
            Reseña res27 = new Reseña("Fiel, el que te salva las papas.", true, new DateTime(2024, 03, 25), 9);// PREMIUM


                //Se le agrega a cada vino su varietal correspondiente
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

            vino11.agregarVarietal(var6);

            vino12.agregarVarietal(var6);
            vino12.agregarVarietal(var1);
            
            vino13.agregarVarietal(var6);

                //Se agregan reseñas
            vino1.agregarReseña(res1);
            vino1.agregarReseña(res3);
            vino1.agregarReseña(res5);
            vino1.agregarReseña(res7);

            vino2.agregarReseña(res2);
            vino2.agregarReseña(res4);
            vino2.agregarReseña(res6);

            vino3.agregarReseña(res8);
            vino3.agregarReseña(res10);

            vino4.agregarReseña(res9);
            vino4.agregarReseña(res11);
            vino4.agregarReseña(res13);

            vino5.agregarReseña(res12);
            vino5.agregarReseña(res14);

            vino6.agregarReseña(res15);
            vino6.agregarReseña(res17);
            vino6.agregarReseña(res19);

            vino7.agregarReseña(res16);
            vino7.agregarReseña(res18);
            vino7.agregarReseña(res20);

            vino8.agregarReseña(res21);//NO PREMIUM
            vino8.agregarReseña(res23);//NO PREMIUM

            vino9.agregarReseña(res22);//NO PREMIUM
            vino9.agregarReseña(res24);//NO PREMIUM
            vino9.agregarReseña(res25);//NO PREMIUM
            vino9.agregarReseña(res20);

            vino10.agregarReseña(res25);//NO PREMIUM

            vino11.agregarReseña(res27);

            vino12.agregarReseña(res26);
            vino12.agregarReseña(res15);

            vino13.agregarReseña(res27);

            //OSEA QUE POR PANTALLA ESTA MOSTRANDO 7 VINOS, YA QUE HAY 3 QUE TIENEN RESEÑAS NO PREMIUM!!

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
            arrayVinos.Add(vino11);
            arrayVinos.Add(vino12);
            arrayVinos.Add(vino13);

            }
            //Recorremos el array de vinos, para poder obtener los vinos con reseña utilizamos el metoo buscarVinosConReseña
            //En caso que tengan una reseña con las fechas indicadas y sea premium, se crea un array nuevo de vinos con reseña
            for (int i = 0; i < arrayVinos.Count; i++)
            {
                

                if (arrayVinos[i].buscarVinosConReseña(fechaDesde, fechaHasta, premium))
                {
                    vinosConReseña.Add(arrayVinos[i]);
                    
                }
          
            }
            //Para los vinos llamamos los metodos para calcular el promedio de puntaje en el periodo y tambien los ordenamos por promedio
            calcularPromedioDeSommelierEnPeriodo(vinosConReseña, premium);
            vinosConReseña=ordenarVinoPorPromedio(vinosConReseña);

            //Se recorre el array de vinos con reseña, se obtienen los datos para poder luego mostrarlos por pantalla
            int j = 0;
            while (j < vinosConReseña.Count && j < 10)
            {
                promedioVino = vinosConReseña[j].getPromedio();
                precioVino = vinosConReseña[j].getPrecio();
                nombreVino= vinosConReseña[j].getNombre();
                datosBodega = vinosConReseña[j].buscarBodega();
                varietal = vinosConReseña[j].buscarVarietal();
                calificacionGral = vinosConReseña[j].getPromedio();
                arrPuntajes = vinosConReseña[j].getArrayPuntajes(premium);

                if (tipoVis == "pantalla")
                {
                    
                    DataGridViewRow fila = new DataGridViewRow();
                    DataGridViewTextBoxCell prom = new DataGridViewTextBoxCell();
                    prom.Value = promedioVino;
                    fila.Cells.Add(prom);

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

                    DataGridViewTextBoxCell puntajes = new DataGridViewTextBoxCell();
                    puntajes.Value = arrPuntajes;
                    fila.Cells.Add(puntajes);

                    PantallaAsociada.agregarFilaGrd(fila);
                }
                
                j++;
            }
            if (tipoVis == "excel")
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Ranking de Vinos");
                    worksheet.Cell(1, 1).Value = "Promedio";
                    worksheet.Cell(1, 2).Value = "Nombre Vino";
                    worksheet.Cell(1, 3).Value = "Precio";
                    worksheet.Cell(1, 4).Value = "Bodega";
                    worksheet.Cell(1, 5).Value = "Varietal";
                    worksheet.Cell(1, 6).Value = "Puntajes";

                    int currentRow = 2;

                    for (int i = 0; i < vinosConReseña.Count && i < 10; i++)
                    {
                        promedioVino = vinosConReseña[i].getPromedio();
                        precioVino = vinosConReseña[i].getPrecio();
                        nombreVino = vinosConReseña[i].getNombre();
                        datosBodega = vinosConReseña[i].buscarBodega();
                        varietal = vinosConReseña[i].buscarVarietal();
                        arrPuntajes = vinosConReseña[i].getArrayPuntajes(premium);

                        worksheet.Cell(currentRow, 1).Value = promedioVino;
                        worksheet.Cell(currentRow, 2).Value = nombreVino;
                        worksheet.Cell(currentRow, 3).Value = precioVino;
                        worksheet.Cell(currentRow, 4).Value = datosBodega;
                        worksheet.Cell(currentRow, 5).Value = varietal;
                        worksheet.Cell(currentRow, 6).Value = arrPuntajes;

                        currentRow++;
                    }

                    // Guardar el archivo Excel
                    string filePath = "C:/DSI/RankingDeVinos.xlsx";
                    workbook.SaveAs(filePath);

                    // Informar al usuario de que el archivo se ha guardado
                    MessageBox.Show($"El archivo Excel ha sido guardado en {filePath}", "Archivo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                FinCU();
            }

            //--------------
        }
        //Metodo para ordenar el aray de vinos por puntaje promedio
        public List<Vino> ordenarVinoPorPromedio(List<Vino> vinos)
        {
            // Implementación del método para ordenar vino por promedio
            List<Vino> listaOrdenada = new List<Vino>();
            listaOrdenada = vinos.OrderByDescending(v => v.getPromedio()).ToList();

            return listaOrdenada;
        }

        //Metodo para calcular el promedio de puntaje de los vinos
        public void calcularPromedioDeSommelierEnPeriodo(List<Vino> vinos, bool premium)
        {
            for (int i = 0; i < vinos.Count; i++)
            {
                vinos[i].setPromedio(vinos[i].calcularPromedioDeSommelierEnPeriodo(premium)); 
            }

        }



        public void FinCU()
        {
            // Implementación del método para finalizar el caso de uso
            //PantallaAsociada.Close();

        }
    }
}
