using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

var clsCalculator = new lesson6.calculator();
var clsGui = new lesson6.GUIConsolApp();

public enum Command
{
    Sum,
    Count,
    Max,
    Min,
    Add,
    Sub,
    Malt,
    Div,
    Exit=0,
}



double[] array = { };
array=clsGui.GetArray(array);
Console.WriteLine($"sum:{clsCalculator.Sum(array)}");

clsCalculator.Sum(array);
