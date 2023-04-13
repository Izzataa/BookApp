using BookApp.App.Services;
using BookApp.Core.Models;

    BookService bookService = new BookService();
do
{
    
    Console.WriteLine("=====Welcome Book Create======\n");
    Console.WriteLine("0.Close app");
    Console.WriteLine("1.Book list:");
    Console.WriteLine("2.Book add:");
    string choose = Console.ReadLine();
    int chooseNum;
    while (!int.TryParse(choose, out chooseNum) || chooseNum < 0 || chooseNum > 2)
    {
        Console.WriteLine("choose correctly:");
        int.TryParse(choose=Console.ReadLine(), out chooseNum);
    }

    switch (chooseNum)
    {
        case 0:
            return;
        case 1:
            ShowBook(ref bookService);
            break;
        case 2:

            Addbook(ref bookService);
            break;
    }
} while (true);


static void Addbook(ref BookService bookService)
{
    Console.WriteLine("input name");
    string ChoseBookname = Console.ReadLine();
    while ((ChoseBookname) ==null)
    {
        Console.WriteLine("choose correctly:");
        ChoseBookname = Console.ReadLine();
    }
    Console.WriteLine("input price");
    string ChoseBookprice=Console.ReadLine();
    double price;
    double.TryParse(ChoseBookprice, out price);
    while ((ChoseBookprice) == null)
    {
        Console.WriteLine("choose correctly:");
        double.TryParse(ChoseBookprice=Console.ReadLine(), out price);
    }
    bookService.CreateBook(ChoseBookname, price);
}
static void ShowBook(ref BookService bookService)
{
    bookService.ShowBooks();
}