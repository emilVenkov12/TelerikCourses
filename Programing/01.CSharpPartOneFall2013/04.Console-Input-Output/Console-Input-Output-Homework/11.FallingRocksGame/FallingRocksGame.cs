using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FallingRocksGame
{
    class FallingRocksGame
    {

        const int WorldRows = 23;
        const int WorldCols = 79;

        static void Initialize(Engine gameEngine)
        {
            gameEngine.AddObject(new Dwarf(new MatrixCoords(WorldRows - 1, WorldCols / 2), 12));
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            char[] rockSymbols = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
            Engine gameEngine = new Engine(renderer, keyboard, WorldRows, WorldCols, rockSymbols,200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerDwarfLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerDwarfRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
