/*========================
    TIPOS DE DATOS EN C#
========================*/

/* En C#, los tipos de datos se dividen en dos categorías principales: 
 * - Tipos de valor (primitivos): Se almacenan en la pila (stack), 
 *   que es una estructura de datos tipo LIFO (Last In, First Out). 
 *   Estos tipos contienen directamente sus valores en la memoria. 
 * - Tipos de referencia: Se almacenan en el montón (heap). En la pila 
 *   solo se almacena una referencia a su ubicación en el heap. 
 *   Estos tipos pueden ser más complejos y permiten una mayor flexibilidad 
 *   en la gestión de memoria, pero requieren el recolector de basura (GC) 
 *   para su administración. */

/*========================
    TIPOS DE VALOR
========================*/

/* Los tipos de valor almacenan directamente sus datos en la memoria de la pila (stack). 
 * Esto hace que sean más rápidos en acceso y manejo, ya que su ciclo de vida es corto 
 * y su almacenamiento sigue el esquema LIFO (Last In, First Out). 
 * 
 * Estos tipos incluyen:
 * - Números enteros: byte, short, int, long
 * - Números de punto flotante: float, double, decimal
 * - Booleanos: bool (true o false)
 * - Caracteres: char
 * - Enumeraciones (enum)
 * - Estructuras (struct) */


/*========================
    TIPOS DE REFERENCIA
========================*/

/* Los tipos de referencia en C# almacenan sus datos en el montón (heap), 
 * mientras que la variable en la pila (stack) solo almacena una referencia 
 * a la ubicación del objeto en la memoria. 

 * Esto significa que cuando asignamos un objeto de referencia a otra variable, 
 * ambas variables apuntan al mismo objeto en memoria. Cualquier cambio realizado 
 * en una variable afectará al mismo objeto, reflejándose en todas las referencias. 

 * Los tipos de referencia incluyen:
 * - Clases (class)
 * - Interfaces (interface)
 * - Delegados (delegate)
 * - Arreglos (array)
 * - Cadenas de texto (string) (aunque son inmutables)
 * 
 * Debido a que los objetos en el heap no se eliminan automáticamente cuando 
 * dejan de ser utilizados, C# emplea un recolector de basura (Garbage Collector) 
 * que libera memoria automáticamente cuando detecta que un objeto ya no tiene 
 * referencias activas. */



using System;

namespace TiposDeDatos
{
    //========================
    // TIPOS DE DATOS EN C#
    //========================

    // TIPOS DE VALOR (Primitivos)
    enum Colores { Rojo, Verde, Azul }

    struct Persona
    {
        public string nombre;
        public int edad;
    }

    class TiposDeDatos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TIPOS DE DATOS EN C# ===\n");

            //========================
            // TIPOS PRIMITIVOS (VALOR)
            //========================

            // Enteros
            byte edad = 25;       // 8 bits (0 a 255)
            sbyte temperatura = -5;  // 8 bits (-128 a 127)
            short cantidad = -1000;  // 16 bits (-32,768 a 32,767)
            ushort cantidad2 = 1000; // 16 bits (0 a 65,535)
            int numero = -1000000;   // 32 bits (-2,147,483,648 a 2,147,483,647)
            uint numero2 = 1000000;  // 32 bits (0 a 4,294,967,295)
            long numero3 = -1000000000000000000; // 64 bits
            ulong numero4 = 1000000000000000000; // 64 bits sin signo

            // Decimales
            float presicionBaja = 36.5f; // 4 bytes
            double precisionMedia = 1.7976931348623157E+308; // 8 bytes
            decimal superPrecision = 79228162514264337593543950335m; // 16 bytes

            // Caracter
            char caracter = 'a';
            char simbolo = '¿';

            // Booleanos
            bool verdadero = true;
            bool falso = false;

            // Enumeraciones
            Colores color = Colores.Verde;

            // Estructuras
            Persona persona = new Persona { nombre = "Juan", edad = 25 };

            // Tuplas
            (string, int) tupla = ("Juan", 25);

            // Fechas
            DateTime fecha = DateTime.Now;
            DateTimeOffset fecha2 = DateTimeOffset.Now;

            //========================
            // TIPOS DE REFERENCIA
            //========================

            // Cadenas de texto
            string nombre = "Hola Mundo"; // Es un array de caracteres

            // Objeto genérico
            object objeto = 10;
            object objeto2 = "Hola Mundo";

            // Arreglos
            int[] numeros = { 1, 2, 3, 4, 5 };
            string[] nombres = new string[3] { "Juan", "Pedro", "Luis" };

            // Dynamic (puede cambiar de tipo en tiempo de ejecución)
            dynamic variable2 = 10;
            variable2 = "Hola Mundo";

            //========================
            // TIPOS MÁS COMPLEJOS
            //========================

            // Clase
            Persona2 persona3 = new Persona2 { nombre = "Juan", edad = 25 };

            // Interfaz e implementación
            Perro perro = new Perro();
            perro.Comer();

            // Delegado
            Saludar saludar = new Saludar(Saludos.Saludar2);
            saludar("Juan");

            // Eventos
            Eventos eventos = new Eventos();
            eventos.AlPresionarBoton += (sender, e) => Console.WriteLine("Se ha presionado el botón");
            eventos.PresionarBoton();
        }
    }

    // Clase para demostrar el uso de clases
    class Persona2
    {
        public string nombre;
        public int edad;
    }

    // Interfaz y clase que la implementa
    interface IAnimal
    {
        void Comer();
    }

    class Perro : IAnimal
    {
        public void Comer()
        {
            Console.WriteLine("El perro come");
        }
    }

    // Delegado y clase para saludar
    delegate void Saludar(string nombre);

    class Saludos
    {
        public static void Saludar2(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
    }

    // Clase para manejar eventos
    class Eventos
    {
        public event EventHandler AlPresionarBoton;

        public void PresionarBoton()
        {
            AlPresionarBoton?.Invoke(this, EventArgs.Empty);
        }
    }
}