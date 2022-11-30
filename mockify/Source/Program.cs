using System;
using System.Collections.Generic;
using System.Linq;

using Mockify.Source.Errors;
using static Mockify.Source.Modules.Modules;

namespace Mockify.Source;

class Mockify
{
    public static void Main(string[] args)
    {
        ErrorSpace.HandleArgs(args);

        string ver = "0.5 release build 1";

        switch(args[0])
        {
            case "-help":
                Console.WriteLine(
                    "Description:\n" +
                    "   Makes your text wacky!\n\n" +
                    "Usage:\n" +
                    "   mockify [flags] [sentance]\n\n" +
                    "Flags:\n" +
                    "   --help       This command.\n" +
                    "   --birdify    Gives your text random caps to \"mock\" someone.\n" +
                    "   --bottomify  Gives your text \"bottom\" vibes.\n\n" +
                    "   --version    Shows app version"
                );
            break;

            case "--birdify":
                string[] finBird = Birdify(args);
                foreach (var item in finBird.Skip(1))
                    Console.Write($"{item} ");
            break;

            case "--bottomify":
                List<string> finBottom = Bottomify(args);
                foreach (var item in finBottom)
                    Console.Write($"{item} ");
            break;

            case "--version":
                Console.WriteLine($"Current version: {ver}");
            break;

            default:
                ErrorSpace.HandleWrongArg(args);
            break;
        }
    }
}
