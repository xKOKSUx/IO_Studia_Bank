
using Bank.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var fileManagement = new FileManagement();
        fileManagement.CreateFile();

        Display.Logo();
        Display.MainMenu();
    }
}