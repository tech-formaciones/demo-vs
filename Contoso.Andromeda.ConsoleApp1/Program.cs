using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;



namespace Contoso.Andromeda.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var alumno = new Alumno();   

        }

    }

    public class Alumno
    { 
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
    }


}