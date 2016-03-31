using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_18Computadora;
using Ejercicio_18Enumerados.Marca;
using Ejercicio_18Enumerados.Procesador;

namespace Ejercicio_18.Program
{

    /*
    18.  Realizar una aplicación parecida a la del punto anterior pero con 
    la clase Computadora y los enumerados EMarca y EProcesador.
    Agregar un constructor que reciba como parámetros todos sus 
    atributos y los métodos:
    1- InformarEstado: informa el estado actual de la computadora 
    (marca, procesador, si está encendida o no, etc.).
    2- Encender.
    3- Apagar 
    Nota: Las clases, los enumerados y el Program deben estar en 
    namespaces distintos.
    */

    class Ejercicio_18
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 18";

            Computadora miComputadora = new Computadora(EMarca.Samsung, EProcesador.Intel_Core_i7, (float)5.75, false);

            miComputadora.InformarEstado();

            miComputadora.SetPeso(6);
            miComputadora.SetProcesador((EProcesador)8);
            miComputadora.SetMarca((EMarca)0);
            miComputadora.Encender();

            miComputadora.InformarEstado();

            Console.ReadKey();
        }
    }
}
