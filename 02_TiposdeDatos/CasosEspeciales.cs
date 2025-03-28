using System;

namespace CasosEspeciales;

class CasosEspeciales
{
    static void Main(string[] args)
    {
        /*==============================
                DYNAMIC VS VAR
        ================================*/
        dynamic dato1 = 10;
        dato1 = "Hola Mundo";

        var dato2 = 10;
        var dato3 = "Hola Mundo";
        //dato2 = "Hola Mundo"; // Error de compilación
        //dato3 = 10; // Error de compilación

        /*Dynamic permite almacenar cualquier tipo de dato en las variables que este crea
            mientras que Var solamente nos permite crear variables que puedan almacenar un
            tipo de dato especifico sin especificar tipo*/

        /*==============================
                Arrays Simples 
        ================================*/
        //Protección de memoria RAM Hibrida
        string[] usuarios = new string[3]; //Limita la cantidad de memoria disponible para la variable de tipo arreglo
        string[] usuarios;
    }
}