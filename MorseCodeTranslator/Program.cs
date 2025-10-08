using System.Text.Json;

namespace MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get relative path to morse_code_mapping.json
            var pathToMorseMapingJson = Path.Combine(AppContext.BaseDirectory, "Data", "morse_code_mapping.json");
            // Read morse_come_mapping.json to a string
            string morseMapingString = File.ReadAllText(pathToMorseMapingJson);
            // Read morse_code_mapping and deserialize it to a dictionary
            var morseEncodeDictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(morseMapingString);
            // Display all morse code mappings from the dictionary
            foreach (var item in morseEncodeDictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
