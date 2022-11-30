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

        string ver = "0.6 release build 2";

        switch(args[0])
        {
            case "--help":
                Console.WriteLine(
                    "Description:\n" +
                    "   Makes your text wacky!\n\n" +
                    "Usage:\n" +
                    "   mockify [flags] (options) [sentance]\n\n" +
                    "Flags:\n" +
                    "   --help       This command.\n" +
                    "   --birdify    Gives your text random caps to \"mock\" someone.\n" +
                    "   --bottomify  Gives your text \"bottom\" vibes.\n" +
                    "       -l       Option for only the bottomify flag, makes it lowercaps.\n\n" +
                    "   --version    Shows app version"
                );
            break;

            case "--birdify":
                string[] finBird = Birdify(args);
                foreach (var item in finBird.Skip(1))
                    Console.Write($"{item} ");
            break;

            case "--bottomify":
                bool isLower = false;
                if (args[1] == "-lower" || args[1] == "-l")
                    isLower = true;

                List<string> finBottom = Bottomify(args, isLower);
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
