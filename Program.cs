public class Program
{
    public static void Main()
    {
        string[] options = { "ROCK", "PAPER", "SCISSORS" };
        int playerScore = 0, cpuScore = 0;

        while (true)
        {
            Console.WriteLine("Bittasini kiriting: ROCK, PAPER yoki SCISSORS");
            string playerChoice = Console.ReadLine()!.ToUpper();

            if (!Array.Exists(options, element => element == playerChoice))
            {
                Console.WriteLine("Kiritgan tanlovingiz noto'g'ri.");
                continue;
            }

            Random rand = new Random();
            string cpuChoice = options[rand.Next(options.Length)];

            Console.WriteLine($"AI tanlovi: {cpuChoice}");

            if (playerChoice == cpuChoice)
            {
                Console.WriteLine("Durang!");
            }
            else if ((playerChoice == "ROCK" && cpuChoice == "SCISSORS") ||
                     (playerChoice == "PAPER" && cpuChoice == "ROCK") ||
                     (playerChoice == "SCISSORS" && cpuChoice == "PAPER"))
            {
                Console.WriteLine("Siz yutdingiz!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("AI yutdi!");
                cpuScore++;
            }

            Console.WriteLine($"Hisob: Siz {playerScore} - {cpuScore} AI");

            if (playerScore == 3)
            {
                Console.WriteLine("Player WON!");
                break;
            }
            else if (cpuScore == 3)
            {
                Console.WriteLine("CPU WON!");
                break;
            }

            bool PlayAgain = true;

            while (PlayAgain)
            {
                Console.WriteLine("O'yinni davom ettirish uchun ENTER bosing yoki 'n' tugmasini bosib chiqib keting.");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    PlayAgain = false;
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {
                    PlayAgain = true;
                    Console.WriteLine("\nDasturdan chiqilmoqda...");
                    return;
                }
                else
                {
                    Console.WriteLine("Xato! Siz faqat ENTER yoki 'n' tugmasini kiritishingiz mumkin.");
                }
            }

        }
    }
}