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
        }
    }
}
