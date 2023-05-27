using Laboratorio_final.clases;
using System;
using System.Numerics;

namespace Laboratorio_final
{
    class Program
    {
        static void Main(string[] args)
        {
            string databasePath = "ruta_de_la_base_de_datos";
            GestorEmpleados gestorEmpleados = new GestorEmpleados(databasePath);

            gestorEmpleados.CrearTabla();
            //Para ver los nombres al inicio del programa, nombres ya ingresados anteriormente
            Console.WriteLine("Nombres de empleados:");
            var empleados = gestorEmpleados.ObtenerEmpleados();
            foreach (var emp in empleados)
            {
                Console.WriteLine(emp.ToString());
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Ingrese los datos del empleado {i + 1}:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();
                Console.Write("Sueldo: ");
                decimal Sueldo = Convert.ToDecimal(Console.ReadLine());

                Empleado empleado = new Empleado(0, nombre, apellido, edad, cargo, Sueldo);
                gestorEmpleados.AgregarEmpleado(empleado);

                Console.WriteLine("Empleado agregado correctamente.");
                Console.WriteLine();
            }

            //Para ver los nombres al final del programa
            //Console.WriteLine("Nombres de empleados:");
            //var empleados = gestorEmpleados.ObtenerEmpleados();
            //foreach (var emp in empleados)
            //{
            //    Console.WriteLine(emp.ToString());
            //}

            Console.ReadLine();
        }
    }
}