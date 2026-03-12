using System;

namespace Parcial1Programacion1G2
{
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Carro(string marca, string modelo, int anio, int numeroPuertas)
            : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Tipo: Carro");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
            Console.WriteLine("Número de puertas: " + NumeroPuertas);
            Console.WriteLine("====================================");
        }

        public override void Encender()
        {
            Console.WriteLine("El carro se está encendiendo: gira la llave y el motor arranca.");
        }
    }
}
