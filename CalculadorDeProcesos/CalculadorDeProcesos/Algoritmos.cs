using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeProcesos
{
    class Algoritmos
    {
        private int[] _procesos;
        private int _cMax;
        Random rnd = new Random();

        public Algoritmos(int totalDeProcesos, int tiempoTotal)
        {
            _procesos = new int[totalDeProcesos];
            _cMax = tiempoTotal;
        }

        public int llenarProcesos()
        {
            
            for (int i = 0; i < _procesos.Length; i++)
            {
                _procesos[i] += rnd.Next(1,_cMax);
            }
            return _procesos.Length;
        }

        public double promedioDeEspera()
        {
            double prom = 0.0;
            int sum = 0;
            for(int i = 0; i < _procesos.Length-1; i++)
            {
                sum += _procesos[i];
            }

            prom = sum/(double) _procesos.Length;
            return prom;
        }

        public double promedioDeFinalizacion()
        {
            double pf = 0.0;
            pf = _procesos.Sum() / (double)_procesos.Length;
            return pf;
        }

        public string mostrarProcesos()
        {
            string cosa = "";
            for (int i = 0; i < _procesos.Length; i++)
            {
                cosa += "[" + "Proceso-" + i + "]=" + _procesos[i].ToString() + Environment.NewLine;
            }

            return cosa;
        }

        public string mostrarPromedios()
        {
            string promedio = "";
            promedio += "Promedio de tET = " + promedioDeEspera().ToString() + Environment.NewLine 
                + "Promedio de tFT = " + promedioDeFinalizacion().ToString() + Environment.NewLine;
            return promedio;

        }

        

        


    }
}
