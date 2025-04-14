namespace Modulo1_Challenge_RonnieAlarcon
{
    public class Program
    {
        //Se agrega 4 Clientes
        static string[] nombres = { "Ronnie Alarcon", "Pedro Vargas", "Natalia Perez", "Luis Morales" };
        static string[] usuarios = { "ralarcon", "pvargas", "nperez", "lmorales" };
        static int[] pines = { 1234, 5678, 8989, 4321 };
        static decimal[] saldos = { 30000m, 1200m, 5000m, 10000m };

        //Array de List para almacenar los movimientos
        static Dictionary<string, List<string>> movimientos = new Dictionary<string, List<string>>()
        {
            { "ralarcon", new List<string>() },
            { "pvargas", new List<string>() },
            { "nperez", new List<string>() },
            { "lmorales", new List<string>() }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                int clienteActual = -1;
                int intentos = 0;

                Console.WriteLine("==== Bienvenido al Cajero Automatico de Banco Chipley ====");

                //Validamos la autenticacion
                while (clienteActual == -1)
                {
                    Console.WriteLine("Ingrese su Usuario:  ");
                    string user = Console.ReadLine();

                    Console.WriteLine("Ingrese su PIN: ");
                    int pin = int.Parse(Console.ReadLine());

                    int indice = 0;
                    foreach (string usuario in usuarios)
                    {
                        if (user == usuario && pin == pines[indice])
                        {
                            clienteActual = indice;
                            break;
                        }

                        indice++;
                    }

                    if (clienteActual == -1)
                    {
                        intentos++;
                        Console.WriteLine("Credenciales incorrectas. Acceso denegado.");

                    }

                    if (intentos == 3)
                    {
                        Console.WriteLine("Ha intentando 3 veces acceder con un usuario o contraseña invalida, ingrese de nuevo al sistemas, gracias...!!");
                        return;
                    }
                }

                bool salir = false;


                //Procesos Generales
                while (!salir)
                {
                    Console.Clear();
                    Console.WriteLine($"==== Bienvenido {nombres[clienteActual]} ====");
                    Console.WriteLine("1. Consultar Saldo");
                    Console.WriteLine("2. Retirar Efectivo");
                    Console.WriteLine("3. Depositar Efectivo");
                    Console.WriteLine("4. Transferir Efectivo");
                    Console.WriteLine("5. Mostrar Movimientos");
                    Console.WriteLine("6. Cerrar Sesion");
                    Console.WriteLine("7. Salir");
                    Console.Write("Seleccione una opcion: ");

                    string opcion = Console.ReadLine();


                    switch (opcion)
                    {
                        case "1":
                            ConsultarSaldo(clienteActual);
                            break;

                        case "2":
                            RetirarEfectivo(clienteActual);
                            break;

                        case "3":
                            DepositarEfectivo(clienteActual);
                            break;

                        case "4":
                            TransferirEfectivo(clienteActual);
                            break;

                        case "5":
                            MostrarMovimientos(clienteActual);
                            break;

                        case "6":
                            //Cierra menu sesion actual y vuelve al login
                            salir = true;
                            Console.WriteLine("Sesion cerrada. Regresando a la pantalla de inicio...");
                            break;

                        case "7":
                            salir = true;
                            Console.WriteLine("Gracias por usar el cajero. ¡Hasta pronto!");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opcion no valida.");
                            break;

                    }

                    if (!salir)
                    {
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                }

                Console.Clear();
            }


        }

        private static void ConsultarSaldo(int clienteActual)
        {
            Console.WriteLine("==== Saldos ====");
            Console.WriteLine("");
            Console.WriteLine($"Su saldo actual es: S/ {saldos[clienteActual]:N2}");
        }
        private static void RetirarEfectivo(int clienteActual)
        {
            Console.WriteLine("==== Retiros ====");
            Console.WriteLine("");
            Console.WriteLine("Puede cancelar la operacion ingresando 'C'.");
            Console.WriteLine("");
            Console.Write("Ingrese el monto a retirar: S/ ");

            string inputRetiro = Console.ReadLine();

            //Opcion para Cancelar
            if (inputRetiro.ToUpper() == "C")
            {
                Console.WriteLine("Operacion cancelada.");
                return;
            }

            decimal retiro;

            if (!decimal.TryParse(inputRetiro, out retiro))
            {
                Console.WriteLine("Entrada invalida. Ingrese un numero.");
                return;
            }

            if (retiro <= 0)
            {
                Console.WriteLine("El monto debe ser mayor que cero.");
                return;
            }

            if (retiro > 0 && retiro <= saldos[clienteActual])
            {
                saldos[clienteActual] -= retiro;
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: S/ {saldos[clienteActual]:N2}");

                //Registramos los retiros
                RegistrarMovimiento(clienteActual, $"-{retiro:N2} Retiro de efectivo");
            }
            else
            {
                Console.WriteLine("Monto invalido o saldo insuficiente.");
            }
        }
        private static void DepositarEfectivo(int clienteActual)
        {
            Console.WriteLine("==== Depositos ====");
            Console.WriteLine("");
            Console.WriteLine("Puede cancelar la operación ingresando 'C'.");
            Console.WriteLine("");
            Console.Write("Ingrese el monto a depositar: S/ ");

            string inputDeposito = Console.ReadLine();

            //Opcion para Cancelar
            if (inputDeposito.ToUpper() == "C")
            {
                Console.WriteLine("Operacion cancelada.");
                return;
            }

            decimal deposito;
            if (!decimal.TryParse(inputDeposito, out deposito))
            {
                Console.WriteLine("Entrada invalido.");
                return;
            }

            if (deposito > 0)
            {
                saldos[clienteActual] += deposito;
                Console.WriteLine($"Depósito exitoso. Nuevo saldo: S/ {saldos[clienteActual]:N2}");

                //Registramos el Deposito
                RegistrarMovimiento(clienteActual, $"+{deposito:N2} Depósito en efectivo");
            }
            else
            {
                Console.WriteLine("Monto invalido.");
            }
        }
        private static void TransferirEfectivo(int clienteActual)
        {
            Console.WriteLine("==== Transferencia ====");
            Console.WriteLine("");
            Console.WriteLine("Lista de usuarios disponibles:");

            for (int i = 0; i < usuarios.Length; i++)
            {
                if (i != clienteActual)
                    Console.WriteLine($"{i}. {nombres[i]} ({usuarios[i]})");
            }

            //Opcion para Cancelar la seleccion del Usuario
            Console.WriteLine("Puede cancelar la operacion ingresando 'C'.");
            Console.WriteLine("");
            Console.Write("Ingrese el número del destinatario: ");

            string inputOpcion = Console.ReadLine();

            if (inputOpcion.ToUpper() == "C")
            {
                Console.WriteLine("Operacion cancelada.");
                return;
            }

            int destinatario;

            if (!int.TryParse(inputOpcion, out destinatario))
            {
                Console.WriteLine("Entrada invalida.");
                return;
            }

            if (destinatario < 0 || destinatario >= usuarios.Length || destinatario == clienteActual)
            {
                Console.WriteLine("Destinatario inválido.");
                return;
            }

            //Opcion para cancelar la Transferencia
            Console.WriteLine("Puede cancelar la operacion ingresando 'C'.");
            Console.WriteLine("");
            Console.WriteLine($"Tu Saldo Actual es : S/ {saldos[clienteActual]:N2}");
            Console.Write("Ingrese el monto a transferir: S/ ");

            string inputTransferencia = Console.ReadLine();

            if (inputTransferencia.ToUpper() == "C")
            {
                Console.WriteLine("Operación cancelada.");
                return;
            }


            decimal monto;
            if (!decimal.TryParse(inputTransferencia, out monto))
            {
                Console.WriteLine("Entrada invalida.");
                return;
            }


            if (monto > 0 && monto <= saldos[clienteActual])
            {
                saldos[clienteActual] -= monto;
                saldos[destinatario] += monto;
                Console.WriteLine($"Transferencia exitosa a {nombres[destinatario]}. Nuevo saldo: S/ {saldos[clienteActual]:N2}");


                //Registramos la transferencia
                RegistrarMovimiento(clienteActual, $"-{monto:N2} Transferencia a {nombres[destinatario]}");
                RegistrarMovimiento(destinatario, $"+{monto:N2} Transferencia de {nombres[clienteActual]}");

            }
            else
            {
                Console.WriteLine("Monto invalido o saldo insuficiente.");
            }
        }
        private static void MostrarMovimientos(int clienteActual)
        {
            Console.WriteLine("==== Últimos 10 Movimientos ====");

            List<string> listaMovimientos = movimientos[usuarios[clienteActual]];

            if (listaMovimientos.Count == 0)
            {
                Console.WriteLine("No hay movimientos registrados.");
            }
            else
            {
                Console.WriteLine("Mostrando los últimos movimientos:");

                foreach (string movimiento in listaMovimientos)
                {
                    Console.WriteLine(movimiento);
                }

                Console.WriteLine("");
                Console.WriteLine($"Tu Saldo Actual es : S/ {saldos[clienteActual]:N2}");
            }

        }
        private static void RegistrarMovimiento(int clienteActual, string descripcion)
        {
            string users = usuarios[clienteActual];
            string registro = $"{DateTime.Now:dd/MM/yyyy HH:mm} - {descripcion}";

            movimientos[users].Add(registro);

            if (movimientos[users].Count > 10)
            {
                movimientos[users].RemoveAt(10);
            }

        }








    }
}
