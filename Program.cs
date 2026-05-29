int operacion, continuar = 0;
string opcion;

Console.WriteLine("***----- CALCULADORA BÁSICA -----***");

do
{
    Console.WriteLine("\nSuma = 1; Resta = 2; Multiplicar = 3; Dividir = 4");
    opcion = Console.ReadLine();

    if (!int.TryParse(opcion, out operacion))
    {
        Console.WriteLine("\nValor ingresado no válido");

    }else if (operacion > 4 || operacion < 1)
    {
        Console.WriteLine("\nEl numero ingresado no se encuentra dentro de las opciones dadas");
    
    }else
    {
        double num1, num2, resultado;

        Console.WriteLine("\nIngrese los numeros que desea calcular");
        Console.WriteLine("\nNumero 1: ");

        num1 = double.Parse(Console.ReadLine());
       do
       {
            Console.WriteLine("\nNumero 2: ");
            num2 = double.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"\n{num1} + {num2} = {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"\n{num1} - {num2} = {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"\n{num1} × {num2} = {resultado}");
                    break;

                case 4:
                    
                        if (num2 == 0)
                        {
                            Console.WriteLine("\nNo se puede dividir sobre 0. Ingrese un nuevo valor para el Numero2");
                            
                        }else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\n{num1} ÷ {num2} = {resultado}");
                        }
                    
                    break;
            }
       } while (operacion == 4 && num2 == 0);

        Console.WriteLine("\n¿Desea realizar otra operación?");
        
        Console.WriteLine("\n SÍ = 0; NO = 1");
        continuar = int.Parse(Console.ReadLine());

        if (continuar == 1)
        {
            Console.WriteLine("\n¡Hasta Pronto!");
        }
    }

} while (!int.TryParse(opcion, out operacion) || operacion > 4 || operacion < 1 || continuar == 0);

