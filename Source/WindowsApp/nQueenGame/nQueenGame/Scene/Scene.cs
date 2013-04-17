using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using nQueenGame.State;
using nQueenGame.Component;

namespace nQueenGame.Scene
{
    public class Scene : Container
    {
        #region Variable

        public string NextScene = null;

        #endregion

        #region Constructor

        public Scene(Game game, Texture2D background, DrawState state)
            : base(game, background, state)
        {
        }

        #endregion

    }
}
