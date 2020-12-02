using System;
using System.Collections.Generic;

namespace LibretaCalificaciones
{
    class Program
    {

        /*Necesitamos Libreta de calificaciones para leer la Lb de cada Estudiante
         y calcule las estadísticas básicas de estas calificaciones 
         (promedio, nota + alta y nota + baja) las calificaciones deben estar en punto flotante 
         de 0 a 100*/
        static void Main(string[] args)
        {


            var calificaciones = new List<double>() { 10.8, 20.8, 12.8 };

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
            Console.WriteLine($"El resultado de la suma es: {resultado:N1}");
            Console.WriteLine($"El promedio es: {promedio:N1}");
            Console.WriteLine($"La nota máxima es: {notaMaxima:N1}");
            Console.WriteLine($"La nota mínima es: {notaMinima:N1}");

            //Comentario

        }
    }
}
