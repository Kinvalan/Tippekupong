namespace Tippekupong
{
    internal class Program
    {
        /*
        Skriv koden mer objektorientert. 

        1. Innfør en klasse Match som representerer en fotballkamp. 

        2. Hvilke felt (objektvariable) bør den ha? 

        3. Hva gjør applikasjonen med en fotballkamp? 

        4. Det siste(3) blir til metodene i klassen. 

        5. Det er ikke meningen å random generere kamputfall, med mindre man ønske å utfordre seg litt.  
        */

        static void Main(string[] args)
        {
            Betting();
        }

        static void Betting()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");

            var bet = Console.ReadLine();
            var match = new Match(bet!);

            while (match.IsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();

                if (command!.ToLower() == "x")
                { 
                    match.Stop();
                }
                
                else if (command.ToLower() == "h" || command.ToLower() == "b")
                {
                    match.AddGoal(command.ToLower() == "h");
                    Console.WriteLine($"Stillinga er {match.GetScore()}.");
                }
            }

            var isBetCorrect = match.IsBetCorrect() ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrect}");
        }
    }   
}               
            // GAMMEL KODE:
            //Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            //var bet = Console.ReadLine();
            //var homeGoals = 0;
            //var awayGoals = 0;
            //var matchIsRunning = true;
            //while (matchIsRunning)
            //{
            //    Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
            //    var command = Console.ReadLine();
            //    matchIsRunning = command != "X";
            //    if (command == "H") homeGoals++;
            //    else if (command == "B") awayGoals++;
            //    Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
            //}

            //var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            //var isBetCorrect = bet.Contains(result);
            //var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            //Console.WriteLine($"Du tippet {isBetCorrectText}");