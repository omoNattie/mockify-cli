using System;
using System.Collections.Generic;
using System.Linq;

using Mockify.Source.Errors;

namespace Mockify.Source.Modules;

public static class Modules
{
    public static string[] Birdify(string[] arg)
    {
        var rng = new Random();
        for (int i = 1; i < arg.Length; i++)
        {
            ErrorSpace.CheckMisplacedArg(arg[i]);

            char[] argv = arg[i].ToArray();
            string making = String.Empty;

            for (int j = 0; j < argv.Length; j++) 
            {
                int index = rng.Next(1, 3);

                if (index == 2)
                    making += char.ToUpper(argv[j]);
                else
                    making += argv[j];
            }

            arg[i] = making;
        }

    return arg;
    }

    public static List<string> Bottomify(string[] arg, bool isLower)
    {
        var bottom = new List<string>();
        var rng = new Random();
        string spam = String.Empty;

        int index = rng.Next(15, 30);
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();

        for (int i = 1; i < arg.Length; i++)
        { 
            if (isLower)
                bottom.Add(arg[i]);
            else
            {
                ErrorSpace.CheckMisplacedArg(arg[i]);
                bottom.Add(arg[i].ToUpper());
            }
        }

        for (int i = 0; i < index; i++)
        {
            int charRnd = rng.Next(0, alphabet.Length);
            if(isLower)
                spam += char.ToLower(alphabet[charRnd]);
            else
                spam += alphabet[charRnd];
        }

        bottom.Add(spam);

        if(isLower)
            bottom.Remove(arg[1]);

    return bottom;
    }
}