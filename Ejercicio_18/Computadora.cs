using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ejercicio_18.Enumerados.Procesador;
using Ejercicio_18.Enumerados.Marca;

namespace Ejercicio_18.Computadora
{
    class Computadora
    { 
        private EMarca _marca;
        private EProcesador _procesador;
        private float _peso;
        private bool _estaEncendida;

        public Computadora(EMarca marca, EProcesador procesador, float peso, bool estaEncendida)
        {
            this._marca = marca;
            this._procesador = procesador;
            this._peso = peso;
            this._estaEncendida = estaEncendida;
        }

        public EMarca GetMarca()
        {
            return this._marca;
        }

        public void SetMarca(EMarca marca)
        {
            if ((int)marca <= 4 && (int)marca >= 0)
                this._marca = marca;
        }

        public EProcesador GetProcesador()
        {
            return this._procesador;
        }

        public void SetProcesador(EProcesador procesador)
        {
            if ((int)procesador <= 4 && (int)procesador >= 0)
                this._procesador = procesador;
        }

        public float GetPeso()
        {
            return this._peso;
        }

        public void SetPeso(float peso)
        {
            if (peso > 0)
                this._peso = peso;
        }

        public bool GetEstaEncendida()
        {
            return this._estaEncendida;
        }

        public void SetEstaEncendida(bool estaEncendida)
        {
            this._estaEncendida = estaEncendida;
        }

        public void InformarEstado()
        {
            Console.WriteLine("MARCA: {0}", this.GetMarca());
            Console.WriteLine("PROCESADOR: {0}", this.GetProcesador());
            Console.WriteLine("PESO: {0,0:#,###.00} Kg.", this.GetPeso());
            Console.WriteLine("ESTADO: {0}\n", this.GetEstaEncendida() ? "ENCENDIDA" : "APAGADA");
        }

        public void Encender()
        {
            this.SetEstaEncendida(true);
        }

        public void Apagar()
        {
            this.SetEstaEncendida(false);
        }
    }
}
