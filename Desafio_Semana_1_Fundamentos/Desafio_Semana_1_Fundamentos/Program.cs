string resposta;
List<int> numeros = new List<int>();
int num = 0;

do
{
    Console.WriteLine("Deseja adicionar um número? S/N");
    resposta = Console.ReadLine().ToUpper();
    if (resposta == "S" || resposta == "N")
    {
        if (resposta == "S")
        {
            Console.WriteLine("Número: ");
            num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }
        else
        {
        
            Console.WriteLine($"Sua lista de númeors é: ");
            foreach (var n in numeros)
            {
                Console.WriteLine(n);
    
            }

            Console.WriteLine($"A soma deles é: {numeros.Sum()}");
            Console.WriteLine($"A média deles é: {numeros.Average()}");
            Console.WriteLine($"O maior número é: {numeros.Max()}");
            Console.WriteLine($"O menor número é: {numeros.Min()}");

        }
    }
    else
    {
        Console.WriteLine("Valor inválido!!");
        Console.WriteLine("Digite uma resposta válida...");
        Console.WriteLine();
        Console.WriteLine("Deseja adicionar um número? S/N");
        resposta = Console.ReadLine().ToUpper();
    }
        
} while (resposta.ToUpper() == "S");