
namespace Bank.Services;

public static class Display
{
    public static void Logo()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" _______ _            ____              _    ");
        Console.WriteLine("|__   __| |          |  _ \\            | |   ");
        Console.WriteLine("   | |  | |__   ___  | |_) | __ _ _ __ | | __");
        Console.WriteLine("   | |  | '_ \\ / _ \\ |  _ < / _` | '_ \\| |/ /");
        Console.WriteLine("   | |  | | | |  __/ | |_) | (_| | | | |   < ");
        Console.WriteLine("   |_|  |_| |_|\\___| |____/ \\__,_|_| |_|_|\\_\\");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void MainMenu()
    {
        Console.Clear();
        Logo();
        Console.WriteLine();
        Console.WriteLine(">>> Menu główne <<<");
        Console.WriteLine();
        Console.WriteLine("1. Wykonaj transakcję");
        Console.WriteLine("2. Wyświetl historię transakcji");
        Console.WriteLine("3. Ustawienia");
        Console.WriteLine("4. Wyjście");
        Console.WriteLine();
        Console.Write("Wybierz opcję: ");
    }

    public static void Settings()
    {
        Console.Clear();
        Logo();
        Console.WriteLine();
        Console.WriteLine(">>> Ustawienia <<<");
        Console.WriteLine();
        Console.WriteLine("1. Przełącz użytkownika");
        Console.WriteLine("2. Powrót do menu głównego");
        Console.WriteLine();
        Console.Write("Wybierz opcję: ");
    }
}