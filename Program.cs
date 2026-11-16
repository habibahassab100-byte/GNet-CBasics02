using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question one
            // Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
            //both title and upperTitle to show that title did not change
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);

            #endregion
            #region Question two
            //Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //to check if they point to the same object in memory
            //  string title1 = "Clean Code";
            //string title2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(title1, title2));
            #endregion

            #region Question three
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
            //StringBuilder str = new StringBuilder();
            //str.Append("Book List");
            //str.Append(" - Updated");
            //Console.WriteLine(str.ToString());

            #endregion

            #region Question four
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            //StringBuilder str = new StringBuilder();
            //str.Append("Book List");
            //str.Replace("Book List", "Library");
            //Console.WriteLine(str);
            #endregion

            #region Question five
            // Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator
            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(sentence);
            #endregion
            #region Question six
            //Build the same sentence as above, but using string interpolation ($"...").
            //string title = "clean code";
            //int pages = 464;
            //string str = $"Book: {title}, Pages: {pages}";
            //Console.WriteLine(str);

            #endregion
            #region Question seven
            //Build the same sentence again, but using string.Format()
            //string title = "clean code";
            //int pages = 464;
            //string str = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(str);

            #endregion
            #region Question eight
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 
            //300, otherwise prints "Short Book".
            //int pages = 464;
            //if (pages > 300) Console.WriteLine($"Long Book");
            // else Console.WriteLine($"Short Book");
            #endregion
            #region Question nine
            // Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is 
            //greater than 300 and isAvailable is true.Use the && operator
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages>300&&isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            #endregion
            #region Question ten
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is 
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";
            //string str = title switch
            //{
            //    "Clean Code" => "Great choice!",
            //    "Refactoring" => "Nice pick!",
            //    _ => "Never heard of it"
            //};
            //Console.WriteLine(str);
            #endregion
            #region Question eleven
            //int pages = 464;
            //string msg= pages>300? "long book" :"short book";
            //Console.WriteLine(msg);
            #endregion
            #region Question twelve  
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            //to print each book with its position number, like 1.Clean Code.
            //string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. {books[i]}");
            //}
            #endregion
            #region Question thirteen
            // Using the same books array, use a while loop to print every book title
            //string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //    i++;
            //}
            #endregion
            #region Question fourteen
            // Write a do -while loop that prints "Checking book..." exactly 3 times.
            //int num = 3;
            //int i = 0; 
            //do {
            //    Console.WriteLine($"Checking book....");
            //    i++;
            //}while (i < num);

            #endregion
            #region Question fifteen
            // Using the same books array, use a foreach loop to print every book title.
            //string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
            //foreach (string str in books)
            //{
            //    Console.WriteLine(str);

            //}
            #endregion
            #region Question sixteen
           // Using the same books array, loop through it and print each title, but stop completely(break) once
           //you reach "Refactoring".
            string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "refactoring")
                {
                    break;
                }
                Console.WriteLine(books[i]);
            }
            #endregion

        }
    } }
