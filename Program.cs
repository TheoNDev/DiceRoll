namespace DiceRoll;

class Program
{
    private static readonly int _minNmb = 1;
    private static readonly int _maxNmb = 7;
    static int Dice => Random.Shared.Next(_minNmb, _maxNmb);
    private static bool _isRunning = true;
    static void Main()
    {
        Console.WriteLine("Välkommen till DiceRoll!");
        while (_isRunning)
        {
            try
            {
                Menu();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
    private static void Menu()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("Tryck 'p' för att kasta tärningarna");
        Console.WriteLine("Tryck 'x' för att avsluta programmet");
        Console.WriteLine("======================================");
        Actions();
    }
    private static void Actions()
    {
        string input = Console.ReadLine() ?? throw new Exception("Någon av meny alterantiven måste skickas in");

        switch (input)
        {
            case "p":
                ShowResult();
                break;
            case "x":
                Exit();
                break;
            default:
                throw new Exception("Någon av meny alterantiven måste skickas in");
        }
    }
    private static void ShowResult()
    {

        int diceOne = Dice;
        int diceTwo = Dice;

        Console.WriteLine($"Tärning 1: {diceOne}");
        Console.WriteLine($"Tärning 2: {diceTwo}");

        int sum = diceOne + diceTwo;

        if (sum == 12)
        {
            Console.WriteLine("Grattis 🥳 du har vunnit!");
        }
        else
        {
            Console.WriteLine("Tyvärr fick du inte 12 denna gång");
        }
        return;
    }
    private static void Exit()
    {
        Console.WriteLine("Avslutar program...");
        _isRunning = false;
        return;
    }
}
