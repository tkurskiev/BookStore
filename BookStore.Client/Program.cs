// See https://aka.ms/new-console-template for more information

using BookStore.Client;

var books = Constants.Books;

var random = new Random();
foreach (var book in books)
{
    var yearString = book.PublicationDateString;
    var year = int.Parse(yearString);

    var randomDay = random.Next(1, 28);
    var randomMonth = random.Next(1, 12);

    var date = new DateTime(year, randomMonth, randomDay);

    book.PublicationDate = date;

    //Console.OutputEncoding = System.Text.Encoding.Unicode;
    //Console.WriteLine(book);

    book.Author = book.Author.Replace("'", "''");
    book.Title = book.Title.Replace("'", "''");

    File.AppendAllLines($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\test.txt",
        new[] { book.ToString() });
}


