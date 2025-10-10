using Microsoft.Extensions.DependencyInjection;
using MorseCodeTranslator.Interfaces;
using MorseCodeTranslator.Services;

namespace MorseCodeTranslator
{
    // Initial basic morse_code_mapping.json content containing
    // the aplphabet, numbers, and some special characters,
    // was obtained from the following source:
    // https://gist.github.com/mohayonao/094c71af14fe4791c5dd
    internal class Program
    {
        // Main MorseCodeTranslator program
        static void Main(string[] args)
        {
            // Create a ServiceCollection instance
            IServiceCollection services = new ServiceCollection();
            // Use the ConfigureServices method to register services
            ConfigureServices(services);
            // Build a ServiceProvider
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // Get service instances from the ServerProvider
            IDataInitializationService dataInitializationService = serviceProvider.GetRequiredService<IDataInitializationService>();

            // Load morse code Dictionary through service
            Dictionary<string, string> morseEncodeDictionary = dataInitializationService.LoadEncodeDictionary();

            // Display all morse code mappings from the Dictionary for testing purposes
            foreach (var item in morseEncodeDictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        // Configure the ServiceCollection for dependency injection
        private static void ConfigureServices(IServiceCollection services)
        {
            // Register services
            services.AddSingleton<IDataInitializationService, DataInitializationService>();
        }
    }
}
