
using System.Text.Json;
namespace Bank.Services;

public class FileManagement
{
    private static string ConfigPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "config.json");
    public static string TransactionsPath => Path.Combine(ConfigPath, "transactions.json");

    public void CreateFile()
    {
        try
        {
            if (!File.Exists(ConfigPath))
            {
                var defaultConfig = new { MonthBudget = 0, Payday = 1 };
                string configJson = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ConfigPath, configJson);
                Console.WriteLine("Utworzono plik config.json z domyślnymi wartościami.");
            }
            else
            {
                Console.WriteLine("Plik config.json już istnieje.");
            }

            if (!File.Exists(TransactionsPath))
            {
                File.WriteAllText(TransactionsPath, "[]");
                Console.WriteLine("Utworzono plik transactions.json.");
            }
            else
            {
                Console.WriteLine("Plik transactions.json już istnieje.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas tworzenia plików: {ex.Message}");
        }
    }

    public void SaveToFile(string path, object data)
    {
        string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, jsonData);
    }

    public T? ReadFromFile<T>(string path)
    {
        string jsonData = File.ReadAllText(path);
        return JsonSerializer.Deserialize<T>(jsonData);
    }

    public void DeleteFile()
    {
        if (File.Exists(ConfigPath)) File.Delete(ConfigPath);
        if (File.Exists(TransactionsPath)) File.Delete(TransactionsPath);
        Console.WriteLine("Pliki zostały usunięte.");
    }

    public void ExitProcedure()
    {
        Console.WriteLine("Program zostanie zamknięty");
        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();

        Environment.Exit(0);
    }
}