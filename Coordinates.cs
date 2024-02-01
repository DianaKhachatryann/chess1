using Microsoft.Win32.SafeHandles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace ClassicGameLibrary;
/// <summary>
/// Coordinates struct which divides the coordinates into letter and number
/// </summary>
public struct Coordinates
{
    public Letters letter;
    public int number;
    /// <summary>
    /// Input coordinate
    /// </summary>
    /// <param name="c"></param>
    public Coordinates(string? c)
    {
        if (c.Length == 2)
        {
            c = c.ToUpper(); ;
            Enum.TryParse(c[0].ToString(), out letter);
            int.TryParse(c[1].ToString(), out number);
        }
        else
        {
            Console.WriteLine("che");
        }
    }
}