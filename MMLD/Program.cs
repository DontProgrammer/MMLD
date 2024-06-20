using MMLD;
using MMLD.Core;
using System.Threading;

class Program
{
    static Manager manager = new Manager();
    static void Main()
    {
        SayHello();
        while (!manager.Disposed) { 
        }
        
    }

    static void SayHello()
    {
        string msg = $"""
            Hello dear User!

            App Name: {AppInfo.ShortAppName}
            App Author: {AppInfo.AppAuthor}
            App version: {AppInfo.AppVersion}
            
            Good luck! :D


            """;
        Console.ForegroundColor = ConsoleColor.Green;
        Manager.AnimateLine(msg);
        Console.ForegroundColor = ConsoleColor.White;

    }
}