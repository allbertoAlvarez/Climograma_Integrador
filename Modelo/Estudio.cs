using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{


    public class Estudio
    {

        public static int FECHA = 0;
        public static int MUESTREO_No = 1;
        public static int PUNTO_MUESTREO = 2;
        public static int PUNTO = 3;
        public static int RIO = 4;
        public static int COORDENADAS = 5;
        public static int ICA_IDEAM = 6;
        public static int OD = 7;
        public static int PH = 8;
        public static int DQO = 9;
        public static int CE = 10;
        public static int SST = 11;

        public static String PANCE = "Pance";
        public static String AGUACATAL = "Aguacatal";
        public static String CALI = "Cali";
        public static String CAÑAVERALEJO = "Canaveralejo";
        public static String LILI = "Lili";
        public static String MELENDEZ = "Melendez";


        private Hashtable hash_Muestras;
        private String[] lineas;

        public Estudio()
        {
            Hash_Muestras = new Hashtable();
            inicializar_Datos();
        }

        //Este metodo se encargara de leer los datos e introducirlos en la tabla hash
        public void inicializar_Datos() {

            //Llenar hashTable de arrays
            for (int i = 0; i<=6; i++) {
                Hash_Muestras.Add(i, new ArrayList());
            }

            //Lee todas las lineas del archivo
            Lineas = File.ReadAllLines("..\\..\\..\\Modelo\\Datos\\Datos.csv");

            //
            foreach (var i in Lineas) {
                String[] linea = i.Split(',');


                if (!linea[0].Equals("Fecha"))
                {

                     String fecha = linea[FECHA];
                     int muestraNumero = Int32.Parse(linea[MUESTREO_No]);
                     String puntoDeMuestreo = linea[PUNTO_MUESTREO];
                     String punto = linea[PUNTO];
                     String rio = linea[RIO];
                     String[] coordenadas = linea[COORDENADAS].Split(';');
                     double latitud = Double.Parse(coordenadas[0]);
                     double longitud = Double.Parse(coordenadas[1]);
                     double ica_ideam = Double.Parse(linea[ICA_IDEAM]);
                     double od = Double.Parse(linea[OD]);
                     double ph = Double.Parse(linea[PH]);
                     double dqo = Double.Parse(linea[DQO]);
                     double ce = Double.Parse(linea[CE]);
                     double sst = Double.Parse(linea[SST].Remove(linea[SST].Length - 1));

                   



                    Muestra muestra = new Muestra(fecha,muestraNumero,puntoDeMuestreo,punto,rio, latitud, longitud,ica_ideam,od,ph,dqo,ce,sst);

                    if (muestra.Rio.Equals(AGUACATAL))
                    {
                        ((ArrayList)Hash_Muestras[1]).Add(muestra);
                    }

                    if (muestra.Rio.Equals(CALI))
                    {
                        ((ArrayList)Hash_Muestras[2]).Add(muestra);
                    }

                    if (muestra.Rio.Equals(CAÑAVERALEJO))
                    {
                        ((ArrayList)Hash_Muestras[3]).Add(muestra);
                    }

                    if (muestra.Rio.Equals(LILI))
                    {
                        ((ArrayList)Hash_Muestras[4]).Add(muestra);
                    }

                    if (muestra.Rio.Equals(MELENDEZ))
                    {
                        ((ArrayList)Hash_Muestras[5]).Add(muestra);
                    }

                    if (muestra.Rio.Equals(PANCE))
                    {
                        ((ArrayList)Hash_Muestras[6]).Add(muestra);
                    }
                }


            }
            
            
        }

        public Hashtable Hash_Muestras { get => hash_Muestras; set => hash_Muestras = value; }
        public string[] Lineas { get => lineas; set => lineas = value; }

        static void Main(string[] args)
        {
            Estudio e = new Estudio();
        }
    }
}
