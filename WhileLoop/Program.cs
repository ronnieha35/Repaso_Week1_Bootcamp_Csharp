namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int contadorTabla = 1;
            //Console.WriteLine("Ingrese el valor de la tabla");
            //int valortabla ;
            //int valorResultado;


            //valortabla = int.Parse(Console.ReadLine());

            //while (contadorTabla <= 12)
            //{
            //    valorResultado = valortabla * contadorTabla;
            //    Console.WriteLine("La tabla del numero : " + valortabla + " es igual a " + valortabla + " * " + contadorTabla + " = " + valorResultado);
            //    contadorTabla++;
            //}


            int NumFila = 1;

            while (NumFila <= 5)
            {
                int num = 1;

                // Imprime numero
                while (num <= NumFila)
                {
                    Console.Write(num);
                    num++;
                }

                int asteriscos = 5 - NumFila;

                // Imprime *
                while (asteriscos > 0)
                {
                    Console.Write(" ");
                    asteriscos--;
                }

                Console.WriteLine();
                NumFila++;
            }



            int filainversa = 1;

            while (filainversa <= 5)
            {
                int asterisco = 5 - filainversa;

                // imprime *
                while (asterisco > 0)
                {
                    Console.Write(" ");
                    asterisco--;
                }

                int numero = 1;

                // imprime numerso
                while (numero <= filainversa)
                {
                    Console.Write(numero);
                    numero++;
                }

                Console.WriteLine();
                filainversa++;
            }
        }
    }
}
