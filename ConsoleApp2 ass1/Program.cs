using System.Linq.Expressions;

namespace ConsoleApp2_ass1;

internal class Program
{
    static void Main(string[] args)
    {
        //q1
        book myBook = new book();
        myBook.title = "tesst";
        myBook.pages = 444;
        object obj = myBook;
        Console.WriteLine(obj); 
        //q2
        Console.WriteLine(myBook.ToString());
        Console.WriteLine(myBook.Equals(myBook));
        Console.WriteLine(myBook.GetHashCode());
        Console.WriteLine(myBook.GetType());


        //q 3 int pages=464;

        //q4
        try
        {
            int x = 10;
            int y = 0;
            int ruselte = x / y;
            Console.WriteLine(ruselte);  
        }

        catch (Exception ex)
        
        {
            Console.WriteLine("runtime " + ex.Message);
        }
        finally
        {
            Console.WriteLine("done");
        }
        //q5
        int pages = 300;
        double pag = pages;
        Console.WriteLine(pag);//300
        //q6
        double price = 49.99;
        int pric = (int)price;
        Console.WriteLine(pric);//49

        //q7
        string pagestext = "464";
        int newpages = Convert.ToInt32(pagestext);
        Console.WriteLine(newpages);
        Console.WriteLine(newpages.GetType());
        //q8
        string yeartext = "2023";
        int year = int.Parse(yeartext);
        Console.WriteLine(year);//2023

        string badtext = "abc";
        int ruselt;
        bool success = int.TryParse(badtext, out ruselt);
        if (success)
        {
            Console.WriteLine(ruselt);

        }
        else  Console.WriteLine("invalid number");

        //q9 
        int pages9 = 464;
        string pagesstring = pages9.ToString();
        Console.WriteLine(pagesstring);
        Console.WriteLine(pagesstring.GetType());
        //q 10
        int copies = 100;
        object objcop = copies;
        Console.WriteLine(objcop);
        Console.WriteLine(objcop.GetType());

        int copies2 = (int)copies;
        Console.WriteLine(copies2);
        Console.WriteLine(copies2.GetType);
           


















    }
}
