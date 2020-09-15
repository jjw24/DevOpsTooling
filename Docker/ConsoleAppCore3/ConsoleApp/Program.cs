using System;
using System.Runtime.InteropServices;
using static System.Console;

public static class Program
{
    public static void Main(string[] args) 
    {
        string defaultMessage;

        defaultMessage = Environment.NewLine +
                                "Sup World" +
                                Environment.NewLine +
                                Environment.NewLine +
                                "Environment:" +
                                Environment.NewLine +
                                RuntimeInformation.FrameworkDescription +
                                Environment.NewLine +
                                RuntimeInformation.OSDescription +
								Environment.NewLine;
        

        var message = args is object && args.Length > 0 ? "Your message: " + string.Join(' ', args): defaultMessage;
        
        WriteLine(message);
    }
}
