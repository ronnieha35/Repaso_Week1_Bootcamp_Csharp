namespace Repaso_Week1_Bootcamp_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("======= Validacion de Numero Mayor =========");
            Console.Clear();

            // Ingresar el Numero 1 y validar
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double num3 = Convert.ToInt32(Console.ReadLine());




            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El número mayor es: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El número mayor es: " + num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El número mayor es: " + num3);
            }
            else
            {
                Console.WriteLine("Hay números iguales que son los mayores.");
            }


            Console.WriteLine("======= Finalizacion de Validacion de 3 numeros =========");




            Console.WriteLine("======= Validacion de Area =========");
           

            Console.WriteLine("Seleccione una Opcion:");
            Console.WriteLine("1. Calcular el area de un Circulo");
            Console.WriteLine("2. Calcular el area de un rectangulo");
            Console.Write("Ingrese su opcion (1 o 2): ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            
            switch (opcion)
            {
                case 1:
                    
                    Console.Write("Ingrese el radio del Circulo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    double areaCirculo = 3.1416 * radio * radio;
                    Console.WriteLine("El area del circulo es: " + areaCirculo);
                    break;

                case 2:
                    
                    Console.Write("Ingrese el largo del rectangulo: ");
                    double largo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectangulo: ");
                    double ancho = Convert.ToDouble(Console.ReadLine());
                    double areaRectangulo = largo * ancho;
                    Console.WriteLine("El area del rectangulo es: " + areaRectangulo);
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

            Console.WriteLine("======= Finalizacion de Validacion Area =========");

        }

    }
}
