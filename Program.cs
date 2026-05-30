int operacion, continuar = 0;
string opcion;
double num1, resultado;

Console.WriteLine("***----- CALCULADORA MEJORADA -----***");

do
{
    Console.WriteLine("\n  OPERACIONES BÁSICAS:\nSuma = 1; Resta = 2; Multiplicar = 3; Dividir = 4");
    Console.WriteLine("\n  OPERACIONES AVANZADAS:\nValor absoluto = 5; Cuadrado = 6; Raiz cuadrada = 7; Seno = 8; Coseno = 9; Parte entera de un tipo float = 0");
    
    Console.WriteLine("\nIngrese la opción que desea realizar:");
    opcion = Console.ReadLine();

    if (!int.TryParse(opcion, out operacion))
    {
        Console.WriteLine("\nValor ingresado no válido");

    }else if (operacion > 9 || operacion < 0)
    {
        Console.WriteLine("\nEl numero ingresado no se encuentra dentro de las opciones dadas");
    
    }else if (operacion >= 1 && operacion <= 4)
    {
        double num2;

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

    }else
    {
        Console.WriteLine("\nIngrese el numero que desea calcular");

        do
        {
            Console.WriteLine("\nNumero 1: ");

        num1 = double.Parse(Console.ReadLine());

        switch (operacion)
        {
            case 0:
                resultado = Math.Truncate(num1);
                Console.WriteLine($"\n{num1} = {resultado}");
                break;

            case 5:
                resultado = Math.Abs(num1); 
                Console.WriteLine($"\n|{num1}| = {resultado}");
                break;

            case 6:
                resultado = Math.Pow(num1, 2); 
                Console.WriteLine($"\n{num1}² = {resultado}");
                break;

            case 7:
                if (num1 < 0)
                {
                    Console.WriteLine("\nEl numero debe ser mayor o igual a 0. Ingrese un nuevo valor");
                }
                else
                {
                    resultado = Math.Sqrt(num1); 
                    Console.WriteLine($"\n{num1}½ = {resultado}");
                }
                break;

            case 8:
                resultado = Math.Sin(num1); 
                Console.WriteLine($"\nsen({num1}) = {resultado}");
                break;

            case 9:
                resultado = Math.Cos(num1); 
                Console.WriteLine($"\ncos({num1}) = {resultado}");
                break;
            
        }
        } while (operacion == 7 && num1 < 0);
    }

    if (!(operacion > 9 || operacion < 0))
    {
        Console.WriteLine("\n¿Desea realizar otra operación?");
        
        Console.WriteLine("\n SÍ = 0; NO = 1");
        continuar = int.Parse(Console.ReadLine());

        if (continuar == 1)
        {
            Console.WriteLine("\n¡Hasta Pronto!");
        }
    }


} while ((!int.TryParse(opcion, out operacion) || operacion > 9 || operacion < 0) && continuar == 0);