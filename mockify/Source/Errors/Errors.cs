using System;

namespace Mockify.Source.Errors;

public static class ErrorSpace
{
    public const string NoArgErr = " \nUsage:\n    Mockify [flags] [sentance]\n\nUse mockify --help for more info.";
    public static string TooManyArgsErr = " \nFlag \"help\" does not take arguments.";

    public static void HandleArgs(string[] arg)
    {
        if (arg.Length < 2 && arg[0] != "-help" && arg[0] != "--version") 
            throw new ArgumentException(NoArgErr);

        if (arg[0] == "-help" && arg.Length >= 2)
            throw new ArgumentException(TooManyArgsErr);
    }

    public static void HandleWrongArg(string[] arg)
    {
        string WrongArgErr = $" \nFlag {arg[0]} does not exist.\nPlease refer to mockify --help for existing flags.";
        throw new ArgumentException(WrongArgErr);
    }
}