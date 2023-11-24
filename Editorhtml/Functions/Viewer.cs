using System.Text.RegularExpressions;
using Editorhtml.Setup;

namespace Editorhtml.Functions;

public class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO VISUALIZAÇÃO");
        Console.WriteLine("-----------------");
        Replace(text);
        Console.WriteLine("-----------------");
        Console.ReadKey();
        Menu.Show();


    }

    public static void Replace(string text)
    {
        
        var strong = new Regex("text <strong>text</strong>");
    }


}