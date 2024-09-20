
int tan = 10;
int sumaPar = 0;

int sumaImpar = 0;
int[] numeros = new int[tan];
Console.WriteLine("Digite los datos del arreglo: ");
Console.WriteLine();
for (int i = 0; i < tan; i++)
{
    Console.WriteLine("Ingresa un numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    if (numeros[i] % 2 == 0)
    {
            sumaPar += numeros[i];
    }else  sumaImpar += numeros[i];
    
}

Console.WriteLine();
Console.WriteLine("Datos del arreglo");
Console.WriteLine();
for (int i = 0; i < tan; i++)
{
   Console.Write(numeros[i] + ", "); 
}
Console.WriteLine();
Console.WriteLine($"La suma de los pares es: {sumaPar}");
Console.WriteLine($"La suma de los numeros impares es {sumaImpar}");

Console.ReadKey();
