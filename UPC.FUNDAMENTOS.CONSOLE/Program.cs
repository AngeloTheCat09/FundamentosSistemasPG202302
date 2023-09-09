using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.FUNDAMENTOS.CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrColores = new String[10];
            arrColores[0] = "Yellow";
            arrColores[1] = "Blue";
            arrColores[2] = "Red";
            arrColores[4] = "Green";
            arrColores[5] = "Green";
            arrColores[6] = "Green";
            arrColores[7] = "Brown";
            arrColores[9] = "Black";

            var arrAhorro = new decimal[5];

            var arrRespuestasExamen = new bool[40];

            
            
            System.Console.WriteLine("El primer elemento del arreglo");
            System.Console.WriteLine(arrColores.First());
            System.Console.WriteLine(arrColores.ElementAt(4));
            System.Console.WriteLine("Recorrido de un arreglo");
            var arrResultado = arrColores.Where(x=>x !=null).Where(x => x.Contains("l")).ToArray();
            for(int i = 0; i <arrResultado.Length; i++)
            {
                System.Console.WriteLine(arrResultado[i]);
            }

            System.Console.WriteLine("Ordenado del arreglo");
            var arrOrdenado = arrColores.Where(x => x != null).OrderBy(x => x).ToArray();
            for (int i = 0; i < arrOrdenado.Length; i++)
            {
                System.Console.WriteLine(arrOrdenado[i]);
            }

            System.Console.WriteLine("Eliminando por indice");
            arrColores[4] = null;
            for (int i = 0; i < arrColores.Length; i++)
            {
                System.Console.WriteLine(arrColores[i]);
            }

            

            var arrEstudiantes = ListarEstudiantes();
            for (int i = 0; i < arrEstudiantes.Count(); i++)
            {
                if(arrEstudiantes[i] != null) {
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].id_estudiante);
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].nombre);
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].fecha_nacimiento);
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].matriculado);
                }
                var objNuevoEstudiante = new Estudiante()
                {
                    id_estudiante = arrEstudiantes.Count(),
                    nombre = "Chiquito Flores",
                    fecha_nacimiento = new DateTime(1975, 1, 1),
                    matriculado = false
                };
                arrEstudiantes = Registrar(arrEstudiantes, objNuevoEstudiante);
                Imprimir(arrEstudiantes);
            }
            System.Console.ReadLine();
        }

        static Estudiante[] ListarEstudiantes()
        {
            var arrEstudiantes = new Estudiante[10];
            var objEstudiante = new Estudiante();
            objEstudiante.id_estudiante = 1;
            objEstudiante.nombre = "Cristiano Ronaldo";
            objEstudiante.fecha_nacimiento = new DateTime(1980, 1, 10);
            objEstudiante.matriculado = true;
            arrEstudiantes[0] = objEstudiante;
            objEstudiante=new Estudiante();
            objEstudiante.id_estudiante = 2;
            objEstudiante.nombre = "Lionel Messi";
            objEstudiante.fecha_nacimiento = new DateTime(1982, 10, 01);
            objEstudiante.matriculado = true;
            arrEstudiantes[1] = objEstudiante;
            objEstudiante =new Estudiante();
            objEstudiante.id_estudiante=3;
            objEstudiante.nombre = " Waldir Saenz";
            objEstudiante.fecha_nacimiento = new DateTime(1970, 08, 05);
            objEstudiante.matriculado= true;
            arrEstudiantes[2] = objEstudiante;

            return arrEstudiantes;
        }

        static Estudiante[] Registrar(Estudiante[] arrEstudiante, Estudiante objEstudiante)
        {
            arrEstudiante[arrEstudiante.Count()] = objEstudiante;
            return arrEstudiante;
        }
        static void Imprimir(Estudiante[] arrEstudiantes) 
        {
            for (int i = 0; i < arrEstudiantes.Count(); i++) 
            {
                if (arrEstudiantes[i] != null) 
                {
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].id_estudiante);
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].nombre);
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].fecha_nacimiento);
                    System.Console.WriteLine("ID Estudiante: " + arrEstudiantes[i].matriculado);
                }
            }
        }

        class Estudiante
        {
            public int id_estudiante { get; set; }
            public string nombre { get; set; }
            public DateTime fecha_nacimiento { get; set; }
            public bool matriculado { get; set; }
        }
    }
}
