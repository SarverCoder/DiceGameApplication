using DiceGameApplication.Classes;
using DiceGameApplication.User;

if (!ValidationError.ValidateDiceInput(args, out List<Die> dice))
{
    return;
}

new Game(dice).Start();