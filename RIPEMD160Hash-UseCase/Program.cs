using SshNet.Security.Cryptography;
using System.Text;

public class Program
{
    static void Main()
    {
        while(true)
        {
            // Take input from the user
            Console.Write("Enter a string to hash (or type 'exit' to quit): ");
            string inputString = Console.ReadLine();

            if (inputString.ToLower() == "exit")
            {
                break; // exit
            }

            // Convert the input string to a byte array
            byte[] inputData = Encoding.UTF8.GetBytes(inputString);

            // Compute RIPEMD-160 hash
            byte[] hashValue = ComputeRipemd160Hash(inputData);

            // Display the hash result
            Console.WriteLine("Input String: " + inputString);
            Console.WriteLine("RIPEMD-160 Hash: " + BitConverter.ToString(hashValue).Replace("-", "").ToLower());
        }
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
