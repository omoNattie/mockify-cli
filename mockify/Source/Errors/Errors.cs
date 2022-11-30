using System;

namespace Mockify.Source.Errors;

public static class ErrorSpace
{
    public const string NoArgErr = " \nUsage:\n    Mockify [flags] [sentance]\n\nUse mockify --help for more info.";
    public const string TooManyArgsErr = " \nFlag \"help\" does not take arguments.";
    public const string NoFlagErr = " \nFlags must have -- at the beginning!";
    
    public static void HandleArgs(string[] arg)
    {
        if (arg.Length < 2 && arg[0] != "--help" && arg[0] != "--version") 
            throw new ArgumentException(NoArgErr);

        if (arg[0] == "--help" && arg.Length >= 2)
            throw new ArgumentException(TooManyArgsErr);

        if (!arg[0].StartsWith("--"))
            throw new ArgumentException(NoFlagErr);
    }

    public static void CheckMisplacedArg(string arg)
    {
        if (arg.StartsWith("--") || arg.StartsWith("-"))
        {
            string MisplacedArg = $" \nMisplaced flag/option {arg}";
            throw new ArgumentException(MisplacedArg);
        }
    }

    public static void HandleWrongArg(string[] arg)
    {
        string WrongArgErr = $" \nFlag {arg[0]} does not exist.\nPlease refer to mockify --help for existing flags.";
        throw new ArgumentException(WrongArgErr);
    }
}