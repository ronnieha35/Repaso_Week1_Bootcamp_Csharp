namespace RepasoModulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, filas;

            Console.WriteLine("Ingresa el numero de Filas");
            filas = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= filas; i++)
            {
                Console.Write("* ");

                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Se acabo el Programa");


            //Piramide


            for (i = 1; i <= filas; i++)
            {
                // Guiones
                for (j = 1; j <= filas - i + 1; j++)
                {
                    Console.Write("-");
                }

                // Asteriscos
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Se acabó el programa");


            //Contar Duplicados dentro de un arreglo
            //int [] = new [44,44,32,65]

            int[] arreglo = new int[] { 44, 44, 32, 35 };

            Dictionary<int, int> contador = new Dictionary<int, int>();

            // Contar ocurrencias
            foreach (int numero in arreglo)
            {
                if (contador.ContainsKey(numero))
                {
                    contador[numero]++;
                }
                else
                {
                    contador[numero] = 1;
                }
            }

            // Mostrar duplicados
            Console.WriteLine("Elementos duplicados:");
            foreach (var par in contador)
            {
                if (par.Value > 1)
                {
                    Console.WriteLine($"Número {par.Key} se repite {par.Value} veces.");
                }
            }
        }
    }
}
