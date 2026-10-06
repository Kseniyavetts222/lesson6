using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        var clsCalculator = new lesson6.calculator();
        var clsGui = new lesson6.GUIConsolApp();
    }
}