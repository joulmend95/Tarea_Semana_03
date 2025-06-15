// Importa el espacio de nombres System para usar funcionalidades básicas
using System; 

class Program
{
    static void Main(string[] args)
    {
        // Muestra el título del programa
        Console.WriteLine("Registro de Estudiante"); 

        // Declaración de variables individuales
        string id, nombres, apellidos, direccion;

        // Se declarapara para almacenar numeros de teléfono
        string[] telefonos = new string[3];

        // Captura de datos desde el teclado
        Console.Write("Ingrese ID del estudiante: ");
        id = Console.ReadLine(); // Lee el ID ingresado por el usuario

        // Lee los nombres y apellidos del estudiante
        Console.Write("Ingrese nombres: ");
        nombres = Console.ReadLine(); 

        Console.Write("Ingrese apellidos: ");
        apellidos = Console.ReadLine(); 

        // Lee la dirección
        Console.Write("Ingrese dirección: ");
        direccion = Console.ReadLine(); 

        // Bucle para colocar tres números de teléfono
        for (int i = 0; i < 3; i++)

        // Lee cada número de teléfono y lo guarda
        {
            Console.Write($"Ingrese teléfono {i + 1}: ");
            telefonos[i] = Console.ReadLine(); 
        }

        // Impresión de los datos ingresados
        Console.WriteLine("\n--- Datos del Estudiante ---");
        Console.WriteLine("ID: " + id); 
        Console.WriteLine("Nombres: " + nombres); 
        Console.WriteLine("Apellidos: " + apellidos); 
        Console.WriteLine("Dirección: " + direccion); 
        
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < 3; i++)
        {
            // Muestra cada teléfono almacenado en el array
            Console.WriteLine($"Teléfono {i + 1}: {telefonos[i]}"); 
        }
    }
}
// Este programa permite registrar los datos de un estudiante, incluyendo su ID, nombres, apellidos, dirección y hasta tres números de teléfono.
// Utiliza un array para almacenar los números de teléfono, permitiendo una gestión sencilla de varias entradas.
// El programa imprime todos los datos ingresados al final, mostrando cómo se pueden manejar tanto variables individuales como arrays.

