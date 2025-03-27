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
    }
}