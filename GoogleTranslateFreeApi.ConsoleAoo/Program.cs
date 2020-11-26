using System;

namespace GoogleTranslateFreeApi.ConsoleAoo
{

    class Program
    {
        private static readonly GoogleTranslator Translator = new GoogleTranslator();
        
        static void Main(string[] args)
        {
			Console.WriteLine("Please type your sentence in Italian: ");
			var text = Console.ReadLine();
            TranslationResult result = Translator.TranslateAsync(text, Language.Auto, Language.English).GetAwaiter().GetResult();
            Console.WriteLine($"Sentence in Italian: {text}");
            Console.WriteLine($"Sentence in English: {result.MergedTranslation}");

        }
    }

   
}
