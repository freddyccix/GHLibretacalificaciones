using System;
using Xunit;
using LibretaCalificaciones;

namespace test
{
    public class LibretaTest
    {
        [Fact]//decorador
        public void ObtenerEstadisticas_PruebaGeneral()//Una operación por caso de uso
        {
            //TDD - Test-Driven Design

            //Arreglo
            
            var libreta = new Libreta("");
            libreta.AgregarCalificacion(10.8);
            libreta.AgregarCalificacion(20.8);
            libreta.AgregarCalificacion(12.8);
            

            //Actuar
            var resultado = libreta.ObtenerEstadisticas();

            //Asegurar
            Assert.Equal(14.8,resultado.Promedio,1);
            Assert.Equal(10.8,resultado.Minimo,1);
            Assert.Equal(20.8,resultado.Maximo,1);
        }
    }
}
