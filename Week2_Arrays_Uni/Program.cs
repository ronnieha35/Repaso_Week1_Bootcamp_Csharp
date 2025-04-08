using System.Net.Http.Headers;

namespace Week2_Arrays_Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ////salto de linea \n

            //int num = 45;
            ////Console.WriteLine($"Prueba es : {num}");
            //int[] numeros = { 1, 2, 3, 4, 5 };


            //int suma = 0;

            //foreach (int numero in numeros)
            //{
            //    suma += numero;
            //}

            //Console.WriteLine($"La suma es : {suma}");

            //int maximo = numeros[0];

            //for (int i = 1; i < numeros.Length; i++)
            //{
            //    if (numeros[i] > maximo)
            //    {
            //        maximo = numeros[i];
            //    }
            //}

            

            //Bienvenida

          

            //int[] Calificaciones = IngresarCalificaciones();
            //double promedio = CalcularPromedio(Calificaciones);

            //int notaMaxima = Calificaciones.Max();
            //int notaminima = Calificaciones.Min();
            //int aprobados = CalcularAprobados(Calificaciones);
            ////int[] CalificacionesOrdenadas = OrdenarCalificaciones(Calificaciones);
            //int[] RangoCalificaciones = ContarRangos(Calificaciones);

            //Console.WriteLine("\n--- Resultados ---");
            //Console.WriteLine($"Promedio de calificaciones: {promedio:F2}");
            //Console.WriteLine($"Calificación más alta: {notaMaxima}");
            //Console.WriteLine($"Calificación más baja: {notaminima}");
            //Console.WriteLine($"Cantidad de estudiantes que aprobaron (>= 60): {aprobados}");


        
            //Console.WriteLine();

            //Console.WriteLine("\nCantidad de estudiantes por rango:");
            //Console.WriteLine($"0-59 (Reprobado): {RangoCalificaciones[0]}");
            //Console.WriteLine($"60-69 (Suficiente): {RangoCalificaciones[1]}");
            //Console.WriteLine($"70-79 (Bien): {RangoCalificaciones[2]}");
            //Console.WriteLine($"80-89 (Notable): {RangoCalificaciones[3]}");
            //Console.WriteLine($"90-100 (Excelente): {RangoCalificaciones[4]}");




        }

        private static int[] ContarRangos(int[] calificaciones)
        {
            int[] rangos = new int[5]; // [Reprobado, Suficiente, Bien, Notable, Excelente]

            foreach (int nota in calificaciones)
            {
                if (nota <= 59)
                    rangos[0]++;
                else if (nota <= 69)
                    rangos[1]++;
                else if (nota <= 79)
                    rangos[2]++;
                else if (nota <= 89)
                    rangos[3]++;
                else
                    rangos[4]++;
            }

            return rangos;
        }

    
        private static int CalcularAprobados(int[] calificaciones)
        {
            int contador = 0;
            foreach (int nota in calificaciones)
                if (nota >= 60)
                    contador++;
            return contador;
        }

        private static double CalcularPromedio(int[] calificaciones)
        {
            //double promedio = calificaciones.Average();

            int suma = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                suma += calificaciones[i];
            }
            return (double)suma / calificaciones.Length;
  
        }

        private static int[] IngresarCalificaciones()
        {


            int[] Calificaciones = new int[10];

            Console.WriteLine("Ingrese las calificaciones de 10 estudiantes (valores entre 0 y 100):");

            for (int i = 0; i < Calificaciones.Length; i++)
            {
                int calificacion;
                do
                {
                    Console.Write($"Calificación del estudiante #{i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 0 || calificacion > 100);

                Calificaciones[i] = calificacion;
            }

            return Calificaciones;
        }
    }
}
