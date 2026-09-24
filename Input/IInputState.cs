using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

public interface IInputState
{
    public bool IsKeyPressed(Keys key);
    public bool IsNewKeyPress(Keys key);

    public bool IsButtonPressed(Buttons button, PlayerIndex? controllingPlayer, out PlayerIndex playerIndex);
    public bool IsNewButtonPress(Buttons button, PlayerIndex? controllingPlayer, out PlayerIndex playerIndex);

}