using System.Text;

public class Program
{
    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a string to hash: ");
        string inputString = Console.ReadLine();

        // Convert the input string to a byte array
        byte[] inputData = Encoding.UTF8.GetBytes(inputString);

        // Compute RIPEMD-160 hash - TO DO
    }
}