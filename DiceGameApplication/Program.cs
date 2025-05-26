using DiceGameApplication.Classes;
using DiceGameApplication.User;

namespace DiceGameApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!ValidationError.ValidateDiceInput(args, out List<Die> dice))
            {
                return;
            }

            new Game(dice).Start();
        }
    }
}
