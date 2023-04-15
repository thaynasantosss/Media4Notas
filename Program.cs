double nota1, nota2, nota3, nota4, media;
string resultado;

Console.WriteLine("*** MÉDIA DE QUATRO NOTAS ***");

Console.WriteLine("Digite o nota #1:");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o nota #2:");
nota2= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o nota #3:");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o nota #4:");
nota4 = Convert.ToDouble(Console.ReadLine());

bool todasAsNotasSaoValidas = nota1 >= 0 && nota1 <= 10
                            && nota2 >= 0 && nota2 <= 10
                            && nota3 >= 0 && nota3 <= 10 
                            && nota4 >= 0 && nota4 <= 10;

if (todasAsNotasSaoValidas)
{

media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media< 5)
{
    resultado = "REPROVADO";
}
else if (media> 6)
{
    resultado = "APROVADO";
}
else
{
    resultado = "Em recuperação";
}


Console.WriteLine($"Você ficou com a média de {media:N1}. Resultado: {resultado}");
}
else
{
Console.WriteLine("Digite somente notas entre 0 e 10.");
}
