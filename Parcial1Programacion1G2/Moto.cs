using System;

namespace Parcial1Programacion1G2
{
    public class Moto : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Moto(string marca, string modelo, int anio, int cilindraje)
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Tipo: Moto");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
            Console.WriteLine("Cilindraje: " + Cilindraje + " cc");
            Console.WriteLine("====================================");
        }

        public override void Encender()
        {
            Console.WriteLine("La moto se está encendiendo: pulsa el botón de arranque y el motor cobra vida.");
        }
    }
}
