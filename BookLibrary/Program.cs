namespace BookLibrary;

class Program
{
    static void Main(string[] args)
    {
        const string CommandAddBook = "1";
        const string CommandDeleteBook = "2";
        const string CommandFind = "3";
        const string CommandExit = "4";
        
        Library library = new Library();
        
        bool isActive = true;
        
        string input;

        while (isActive)
        {
            Console.Clear();
            Console.WriteLine("Библиотека\n");
            
            library.ShowAll();
            
            Console.WriteLine($"{CommandAddBook} - Добавить книгу");
            Console.WriteLine($"{CommandDeleteBook} - Убрать книгу");
            Console.WriteLine($"{CommandFind} - Найти по параметру");
            Console.WriteLine($"{CommandExit} - Выход\n");
            input = Console.ReadLine();

            switch (input)
            {
                case CommandAddBook:
                    library.AddBook();
                    break;
                case CommandDeleteBook:
                    library.RemoveBook();
                    break;
                case CommandFind:
                    library.FindBook();
                    break;
                case CommandExit:
                    isActive = false;
                    Console.WriteLine("\nПока! Ещё увидимся!\n");
                    break;
                default:
                    Console.WriteLine("Такой команды нет, попробуй ещё раз.\n");
                    break;
            }

            Console.ReadKey(true);
        }
    }
}