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
            //Dependencia
            var libreta = new Libreta("Libreta de Freddy");//Instanciar
            libreta.AgregarCalificacion(10.8);
            libreta.AgregarCalificacion(20.8);
            libreta.AgregarCalificacion(12.8);
            
            
            libreta.MostrarEstadisticas();

            //Comentario

        }
    }
}
