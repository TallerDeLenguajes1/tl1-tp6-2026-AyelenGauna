// NÚMERO INVERTIDO

int numero, longitudNumero;
string textoNumero;
bool resultado;

Console.WriteLine("\n***----- NÚMERO INVERTIDO -----***");

do
{
    Console.WriteLine("\nIngrese un número mayor a 0");
    textoNumero = Console.ReadLine();

    resultado = int.TryParse(textoNumero, out numero); //se guarda en valor numérico en la variable "numero"

    if (resultado)
    {
        if (numero <= 0 )
        {
            Console.WriteLine("\nEl numero ingresado es menor o igual a 0");

        }else
        {
            //Obtengo la longitud del número ingresado
            longitudNumero = textoNumero.Length;
            string numeroInvertido = "";

            //Invierto el número ingresado
            for (int i = 0; i < longitudNumero; i++)
            {
                numeroInvertido = numeroInvertido + textoNumero[longitudNumero-1-i];
            }

            Console.WriteLine($"\nEl número invertido es: {numeroInvertido}");
        }

    }else
    {
        Console.WriteLine("\nEl texto ingresado NO es un número");
    }

} while (!resultado || numero <= 0);

// CADENA DE TEXTO

string cadena1;
int longCadena = 0, espacio = 0;

Console.WriteLine("\n***----- CADENA DE TEXTO -----***");

do
{
    Console.WriteLine("\nIngrese una cadena de texto:");
    cadena1 = Console.ReadLine();
    
    if (cadena1 != "")
    {
        longCadena = cadena1.Length;

        for (int i = 0; i < longCadena; i++)
        {
            if (cadena1[i] == ' ')
            {
                espacio ++;
            }
        }

        if (espacio == longCadena)
        {
            Console.WriteLine("\nPor favor ingrese una cadena de texto nuevamente");

        }else
        {
            Console.WriteLine($"\nLongitud de la cadena: {longCadena}");
            
        }

    }else
    {
        Console.WriteLine("\nNo se ha ingresado ninguna cadena de texto. Por favor intentelo de nuevo");
    }

} while (cadena1 == "" || longCadena == espacio);