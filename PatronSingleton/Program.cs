using PatronSingleton; // Importa el espacio de nombres donde está la clase Singleton

int opc = 0; // Variable que almacena la opción del usuario

// Bucle `do-while` que repite el menú hasta que el usuario elija salir
do
{
    // Muestra las opciones disponibles en pantalla
    Console.Write(@"    
        1. AGREGAR PRODUCTOS 
        2. VER PRODUCTOS
        3. SALIR

        QUE DESEAS REALIZAR:
    ");

    // Captura la opción ingresada por el usuario
    opc = Convert.ToInt16(Console.ReadLine());

    // Evalúa la opción ingresada usando `switch`
    switch (opc)
    {
        case 1: // Opción para agregar productos
            Console.Write("INGRESE EL NOMBRE DEL PRODUCTO : "); // Solicita el nombre del producto
            string producto = Console.ReadLine(); // Guarda la entrada del usuario
            Singleton.Instance.AgregarProducto(producto!); // Agrega el producto al Singleton
            break;

        case 2: // Opción para mostrar los productos guardados
            var listado = Singleton.Instance.ObtenerProductos(); // Obtiene la lista de productos
            foreach (var item in listado) // Recorre cada producto en la lista
            {
                Console.WriteLine($"PRODUCTO - {item}"); // Muestra cada producto en pantalla
            }
            break;
    }

    // El bucle se repite **hasta que el usuario ingrese "3"**, lo que hace que el programa termine
} while (opc != 3);
