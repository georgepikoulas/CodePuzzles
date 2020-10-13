using CodeChallenges.ConsoleUI.Challenges;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

namespace CodeChallenges.ConsoleUI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            //SpeechSynthesizer synth = new SpeechSynthesizer();


            Console.Write("Βάλε Αριθμό= ");
            var input = Console.ReadLine();
            var armstrong = new ArmstrongNumber();

            var isArmstrong = armstrong.Calculate(input);

            if (isArmstrong)
            {
                Console.BackgroundColor =  ConsoleColor.DarkGreen ;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Είναι Armstrong Number.");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor =  ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Δεν είναι Armstrong Number.");
                Console.ResetColor();

            }

            Console.ReadKey();
        }

        static async Task SynthesizeAudioAsync()
        {
            var config = SpeechConfig.FromSubscription("YourSubscriptionKey", "YourServiceRegion");
            using var synthesizer = new SpeechSynthesizer(config);
            await synthesizer.SpeakTextAsync("Synthesizing directly to speaker output.");
        }
    }
}
