using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;

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
            StringBuilder str = new StringBuilder();
            str.Append("Book List");
            str.Replace("Book List", "Library");
            Console.WriteLine(str);
            #endregion

        }
    }
}
