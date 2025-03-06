public class Challenge_one
{
    public void PrintNumbers()
    {
        // Todo: Print out the numbers 1 - 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void PrintStrings(string[] arr)
    {
        /* Todo: Print out each string that is passed to the array as an argument*/
        foreach (string strs in arr)
        {
            Console.WriteLine(strs);
        }
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        /*
        Todo: Check if a number is positive, negative or zero.
        */
        if (number < 0)
        {
            Console.WriteLine("Number is negative!");
        }
        else if (number > 0)
        {
            Console.WriteLine("Number is positive");
        }
        else
        {
            Console.WriteLine("Number is 0");
        }
    }
}