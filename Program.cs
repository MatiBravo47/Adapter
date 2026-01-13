using System;

namespace Adapter 
{
    //El objetivo define la interfaz específica del dominio utilizada por el código del cliente.

    /*
        * TARGET
        * Interfaz que el cliente espera utilizar.
        * El cliente trabaja en grados Celsius.
    */
    public interface ITemperatureCelsius 
    {
        double GetTemperatureInCelsius();
    }


        /*
        * ADAPTEE
        * Clase existente que devuelve la temperatura en Fahrenheit.
        * No podemos modificar esta clase.
        */
    class FahrenheitSensor
    {
        public double GetTemperatureInFarehrenheit()
        {
            return 86; //Temperatura simulada
        }
    }
    //El adaptador hace que la interfaz del adaptado sea compatible con la interfaz del objetivo.
    /*
 * ADAPTER
 * Convierte la temperatura de Fahrenheit a Celsius
 * para que sea compatible con el cliente.
 */


    class TemperatureAdapter : ITemperatureCelsius
    {
        private readonly FahrenheitSensor _sensor;

        public TemperatureAdapter(FahrenheitSensor sensor) 
        {
            _sensor = sensor;
        }

        public double GetTemperatureInCelsius()
        {
            double fahrenheit = _sensor.GetTemperatureInFarehrenheit();
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    /*
 * CLIENT
 * Solo conoce la interfaz ITemperatureCelsius.
 */
    class Program
    {
        static void Main(string[] args) 
        {
            ITemperatureCelsius temperatureSensor = new TemperatureAdapter(new FahrenheitSensor());

            Console.WriteLine("Temperature en Celsius");
            Console.WriteLine(temperatureSensor.GetTemperatureInCelsius() + "°C");
        }
    } 
}
