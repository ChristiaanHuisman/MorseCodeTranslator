using MorseCodeTranslator.Services;

namespace MorseCodeTranslator
{
    internal class Program
    {
        // Main MorseCodeTranslator program
        static void Main(string[] args)
        {
            // Register the DataInitializationService
            DataInitializationService dataInitializationService = new DataInitializationService();
            // Get morseEncodeDictionary from the DataInitializationService LoadEncodeDictionary method
            Dictionary<string, string> morseEncodeDictionary = dataInitializationService.LoadEncodeDictionary();

            // Display all morse code mappings from the Dictionary for testing purposes
            foreach (var item in morseEncodeDictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
