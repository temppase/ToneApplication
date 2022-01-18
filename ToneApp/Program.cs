// See https://aka.ms/new-console-template for more information
using MusicMathLib;
using NotesLib;
using TonalityLibrary;
Notes N = new Notes();
HzClass Hz = new HzClass();
ToneClass T = new ToneClass(); 
double Div = 0;
int wave = 0;
ConsoleKeyInfo c;
bool loop = true;
while (loop)
{
    Console.WriteLine("\n  ****This will be some new music app...****   \n");
    Console.WriteLine(" Press ESC to stop");
    Console.Write("  Give octave divission: ");
    Div = double.Parse(Console.ReadLine());
    Console.Write("  Give wave lenght: ");
    wave = int.Parse(Console.ReadLine());
    while (true)
    {

        c = Console.ReadKey(true);
        wave = T.WaveChange(c, wave);
        Console.Write(T.PlayNotes(c, Div, wave));
        Console.SetCursorPosition(0, Console.CursorTop);
        if (c.Key == ConsoleKey.Escape)
        {
            break;
        }
    }
    Console.WriteLine(" Do you want to continue? (y/n)");
    var key = Console.ReadKey().KeyChar;
    if (key == 'n')
    {
        loop = false;
    }
    else
    {
        Console.Clear();
    }
}
