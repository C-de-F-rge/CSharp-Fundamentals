using System;

namespace tiposdedatos;

class Program
{
    static void Main(string[] args)
    {
        /*========================
            TIPOS DE DATOS EN C#
        ========================*/

        /*Datos de tipo primitivo (de valor):
        Este tipo de variables son aquellas que almacenan un unico valor,
        su almacenamiento es de tipo stack, por lo cual funciona como un
        objeto de almacenamiento tipo LIFO(last in, first out) para facil
        flujo de datos de entrada y salida en la memoria RAM del sistema*/

        //...........................................................................
        //DATOS DE TIPO ENTERO

        //BYTE: |tamaño: 8 bits| rango: 0 a 255|
        byte edad = 25;
        //SBYTE: |tamaño: 8 bits| rango: -128 a 127|
        sbyte temperatura = -5;
        //SHORT: |tamaño: 2 bytes| rango: -32,768 a 32,767|
        short cantidad = -1000;
        //UNSHORT: |tamaño: 2 bytes| rango: 0 a 65,535|
        ushort cantidad2 = 1000;
        //INT: |tamaño: 4 bytes| rango: -2,147,483,648 a 2,147,483,647|
        int numero = -1000000;
        //UINT: |tamaño: 4 bytes| rango: 0 a 4,294,967,295|
        uint numero2 = 1000000;
        //LONG: |tamaño: 8 bytes| rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807|
        long numero3 = -1000000000000000000;
        //ULONG: |tamaño: 8 bytes| rango: 0 a 18,446,744,073,709,551,615|
        ulong numero4 = 1000000000000000000;

        //..........................................................................
        //DATOS DE TIPO DECIMAL

        //FLOAT: |tamaño: 4 bytes| rango: ±1.5 x 10^-45 a ±3.4 x 10^38|
        float presición_baja = 36.5f;
        //DOUBLE: |tamaño: 8 bytes| rango: ±5.0 x 10^-324 a ±1.7 x 10^308|
        double precisión_media = 1.7976931348623157E+308;
        //DECIMAL: |tamaño: 16 bytes| rango: ±1.0 x 10^-28 a ±7.9 x 10^28|
        decimal superpresición = 79228162514264337593543950335m;

        //..........................................................................
        //DATOS DE TIPO CARACTER

        //CHAR: |tamaño: 2 bytes| rango: Unicode|
        char caracter = 'a';
        char simbolo = '¿';

        //..........................................................................
        //DATOS DE TIPO BOOLEANO

        //BOOL: |tamaño: 1 byte| rango: true o false|
        bool verdadero = true;
        bool falso = false;

        /*Datos de Referencia(Reference types)
        Son valores que se componen de estructuras más complejas como 
        arreglos, objetos, etc. Manejan la memoria de tipo heap la cual
        consiste en un administrador de basuras y junto con dotnet gestiona
        los elementos que se eliminan y los que no en la memoria RAM*/

        //..........................................................................
        //DATOS DE TIPO CADENA
        //STRING: |tamaño: variable| rango: Unicode|
        string nombre = "Hola Mundo"; //NOTA: String es un arreglo de caracteres (char[])

        //..........................................................................
        //DATOS DE TIPO OBJETO
        //
        object objeto = 10; //NOTA: object es un tipo de dato que puede almacenar cualquier tipo de dato
        object objeto2 = "Hola Mundo";

        //..........................................................................    
        //DATOS DE TIPO ARREGLO
        //ARRAY: |tamaño: variable| rango: variable|
        int[] numeros = { 1, 2, 3, 4, 5 };
        string[] nombres = new string[3] { "Juan", "Pedro", "Luis" };

        //..........................................................................
        //DATOS DE TIPO DINÁMICO
        //DYNAMIC: |tamaño: variable| rango: variable|
        dynamic variable = 10; //NOTA: dynamic es un tipo de dato que puede almacenar cualquier tipo de dato
        variable = "Hola Mundo";
    }
}