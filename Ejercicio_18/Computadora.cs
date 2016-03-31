using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ejercicio_18Enumerados.Procesador;
using Ejercicio_18Enumerados.Marca;

namespace Ejercicio_18Computadora
{
    class Computadora
    { 
        private EMarca _marca;
        private EProcesador _procesador;
        private float _peso;
        private bool _estaEncendida;

        /// <summary>
        /// Genera una nueva computadora.
        /// </summary>
        /// <param name="marca">
        /// Marca de la computadora.
        /// </param>
        /// <param name="procesador">
        /// Procesador de la computadora.
        /// </param>
        /// <param name="peso">
        /// Peso de la computadora.
        /// </param>
        /// <param name="estaEncendida">
        /// Estado de la computadora.
        /// </param>
        public Computadora(EMarca marca, EProcesador procesador, float peso, bool estaEncendida)
        {
            this._marca = marca;
            this._procesador = procesador;
            this._peso = peso;
            this._estaEncendida = estaEncendida;
        }

        /// <summary>
        /// Retorna la marca de la computadora.
        /// </summary>
        public EMarca GetMarca()
        {
            return this._marca;
        }

        /// <summary>
        /// Asigna una nueva marca a la computadora.
        /// </summary>
        /// <param name="marca">
        /// Nueva marca. NOTA: La marca debe estar habilitada.
        /// </param>
        public void SetMarca(EMarca marca)
        {
            if ((int)marca <= 4 && (int)marca >= 0)
                this._marca = marca;
        }

        /// <summary>
        /// Retorna el procesador de la computadora.
        /// </summary>
        public EProcesador GetProcesador()
        {
            return this._procesador;
        }

        /// <summary>
        /// Asigna un nuevo procesador a la computadora.
        /// </summary>
        /// <param name="procesador">
        /// Nuevo procesador. NOTA: El procesador debe estar habilitado.
        /// </param>
        public void SetProcesador(EProcesador procesador)
        {
            if ((int)procesador <= 4 && (int)procesador >= 0)
                this._procesador = procesador;
        }

        /// <summary>
        /// Retorna el peso de la computadora.
        /// </summary>
        public float GetPeso()
        {
            return this._peso;
        }

        /// <summary>
        /// Asigna un nuevo peso a la computadora.
        /// </summary>
        /// <param name="peso">
        /// Nuevo peso. NOTA: Debe ser mayor a 0.
        /// </param>
        public void SetPeso(float peso)
        {
            if (peso > 0)
                this._peso = peso;
        }

        /// <summary>
        /// Indica si la computadora esta encendida o no.
        /// </summary>
        public bool GetEstaEncendida()
        {
            return this._estaEncendida;
        }

        /// <summary>
        /// Asigna el estado actual de la computadora.
        /// </summary>
        /// <param name="estaEncendida">
        /// Estado de la computadora.
        /// </param>
        public void SetEstaEncendida(bool estaEncendida)
        {
            this._estaEncendida = estaEncendida;
        }

        /// <summary>
        /// Muestra en consola la informacion actual de la computadora.
        /// </summary>
        public void InformarEstado()
        {
            Console.WriteLine("MARCA: {0}", this.GetMarca());
            Console.WriteLine("PROCESADOR: {0}", this.GetProcesador());
            Console.WriteLine("PESO: {0,0:#,###.00} Kg.", this.GetPeso());
            Console.WriteLine("ESTADO: {0}\n", this.GetEstaEncendida() ? "ENCENDIDA" : "APAGADA");
        }

        /// <summary>
        /// Enciende la computadora.
        /// </summary>
        public void Encender()
        {
            this.SetEstaEncendida(true);
        }

        /// <summary>
        /// Apaga la computadora.
        /// </summary>
        public void Apagar()
        {
            this.SetEstaEncendida(false);
        }
    }
}
