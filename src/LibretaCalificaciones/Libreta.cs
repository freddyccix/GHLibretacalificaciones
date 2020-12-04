using System;
using System.Collections.Generic;

namespace LibretaCalificaciones
{
    class Libreta
    {
        
        private List<double> calificaciones;//Campo
        private string nombre;
        public Libreta(string nombre)
        {
            this.nombre = nombre;
            calificaciones = new List<double>();
        }
        // API
        
        public void MostrarEstadisticas()
        {
            var resultado = 0.0;
            var promedio = 0.0;
            var notaMaxima = double.MinValue;
            var notaMinima = double.MaxValue;
            foreach (var item in calificaciones)
            {
                notaMaxima = Math.Max(notaMaxima, item);
                notaMinima = Math.Min(notaMinima, item);
                resultado += item;
            }
            promedio = resultado / calificaciones.Count;
            //var resultado = variable1+variable2;
            
            Console.WriteLine($"El nombre de la libreta es: {nombre}");
            Console.WriteLine($"El resultado de la suma es: {resultado:N1}");
            Console.WriteLine($"El promedio es: {promedio:N1}");
            Console.WriteLine($"La nota máxima es: {notaMaxima:N1}");
            Console.WriteLine($"La nota mínima es: {notaMinima:N1}");
        }
        public void AgregarCalificacion(double calificacion)
        {
            //Lógica
            calificaciones.Add(calificacion);



        }
    }
}
