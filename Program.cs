namespace Mzda;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Výpočet čisté mzdy (2023) ===");
        Console.Write("Zadejte hrubou mzdu (Kč): ");
        decimal hrubaMzda = Convert.ToDecimal(Console.ReadLine());

        decimal zdravotniPojisteni = hrubaMzda * 0.045m;  
        decimal socialniPojisteni = hrubaMzda * 0.075m;   

        decimal superhrubaMzda = hrubaMzda * 1.338m; 

        decimal danPredSlevou = superhrubaMzda * 0.15m;

        decimal slevaNaPoplatnika = 2570m;
        
        decimal danPoSleve = danPredSlevou - slevaNaPoplatnika;
        if (danPoSleve < 0) danPoSleve = 0;

        decimal cistaMzda = hrubaMzda - zdravotniPojisteni - socialniPojisteni - danPoSleve;

        Console.WriteLine("\n--- Výsledek ---");
        Console.WriteLine($"Hrubá mzda: {hrubaMzda:N0} Kč");
        Console.WriteLine($"Zdravotní pojištění: {zdravotniPojisteni:N0} Kč");
        Console.WriteLine($"Sociální pojištění: {socialniPojisteni:N0} Kč");
        Console.WriteLine($"Daň před slevou: {danPredSlevou:N0} Kč");
        Console.WriteLine($"Sleva na poplatníka: {slevaNaPoplatnika:N0} Kč");
        Console.WriteLine($"Daň po slevě: {danPoSleve:N0} Kč");
        Console.WriteLine($"Čistá mzda: {cistaMzda:N0} Kč");
    }
}

