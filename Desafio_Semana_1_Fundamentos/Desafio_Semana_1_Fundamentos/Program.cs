string resposta;
List<int> numeros = new List<int>();

do
{
    Console.WriteLine("Deseja adicionar um número? S/N");
    resposta = Console.ReadLine().ToUpper();
    if (resposta == "S" || resposta == "N")
    {
        if (resposta == "S")
        {
            Console.WriteLine("Número: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numero))            {
                
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Você precisa digitar um um valor numérico...");
            }
        }
        else
        {
        
            Console.WriteLine($"Sua lista de números é: ");
            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"A soma deles é: {numeros.Sum()}");
            Console.WriteLine($"A média deles é: {numeros.Average():F2}");
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