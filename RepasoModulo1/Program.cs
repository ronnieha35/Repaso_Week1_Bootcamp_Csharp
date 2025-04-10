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
        }
    }
}
