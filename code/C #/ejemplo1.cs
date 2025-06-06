public class ejemplo1
{
    public static void Main()
    {
        int opcion;
        double repetir;
        do
        {
            Console.WriteLine("Ejercicios varios");
            Console.WriteLine("1) Calculo del iva");
            Console.WriteLine("2) Tabla con los 3 siclos");
            Console.WriteLine("3) Numeros a la N")
            Console.WriteLine("4) Mayor o menor");
            Console.WriteLine("5) Par o impar");
            Console.WriteLine("6) Falseda");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case| 1:
                    double precio, iva;
                    Console.WriteLine("Digite el precio");

                    precio = double.Parse(Console.ReadLine());

                    double.Parse(Console.ReadLine());

                    iva = 0.15;

                    double ivaCalculado;
                    ivaCalculado = precio * iva;

                    double precioFinal;
                    precioFinal = precio * ivaCalculado;

                    Console.WriteLine($"Total a pagar;{precioFinal}");
                    break;

                case 2:
                    int numero, cont1, cont2;
                    Console.WriteLine("Ingrese el numero");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ciclo for");
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine(numero + " X " + i + " = " + (numero * i));
                    }
                    cont1 = 1;
                    Console.WriteLine("Ciclo WHILE");
                    while (cont1 <= 10)
                    {
                        Console.WriteLine(numero + " X " + cont1 + " = " + (numero * cont1));
                        cont1++;
                    }
                    Console.WriteLine("Ciclo Do-While");
                    cont2 = 1;
                    do
                    {
                        Console.WriteLine(numero + " X " + cont2 + " = " + (numero * cont2));
                        cont2++;
                    } while (cont2 <= 10);

                    break;

                case 3:
                    double base, potencia, resultado;
                    Console.WriteLine("Digite la base");
                    base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la potencia");
                    potencia = int.Parse(Console.ReadLine());
                    resultado = Math.Pow(base, potencia);
                    Console.WriteLine(base + "elevado a " + potencia + "=" + resultado);
                    break;
                case 4:
                    Console.WriteLine("Digite el primer numero");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Son iguales?" + (x == y));
                    Console.WriteLine("El primero es mayor?" + (x > y));
                    Console.WriteLine("El segundo es mayor?" + (x < y));
                    break;
                
                case 5:
                    Console.WriteLine("Digite un numero");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("El numero " + num + " es par");
                    }
                    else
                    {
                        Console.WriteLine("El numero " + num + " es impar");
                    }
                    break; 

                case 6:
                    Console.WriteLine("Digite el primer numero");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el segundo numero");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num1==2 && num2==2)
                    {
                        res = 5;
                    }
                    else
                    {
                        res = num1 + num2;
                    }

                    Console.WriteLine("La suma es:" + res);
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.WriteLine("Desea repetir el ejercicio? SI/NO");
            repetir = Console.ReadLine();
        } while (repetir == "SI");
    }

    
}