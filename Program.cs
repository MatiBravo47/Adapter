using System;

namespace Adapter 
{
    //El objetivo define la interfaz específica del dominio utilizada por el código del cliente.
    public interface ITarget 
    {
        string GetRequest();
    }
        /*
    El Adaptee contiene algunos comportamientos útiles,
    pero su interfaz es incompatible con el código del cliente existente.
    El Adaptee necesita cierta adaptación antes de que el código del cliente pueda usarlo
    */
    class Adaptee 
    {
        public string GetSpecificRequest() 
        {
            return "Solicitud especifica";
        }
    }
    //El adaptador hace que la interfaz del adaptado sea compatible con la interfaz del objetivo.

    class Adapter : ITarget 
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee) 
        {
            this._adaptee = adaptee;
        }

        public string GetRequest() 
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("La interfaz adaptee es incompatible con el cliente.");
            Console.WriteLine("Pero con el adaptador el cliente puede llamar a su método.");
            Console.WriteLine(target.GetRequest());
        }
    } 
}
