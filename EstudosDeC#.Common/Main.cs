
Console.WriteLine("========CRIANDO E PERCORRENDO ARRAY========");

int[] numBer = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int i in numBer)
{
    Console.WriteLine(i);
}
Console.WriteLine("========REDIMENSIONANDO ARRAY E PREENCHENDO ========");

Array.Resize(ref numBer, 11);
numBer[10] = 11;

for (int i = 0; i < numBer.Length; i++)
{
    Console.WriteLine(numBer[i]);
}

Console.WriteLine("========COPIANDO ARRAY E PREENCHENDO ========");

int[] numBerCopiado = new int[numBer.Length * 2];
Array.Copy(numBer, numBerCopiado, numBer.Length);

numBerCopiado[10] = 11;
numBerCopiado[11] = 12;
numBerCopiado[12] = 13;
numBerCopiado[13] = 14;
numBerCopiado[14] = 15;

foreach (int i in numBerCopiado)
{
    Console.WriteLine(i);
}