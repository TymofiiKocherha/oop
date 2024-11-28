using System.Text.Json;

public class Program
{
    public static async Task Main(string[] args)
    {
        string path = "./file.json";

        string json = await File.ReadAllTextAsync(path);

        List<Book> books;

        if (json == null)
        {
            Console.WriteLine("Error: file is empty.");
            return;
        }
        else
        {
            books = JsonSerializer.Deserialize<List<Book>>(json);
        }
                
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.PublishingHouseId}, Publisher: {book.PublishingHouse.Name}");
        }
    }
}