using System;
using System.Collections.Generic;

namespace LibretaCalificaciones
{
    public class Libreta
    {
        private List<double> calificaciones;//Campo
        private string nombre;
        // private double resultado = 0.0;
        

        public Libreta(string nombre)
        {
            this.nombre = nombre;
            this.calificaciones = new List<double>();
        }
        // API

        public Estadistica ObtenerEstadisticas()
        {

            var resultado  = new Estadistica();

            resultado.Promedio = 0.0;
            resultado.Maximo = double.MinValue;
            resultado.Minimo = double.MaxValue;

            foreach (var item in calificaciones)
            {
                resultado.Maximo = Math.Max(resultado.Maximo, item);
                resultado.Minimo = Math.Min(resultado.Minimo, item);
                resultado.Promedio += item;
            }
            resultado.Promedio = resultado.Promedio / calificaciones.Count;
            //var resultado = variable1+variable2;
            return resultado;
        }
        public void MostrarEstadisticas()
        {
            
            // Console.WriteLine($"El nombre de la libreta es: {nombre}");
            // Console.WriteLine($"El resultado de la suma es: {resultado:N1}");
            // Console.WriteLine($"El promedio es: {promedio:N1}");
            // Console.WriteLine($"La nota máxima es: {notaMaxima:N1}");
            // Console.WriteLine($"La nota mínima es: {notaMinima:N1}");
        }
        public void AgregarCalificacion(double calificacion)
        {
            //Lógica >0<100
            calificaciones.Add(calificacion);



        }
    }
}
