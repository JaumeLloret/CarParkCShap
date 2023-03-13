using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ParqueVehiculos
{
    internal abstract class  Vehiculo
    {
        protected string Matricula { get; set; }
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected string Color { get; set; }
        protected int Km { get; set; }
        protected int NumPlazas { get; set; }
        protected int NumPuertas { get; set; }

        public static int NUM_VEHICULOS = 0;

        public const int MAX_VEHICULOS = 5;

        protected Vehiculo()
        {
            Matricula = matAleatorio();
            Color = "blanco";
            Km = 0;
        }

        protected Vehiculo( string marca, string modelo, string color, int km, int numPlazas, int numPuertas):this()
        {
            
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Km = km;
            NumPlazas = numPlazas;
            NumPuertas = numPuertas;
        }


        public override string ToString()
        {
            return base.ToString();
        }
        
       

        public static String matAleatorio()
        {
            Random rand = new Random();
            
            String matricula = rand.Next(1000,9999).ToString();

            
            return matricula;
        }

        public abstract void Arrancar();
        public abstract void Acelerar();
        public abstract void Frenar();


    }
}
