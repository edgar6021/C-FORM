using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introPOO1
{
    internal class AireAcondicionado
    {

        //Atributos
        private string marca;
        private string modelo;
        private string color;
        private int voltaje;
        private int btu;
        private int temperatura;
        //-----------------------------
        //Metodo Contructor

        public AireAcondicionado(string m, string mo, string co, int vol, int b, int tem)
        {
            marca = m;
            modelo = mo;
            color = co;
            voltaje = vol;
            btu = b;
            temperatura = tem;

        }
        //------------------------------
        //Metodos Set

        public void setMarca(string m)
        {
            marca = m;
        }
        public void setModelo(string mo)
        {
            modelo = mo;
        }
        public void setColor(string co)
        {
            color = co;
        }
        public void setVoltaje(int vol)
        {
            voltaje = vol;
        }
        public void setBtu(int b)
        {
            btu = b;
        }
        public void setTemperatura(int tem)
        {
            temperatura = tem;
        }

        //--------------------------------
        //Metodos Get

        public string getMarca()
        {
            return marca;
        }

        public string getModelo()
        {
            return modelo;
        }
        public string getColor()
        {
            return color;
        }
        public int getVoltaje()
        {
            return voltaje;
        }
        public int getBtu()
        {
            return btu;
        }
        public int getTemperatura()
        {
            return temperatura;
        }


        //Metodos

        public void subirTemperatura()
        {

            temperatura++;

        }

        public void bajarTemperatura()
        {

            temperatura--;

        }

        public int darTemperatura()
        {
            return temperatura;
        }



    }
}
