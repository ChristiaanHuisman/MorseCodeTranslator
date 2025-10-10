namespace MorseCodeTranslator.Interfaces
{
    // Interface for dependency injection for the DataInitializationService
    internal interface IDataInitializationService
    {
        // Load morse code Dictionary through service
        Dictionary<string, string> LoadEncodeDictionary();
    }
}
