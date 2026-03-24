/*Ref (5 pontos)
– Faça um programa que verifique se uma letra digitada é vogal ou consoante
Nome: Eluara Andrade
*/


public static class AtividadeDois
{
    public static void Executar()
    {
       string letra;

       Console.WriteLine("Digite a letra para análise: ");
       letra = Console.ReadLine()!.ToLower();

       if (letra == "a" || letra == "e" || letra == "i" || letra == "o"|| letra == "u")
        {
            Console.WriteLine($"A letra é uma vogal");
        }

       else
        {
            Console.WriteLine($"A letra é uma consoante");
        }


    }  
    
}