using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class FallingRocks
{
    static int rockPositionX = 0;
    static int rockPositionY = 0;
    static int dwarfSize = 7;
    static int playerPosition = 10;
    const int PLAYGROUND_HEIGHT = 35;
    const int PLAYGROUND_WIDTH = 70;
    static string dwarf = "(( 0 ))";
    static void RemoveScrollBars()
    {
        //Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WindowHeight = PLAYGROUND_HEIGHT;
        Console.BufferHeight = Console.WindowHeight;
        Console.WindowWidth = PLAYGROUND_WIDTH;
        Console.BufferWidth = Console.WindowWidth;
    }
    static void PrintAtPosition(int x, int y, object symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }
    static void DrawDwarf(object obj)
    {
        PrintAtPosition(PLAYGROUND_WIDTH/2 - (dwarfSize/2) , PLAYGROUND_HEIGHT - 1, obj);
    }
    static void DrawRock()
    {
        
    }
    static void SetInitialPosition()
    {

    }

    static void Main()
    {
        
        Console.CursorVisible = false;
        RemoveScrollBars();
        while (true)
        {
            Console.Clear();
            DrawDwarf(dwarf);
            DrawRock();
            Thread.Sleep(60);
        }
        
    }

    
}

