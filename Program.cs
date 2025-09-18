namespace vsR;

class Program
{
    static void Main(string[] args)
    {
        var rng = new Random();

        bool playAgain = true;
        while (playAgain)
        {
            int secnum = rng.Next(0, 101);
            bool guessed = false;

            while (guessed != true)
            {
                Console.Write("Hádej skryté číslo, zadej celé číslo od 0 do 100: ");

                string? input = Console.ReadLine();
                int numero = Convert.ToInt32(input);

                if (numero < secnum)
                {
                    Console.WriteLine("Zkus větší číslo");
                }
                else if (numero > secnum)
                {
                    Console.WriteLine("Zkus menší číslo");
                }
                else
                {
                    Console.WriteLine("Uhodnul si skryté číslo");
                    guessed = true;
                }

            }
            Console.WriteLine("Chceš hrát znovu? ano/ne");
            string? answer = Console.ReadLine();
            if (answer != "ano")
            {
                playAgain = false;
            }

        }
        Console.WriteLine("Konec hry");
    }
}
