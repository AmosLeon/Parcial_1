# Parcial 1 - Programación 1
Proyecto de consola en C# que demuestra herencia, polimorfismo y sobrescritura de métodos.

## Estructura del proyecto
- Vehiculo.cs — clase base con propiedades comunes: Marca, Modelo, Anio; métodos virtual MostrarInformacion() y Encender().
- Carro.cs — hereda de Vehiculo; añade NumeroPuertas; override de MostrarInformacion() y Encender().
- Moto.cs — hereda de Vehiculo; añade Cilindraje; override de MostrarInformacion() y Encender().
- Program.cs — Main crea List<Vehiculo>, instancia 2 carros y 2 motos, los agrega a la lista y recorre la lista llamando a los   métodos sobrescritos.

## Cumplimiento de la consigna
- Herencia: Carro y Moto heredan de Vehiculo.
- Polimorfismo: se usa List<Vehiculo> y al recorrerla se ejecutan los métodos sobrescritos según el tipo real.
- Sobrescritura: MostrarInformacion() y Encender() están implementados con override en cada subclase.
- Ejecución en consola: Program.cs crea objetos, los agrega a la lista y muestra la salida en consola.
