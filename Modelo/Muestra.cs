using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Muestra
    {
      
        private String fecha;
        private int muestraNumero;
        private String puntoDeMuestreo;
        private String punto;
        private String rio;
        private String[] coordenadas;
        private double ica_ideam;
        private double od;
        private double ph;
        private double dqo;
        private double ce;
        private double stt;

        public Muestra(String fecha,int muestraNumero, string puntoDeMuestreo, string punto, string rio, String[] coordenadas, double ica_ideam, double od, double ph, double dqo, double ce, double stt)
        {
            this.Fecha = fecha;
            this.MuestraNumero = muestraNumero;
            this.PuntoDeMuestreo = puntoDeMuestreo;
            this.Punto = punto;
            this.Rio = rio;
            this.Coordenadas = coordenadas;
            this.Ica_ideam = ica_ideam;
            this.Od = od;
            this.Ph = ph;
            this.Dqo = dqo;
            this.Ce = ce;
            this.Stt = stt;
        }

        public String Fecha { get => fecha; set => fecha = value; }
        public string PuntoDeMuestreo { get => puntoDeMuestreo; set => puntoDeMuestreo = value; }
        public string Punto { get => punto; set => punto = value; }
        public string Rio { get => rio; set => rio = value; }
        public String[] Coordenadas { get => coordenadas; set => coordenadas = value; }
        public double Ica_ideam { get => ica_ideam; set => ica_ideam = value; }
        public double Od { get => od; set => od = value; }
        public double Ph { get => ph; set => ph = value; }
        public double Dqo { get => dqo; set => dqo = value; }
        public double Ce { get => ce; set => ce = value; }
        public double Stt { get => stt; set => stt = value; }
        public int MuestraNumero { get => muestraNumero; set => muestraNumero = value; }
    }
}
