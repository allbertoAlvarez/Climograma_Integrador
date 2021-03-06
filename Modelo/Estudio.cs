﻿using System;
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
        public void inicializar_Datos()
        {

            //Llenar hashTable de arrays
            for (int i = 0; i <= 6; i++)
            {
                Hash_Muestras.Add(i, new ArrayList());
            }


            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\..\\Modelo\\Datos\\Datos.csv");

                line = "";
                string[] datos = null;
                while ((line = sr.ReadLine()) != null)
                {
                    datos = line.Split(',');


                    if (!datos[0].Equals("Fecha"))
                    {

                        String fecha = datos[FECHA];
                        int muestraNumero = Int32.Parse(datos[MUESTREO_No]);
                        String puntoDeMuestreo = datos[PUNTO_MUESTREO];
                        String punto = datos[PUNTO];
                        String rio = datos[RIO];
                        String[] coordenadas = datos[COORDENADAS].Split(';');
                        double latitud = Double.Parse(coordenadas[0].Replace('.',','));
                        double longitud = Double.Parse(coordenadas[1].Replace('.', ','));
                        double ica_ideam = Convert.ToDouble(datos[ICA_IDEAM].Replace('.', ','));
                        double od = Convert.ToDouble(datos[OD].Replace('.', ','));
                        double ph = Convert.ToDouble(datos[PH].Replace('.', ','));
                        double dqo = Convert.ToDouble(datos[DQO].Replace('.', ','));
                        double ce = Convert.ToDouble(datos[CE].Replace('.', ','));
                        double sst = Convert.ToDouble(datos[SST].Remove(datos[SST].Length - 1).Replace('.', ','));


                        Muestra muestra = new Muestra(fecha, muestraNumero, puntoDeMuestreo, punto, rio, latitud, longitud, ica_ideam, od, ph, dqo, ce, sst);

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

                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
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