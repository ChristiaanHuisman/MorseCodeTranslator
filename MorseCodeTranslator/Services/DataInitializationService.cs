using System.Text.Json;

namespace MorseCodeTranslator.Services
{
    // Initialization services for loading the encoding Dictionary and decoding binary tree
    internal class DataInitializationService
    {
        // This string should not be changed after initialization
        private readonly string _morseMappingString;
        
        // Constructor for string initialization
        public DataInitializationService()
        {
            // Get relative path to morse_code_mapping.json for most OS types
            var pathToMorseMappingJson = Path.Combine(AppContext.BaseDirectory, "Data", "morse_code_mapping.json");
            // Read morse_come_mapping.json to a string
            _morseMappingString = File.ReadAllText(pathToMorseMappingJson);
        }

        // Method for loading and returning the encoding Dicionary
        public Dictionary<string, string> LoadEncodeDictionary()
        {
            // Read _morseMappingString and deserialize it to a dictionary
            var morseEncodeDictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(_morseMappingString);
            // Return the dictionary
            return morseEncodeDictionary;
        }
    }
}
