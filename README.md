# 🔹 Que es el Patrón Singleton en C#?

es un patrón creacional que asegura que una clase tenga una única instancia y proporciona un punto de acceso global a ella. Se usa comúnmente cuando se necesita controlar el acceso a recursos compartidos, como una conexión a base de datos o un archivo de configuración.
Características clave:

Instancia única: solo se crea una vez durante la vida del programa.

Acceso global: la instancia se accede mediante un método estático, como getInstance().

Controlado internamente: el constructor es privado o protegido para evitar nuevas instancias externas.

## 📌 Descripción
Este proyecto implementa el **Patrón Singleton en C#** para gestionar una lista de productos en memoria.  
La clase `Singleton` asegura que solo exista **una única instancia** durante la ejecución de la aplicación,  
permitiendo **agregar y visualizar productos sin necesidad de una base de datos**.

## 🚀 Características
✔ **Implementación del Patrón Singleton** con control de concurrencia (`lock`).  
✔ **Almacenamiento de productos en memoria** sin perder la información durante la ejecución.  
✔ **Menú interactivo en consola**, con opciones para agregar y ver los productos guardados.  


