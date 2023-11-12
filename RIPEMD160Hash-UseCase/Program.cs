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
    
    static byte[] ComputeRipemd160Hash(byte[] input)
    {
        using(RIPEMD160 ripemd160 = new RIPEMD160())
        {
            byte[] hashValue = ripemd160.ComputeHash(input);

            return hashValue;
        }
    }
}
