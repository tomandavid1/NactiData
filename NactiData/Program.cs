namespace NactiData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vypocet vypocet = new Vypocet();

            // Životní cyklus programu
            while (true)
            {
                // Logika zpracování vstupů společně s validací
                Console.WriteLine("Zadejte tři čísla: ");
                double a = ValidaceVstupu();
                double b = ValidaceVstupu();
                double c = ValidaceVstupu();

                // Výpis operací
                Console.WriteLine("Součet čísel: " + vypocet.SoucetCisel(a, b, c));
                Console.WriteLine("Součin čísel: " + vypocet.SoucinCisel(a, b, c));
                Console.WriteLine("Součet prvních dvou čísel dělený třetím: " + vypocet.VlastniOperaceCisel(a, b, c));
                Console.WriteLine("\nChcete spustit další výpočet? (ano/ne)");
                
                // Dotaz na opakování životního cyklu
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "ano")
                    break;
                Console.Clear();
            }

            double ValidaceVstupu()
            {
                double vystup;
                bool validniVstup = false;
                do
                {
                    string vstup = Console.ReadLine().Trim();

                    if (!double.TryParse(vstup, out vystup) || string.IsNullOrEmpty(vstup))
                        Console.WriteLine("Toto není platné číslo! Opakujte vstup");
                    else
                        validniVstup = true;
                } 
                while (!validniVstup);

                return vystup;

            }
        }
    }
}