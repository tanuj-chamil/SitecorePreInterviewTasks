using SitecorePreInterviewTasks.Task02;

public class Program
{
    public static void Main(string[] args)
    {
        string inputString = "Racecar";
        string trashSymbolString = "";
        Palindrome palindrome = new Palindrome(inputString, trashSymbolString);
        Console.WriteLine(palindrome);

    }
}