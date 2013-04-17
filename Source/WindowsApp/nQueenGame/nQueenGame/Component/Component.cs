using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace nQueenGame.Component
{
    public class BasicComponent : DrawableGameComponent
    {
        #region Variable

        public Viewport Bounds;

        #endregion

        #region Constructor

        public BasicComponent(Game game)
            : base(game)
        {
            Bounds = game.GraphicsDevice.Viewport;
        }

        public virtual void Start()
        {
            Game.Components.Add(this);
        }

        public virtual void End()
        {
            if (Game.Components.Contains(this))
            {
                Game.Components.Remove(this);
            }
        }

        #endregion
    }
}
