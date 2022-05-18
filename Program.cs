using System;

namespace UsoArrays
{
    class Program
    {
        static void Main( string[]args)
        {

            var valores = new[] { 15, 28, 35, 75.5, 30.30 };

            Empleados Ana = new Empleados("Ana", 27);

            Empleados [] arrayEmpleados = new Empleados [2];

            arrayEmpleados[0] = new Empleados("Sara", 37);

            arrayEmpleados[1] = Ana;

            var personas = new[]
            {
            new{Nombre="Juan", Edad=19},

            new{Nombre="Maria", Edad=49 },

            new{Nombre="Diana", Edad = 35 },

            };

           /* for (int i = 0; i <arrayEmpleados.Length; i++)
            {

                Console.WriteLine(arrayEmpleados[i].getInfo());

            }*/

            foreach (Empleados variable in arrayEmpleados)

            {

                Console.WriteLine(variable.getInfo());

            }

    }

    }

    class Empleados
    {

        public Empleados(string nombre, int edad)
        {

            this.nombre = nombre;

            this.edad = edad;

        }

        public string getInfo()
        {

            return "Nombre del empleado: " + nombre + "Edad:" + edad;
        }

       private string nombre;

        private int edad;

    }
}