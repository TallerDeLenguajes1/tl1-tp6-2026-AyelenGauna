// NÚMERO INVERTIDO

int numero, longitudNumero;
string textoNumero;
bool resultado;

do
{
    Console.WriteLine("Ingrese un número mayor a 0");
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
        Console.WriteLine("\nEl texto ingresado NO es un numero\n");
    }

} while (!resultado || numero <= 0);

