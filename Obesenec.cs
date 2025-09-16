namespace obesenec;

        class Obesenec
{
    static void Main(string[] args)
    {
        bool hratZnovu = false;

        while (!hratZnovu)
        {
            string[] slova = { "auto", "obesenec", "fotbal", "bmw" };
            Random rnd = new Random();
            string scrtSlovo = slova[rnd.Next(slova.Length)].ToUpper();

            char[] guessed = new string('_', scrtSlovo.Length).ToCharArray();
            List<char> spatneTipy = new List<char>();
            int maxPokusy = 10;
            int zbyvajiciPokusy = maxPokusy;

            bool vyhra = false;

            while (zbyvajiciPokusy > 0 && !vyhra)
            {
                Console.Clear();
                Console.WriteLine("HRA OBESENEC");
                Console.WriteLine("------------");
                Console.WriteLine("Slovo: " + new string(guessed));
                Console.WriteLine("Špatné pokusy: " + string.Join(",", spatneTipy));
                Console.WriteLine("Zbyvajici pokusy: " + zbyvajiciPokusy);
                Console.WriteLine("Zadej písmeno: ");

                string? input = Console.ReadLine();
                if (input == null)
                {
                    input = "";
                }
                input = input.ToUpper();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Zadej prosím jedno písmeno.");
                    Console.ReadKey();
                    continue;
                }

                char pismeno = input[0];

                if (scrtSlovo.Contains(pismeno))
                {
                    for (int i = 0; i < scrtSlovo.Length; i++)
                    {
                        if (scrtSlovo[i] == pismeno)
                        {
                            guessed[i] = pismeno;
                        }
                    }
                }
                else
                {
                    if (!spatneTipy.Contains(pismeno))
                    {
                        spatneTipy.Add(pismeno);
                        zbyvajiciPokusy--;
                    }
                }

                if (!new string(guessed).Contains('_'))
                {
                    vyhra = true;
                }
            }

            Console.Clear();
            if (vyhra)
            {
                Console.WriteLine("Gratuluji! Uhodl jsi slovo: " + scrtSlovo);
            }
            else
            {
                Console.WriteLine("Prohrál jsi. Hledané slovo bylo: " + scrtSlovo);
            }

            Console.WriteLine("Chceš hrát znovu? ano/ne");
            string? odpoved = Console.ReadLine();
            if (odpoved == null)
            {
                odpoved = "";
            }
            odpoved = odpoved.ToUpper();
            hratZnovu = (odpoved == "ano");
        }
    }

}
