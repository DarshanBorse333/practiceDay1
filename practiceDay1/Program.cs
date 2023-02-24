

using System.ComponentModel.DataAnnotations;

public class Program1
{
    public static void Main()
    {
        Program1.StringManipulations(); //function call

        LengthOfString();
    }
    static void StringManipulations()   // function declaration
    {
        //Consonants and void spaces calculation//

        Console.WriteLine("Write any string");
        var str = Console.ReadLine();

        int spaceCounter = 0;
        int consonantCounter = 0;

        foreach (char item in str)
        {
            if (item == ' ')
            {
                spaceCounter++;
            }

            if(   !( item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                item == ' ' || item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U'))
            {
                consonantCounter++;
            }
        }

        Console.WriteLine("nos of spaces : " + spaceCounter);
        Console.WriteLine("nos of consonants : " + consonantCounter);
    }

    static void LengthOfString()
    {
        // length of string //

        Console.WriteLine("Enter any string");
        var str= Console.ReadLine();

        int lengthOfString = 0;

        foreach (var item in str)
        {
           lengthOfString++;
        }
        Console.WriteLine("lenghth of string is : "+ lengthOfString++);
    }

}
