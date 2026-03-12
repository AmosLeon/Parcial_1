using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Vehículo:");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo se está encendiendo...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE VEHICULOS - PARCIAL   ");
            Console.WriteLine("====================================");
            Console.WriteLine();
            // Crear una lista de tipo Vehiculo
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            // Instanciar objetos (dos Carro y dos Moto)
            Carro carro1 = new Carro("Toyota", "Corolla", 2020, 4);
            Carro carro2 = new Carro("Honda", "Civic", 2018, 4);
            Moto moto1 = new Moto("Yamaha", "MT-07", 2021, 689);
            Moto moto2 = new Moto("Kawasaki", "Ninja 400", 2019, 399);

            // Agregar los objetos a la lista
            vehiculos.Add(carro1);
            vehiculos.Add(carro2);
            vehiculos.Add(moto1);
            vehiculos.Add(moto2);

            // Recorrer la lista y llamar a los métodos
            foreach (Vehiculo v in vehiculos)
            {
                v.MostrarInformacion();
                v.Encender();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }
}
