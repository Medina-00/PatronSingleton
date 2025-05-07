using System; // Importa el espacio de nombres para funcionalidades básicas de C#
using System.Collections.Generic; // Permite trabajar con listas y colecciones

namespace PatronSingleton // Define el espacio de nombres para organizar el código
{
    // Clase Singleton: Solo se puede crear una instancia de esta clase en toda la aplicación.
    public class Singleton
    {
        private static Singleton instance = null; // Variable estática que almacena la única instancia del Singleton.

        private List<string> productos; // Lista privada que almacenará los productos.

        // Constructor privado: Evita que se creen instancias de la clase desde fuera.
        private Singleton()
        {
            productos = new List<string>(); // Inicializa la lista vacía cuando se crea la instancia.
        }

        // Propiedad estática para acceder a la única instancia del Singleton.
        public static Singleton Instance
        {
            get
            {
                    return instance ??= new Singleton(); // Si la instancia es nula, la crea; si ya existe, la devuelve.
                
            }
        }
        

        // Método público para agregar un producto a la lista.
        public void AgregarProducto(string producto)
        {
            productos.Add(producto); // Agrega el producto recibido a la lista.
        }

        // Método público para obtener todos los productos almacenados.
        public List<string> ObtenerProductos()
        {
            return productos; // Retorna la lista de productos.
        }
    }
}
