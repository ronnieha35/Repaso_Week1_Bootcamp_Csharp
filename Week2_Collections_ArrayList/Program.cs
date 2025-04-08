using System.Collections;

namespace Week2_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYLIST EN C#");
            Console.WriteLine("===============\n");

            // 1. Creación e inicialización de un ArrayList
            Console.WriteLine("1. Creación e inicialización:");
            ArrayList lista = new ArrayList();

            // 2. Añadir elementos (de cualquier tipo)
            Console.WriteLine("\n2. Añadir elementos:");
            lista.Add(10);                // Entero
            lista.Add("Hola");           // String
            lista.Add(true);             // Boolean
            lista.Add(3.14);             // Double
            lista.Add("Hola Codigo");

            // Mostrar elementos
            MostrarElementos(lista);

            // 3. Insertar elementos en posición específica
            Console.WriteLine("\n3. Insertar elementos:");
            lista.Insert(0, "Nuevo elemento");  // Inserta en el índice 2
            MostrarElementos(lista);

            // 4. Eliminar elementos
            Console.WriteLine("\n4. Eliminar elementos:");
            lista.Remove("Hola");              // Elimina un elemento específico
            lista.RemoveAt(0);                 // Elimina el elemento en el índice 0
            MostrarElementos(lista);

            // 5. Verificar si un elemento existe
            Console.WriteLine("\n5. Verificar existencia:");
            bool contiene = lista.Contains(3.14);
            Console.WriteLine($"¿La lista contiene 3.14? {contiene}");

            // 6. Obtener el índice de un elemento
            Console.WriteLine("\n6. Obtener índice:");
            int indice = lista.IndexOf(true);
            Console.WriteLine($"Índice de 'true': {indice}");

            // 7. Convertir a array
            Console.WriteLine("\n7. Convertir a array:");
            object[] array = lista.ToArray();
            Console.WriteLine($"Array creado con {array.Length} elementos");

            // 8. Ordenar elementos (con precaución, deben ser del mismo tipo o comparables)
            Console.WriteLine("\n8. Crear una lista homogénea y ordenarla:");
            ArrayList numeros = new ArrayList { 5, 2, 9, 1, 7 };
            Console.WriteLine("Lista original:");
            foreach (int num in numeros)
                Console.Write($"{num} ");

            numeros.Sort();
            Console.WriteLine("\nLista ordenada:");
            foreach (int num in numeros)
                Console.Write($"{num} ");

            // 9. Limpiar la lista
            Console.WriteLine("\n\n9. Limpiar lista:");
            lista.Clear();
            Console.WriteLine($"Número de elementos después de Clear(): {lista.Count}");

            // 10. Capacidad vs Tamaño
            Console.WriteLine("\n10. Capacidad vs Tamaño:");
            ArrayList listaGrande = new ArrayList();
            Console.WriteLine($"Capacidad inicial: {listaGrande.Capacity}");

            // Agregar muchos elementos
            for (int i = 0; i < 10; i++)
                listaGrande.Add(i);

            Console.WriteLine($"Después de añadir 10 elementos:");
            Console.WriteLine($"Tamaño (Count): {listaGrande.Count}");
            Console.WriteLine($"Capacidad: {listaGrande.Capacity}");

            // Establecer capacidad manualmente
            listaGrande.TrimToSize();
            Console.WriteLine($"Después de TrimToSize():");
            Console.WriteLine($"Capacidad: {listaGrande.Capacity}");
        }

        // Método para mostrar los elementos de un ArrayList
        static void MostrarElementos(ArrayList lista)
        {
            Console.WriteLine($"La lista tiene {lista.Count} elementos:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"  [{i}] = {lista[i]} (Tipo: {lista[i].GetType().Name})");
            }
        }
    
    }
}
