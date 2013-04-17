using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using nQueenGame.State;

namespace nQueenGame.Component
{
    public class Component : GameComponent, IDrawable
    {
        #region Property

        public int DrawOrder { get; set; }
        public bool Visible { get; set; }
        public DrawState State { get; set; }

        #endregion

        #region Constructor
        
        public Component(Game game)
            : base(game)
        {
        }

        #endregion

        #region Methods

        public virtual void Draw(GameTime gameTime)
        {
        }
        
        #endregion

        #region Event

        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        #endregion
    }
}
