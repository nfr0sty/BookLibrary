namespace BookLibrary;

public class Library
{
        private List<Book> _books = new List<Book>();
    
    public Library()
    {
        _books.Add(new Book("Гарри Поттер и философский камень", "Джоан Роулинг", "Фэнтези", 1997));
        _books.Add(new Book("Девушка с татуировкой дракона", "Стиг Ларссон", "Детектив", 2004));
        _books.Add(new Book("Ведьмак", "Анджей Сапковский", "Фэнтези", 1993));
    }

    public void ShowAll()
    {
        for (int i = 0; i < _books.Count; i++)
        {
            Console.WriteLine($"{i}) {_books[i].Author}: {_books[i].Title}, {_books[i].Year}, {_books[i].Genre}");
        }
    }
    
    public void AddBook()
    {
        string title;
        string author;
        string genre;
        
        int year;

        Console.Write("Введите название книги: ");
        title = Console.ReadLine();
        
        Console.Write("Введите автора книги: ");
        author = Console.ReadLine();
        
        Console.Write("Введите жанр: ");
        genre = Console.ReadLine();
        
        Console.Write("Введите год издания книги: ");
        year = ReadInt();
        
        _books.Add(new Book(title, author, genre, year));
        Console.Write("Книга добавлена.");
    }
    
    public void RemoveBook()
    {
        Console.Write("Введите номер книги для удаления: ");
        int input = ReadInt();
        
        if (input >= 0 && input < _books.Count)
        {
            _books.RemoveAt(input);
            Console.WriteLine("Книга удалена.");
        }
        else
        {
            Console.WriteLine("Книга с таким номером не найдена в базе.");
        }
    }

    public void FindBook()
    {
        const string CommandSearchByAuthor = "1";
        const string CommandSearchByTitle = "2";
        const string CommandSearchByYear = "3";
        const string CommandSearchByGanre = "4";
        
        bool isActive = true;
        
        string input;

        while (isActive)
        {
            Console.WriteLine($"{CommandSearchByAuthor} Поиск по автору");
            Console.WriteLine($"{CommandSearchByTitle} Поиск по названию");
            Console.WriteLine($"{CommandSearchByYear} Поиск по году издания");
            Console.WriteLine($"{CommandSearchByGanre} Поиск по жанру");
            
            Console.WriteLine("Для выхода нажми любую другую клавишу\n");
            input = Console.ReadLine();

            switch (input)
            {
                case CommandSearchByAuthor:
                    FindByAuthor();
                    break;
                case CommandSearchByTitle:
                    FindByTitle();
                    break;
                case CommandSearchByYear:
                    FindByYear();
                    break;
                case CommandSearchByGanre:
                    FindByGenre();
                    break;
                default:
                    Console.WriteLine("Выход из поиска.\n");
                    break;
            }
                
            isActive = false;
        }
    }

    private void FindByAuthor()
    {
        bool isFound = false;
        
        Console.WriteLine("\nВведите автора\n");
        string input = Console.ReadLine();

        foreach (Book book in _books)
        {
            if (book.Author.ToLower() == input.ToLower())
            {
                if (isFound == false)
                {
                    Console.WriteLine("\nРезультаты поиска\n");
                }
                
                book.ShowInfo();
                
                isFound = true;
            }
        }

        if (isFound == false)
        {
            Console.WriteLine("\nКнига от данного автора не найдена\n");
        }
    }

    private void FindByTitle()
    {
        bool isFound = false;
        
        Console.WriteLine("\nВведите название\n");
        string input = Console.ReadLine();

        foreach (Book book in _books)
        {
            if (book.Title.ToLower() == input.ToLower())
            {
                if (isFound == false)
                {
                    Console.WriteLine("\nРезультаты поиска\n");
                }
                
                book.ShowInfo();
                
                isFound = true;
            }
        }

        if (isFound == false)
        {
            Console.WriteLine("\nКнига с таким названием не найдена\n");
        }
    }

    private void FindByYear()
    {
        bool isFound = false;
        
        Console.WriteLine("\nВведите год\n");
        int input = ReadInt();

        foreach (Book book in _books)
        {
            if (book.Year == input)
            {
                if (isFound == false)
                {
                    Console.WriteLine("\nРезультаты поиска\n");
                }
                
                book.ShowInfo();
                
                isFound = true;
            }
        }

        if (isFound == false)
        {
            Console.WriteLine("\nКнига такого года выпуска не найдена\n");
        }
    }

    private void FindByGenre()
    {
        bool isFound = false;
        
        Console.WriteLine("\nВведите жанр\n");
        string input = Console.ReadLine();

        foreach (Book book in _books)
        {
            if (book.Genre.ToLower() == input.ToLower())
            {
                if (isFound == false)
                {
                    Console.WriteLine("\nРезультаты поиска\n");
                }
                
                book.ShowInfo();
                
                isFound = true;
            }
        }

        if (isFound == false)
        {
            Console.WriteLine("\nКнига с таким жанром не найдена\n");
        }
    }
    
    private int ReadInt()
    {
        int result;

        while (int.TryParse(Console.ReadLine(), out result) == false)
        {
            Console.WriteLine("Неверный ввод числа!\nНеобходимо ввести целое число.");
            Console.Write("Введите целое число: ");
        }

        return result;
    }
}