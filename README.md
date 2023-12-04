# PushUpRazonamientoLogico
PushUp Razonamiento logico C# 04/12/2023


# Reto 1.1: Fibonacci

> Generar el número de secuencias fibonacci dado un número.

- ## Se Pide y asigna el número de secuencias deseadas:

  ```
  Console.WriteLine("Enter one Number :");
  int numFibo = int.Parse(Console.ReadLine());
  ```

- ## Se crean 3 variables para poder almacenar el número anterior y el actual para la secuencia en el for, despues de hacer las secuencias pedidas por el cliente se retorna el valor generado:

  ```
    int PrevVal = 1;
    int PrevNum = 0;
    int sumNum = 0;

    int PrevVal = 1;
        int PrevNum = 0;
        int sumNum = 0;
        for (int i = 1; i < numFibo; i++)
        {
            sumNum = PrevNum + PrevVal;
            PrevNum = PrevVal;
            PrevVal = sumNum;
        }
    return sumNum;
  ```

# Reto 1.2: Comprabar si es un número Fibonacci

> Comprobar si un número dado pro el usuario pertenece a la secuencia Fibonacci.

- ## Se Pide y asigna el número de secuencias deseadas:

  ```
    Console.WriteLine("Enter one Number :");
    int numFibo = int.Parse(Console.ReadLine());
  ```
- ## Se crean 3 variables para poder almacenar el número anterior y el actual para la secuencia en el while, se comprobara si el nímero dado pertecene a la secuencia fibonacci, en caso de ser así se retornara una respuesta positiva.

```        
    int PrevVal = 1;
    int PrevNum = 0;
    int sumNum = 0;

    while (sumNum <= numFibo)
        {
            if (sumNum == numFibo)
            {
                return $"El numero {numFibo} (SI) es un número Fibonnacci";
            }
            sumNum = PrevNum + PrevVal;
            PrevNum = PrevVal;
            PrevVal = sumNum;
        }
        return $"El numero {numFibo} (NO) es un número Fibonnacci";
  ```

# Reto 1.3: Lista de números Fibonacci

> dado un número por el usuario, generar la secuencia fibonacci hasta el rango seleccionado.

- ## en este ejercicio repetiremos lo 2 primeros pasos vistos en los anteriores ejercicios, solo que para este almacenaremos los números fibonacci para poder mostrarlos al usuario.

```        
string listNumFib = $"{PrevNum.ToString()}  |  {PrevVal.ToString()}";
        for (int i = 1; i < numFibo; i++)
        {
            sumNum = PrevNum + PrevVal;
            PrevNum = PrevVal;
            PrevVal = sumNum;
            listNumFib += $"  | {sumNum}";
        }
    Console.WriteLine($"Fibonacci number list: \n" + listNumFib);
  ```

# Reto 2: Multiplicación Rusa

> Crear un programa que reciba como entrada el multiplicador y el multiplicando, y muestre como resultado la suma de los valores del multiplicando.

- ## Se solicita al usuario el número Multiplicador y Multiplicando:

  ```
    Console.WriteLine("Enter Multiplicador Number :");
    int Multiplicador = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Multiplicando Number :");
    int Multiplicando = int.Parse(Console.ReadLine());
  ```

- ## Se realizará un ciclo while hasta que el valor de Multiplicador sea igual o mayor que 1, el valor del Multiplicador ira disminuyendo en cada ciclo debido a que se ira dividiendo sobre 2 en cada recorrido:

  > Se comprueba si el valor de multiplicador es impar, en caso de ser así se ira sumando este valor en cada ciclo, al igual se ira multiplicando * 2 el valor de Multiplicando.

  ```
   while (Multiplicador >= 1)
        {
            if (Multiplicador % 2 != 0)
            {
                Total += Multiplicando;
            }
            Multiplicador /= 2;
            Multiplicando *= 2;
        }
        Console.WriteLine($"Result: {Total}");

  ```
  > Al final se retornara el valor total de los números impares de Multiplicando.