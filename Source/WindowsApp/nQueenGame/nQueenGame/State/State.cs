using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace nQueenGame.State
{
    public class DrawState
    {
        #region Variable

        Game _game;
        Vector4 _bounds;

        #endregion

        #region Property

        public Vector4 Bounds
        {
            get { return _bounds; }
            set { _bounds = value; }
        }
        public Vector2 Position
        {
            get
            {
                return new Vector2(_game.GraphicsDevice.Viewport.Width * _bounds.X,
                                   _game.GraphicsDevice.Viewport.Height * _bounds.Y);
            }
            set { _bounds.X = value.X; _bounds.Y = value.Y; }
        }
        public Vector2 Size
        {
            get
            {
                return new Vector2(_game.GraphicsDevice.Viewport.Width * _bounds.Z,
                                   _game.GraphicsDevice.Viewport.Height * _bounds.W);
            }

            set { _bounds.Z = value.X; _bounds.W = value.Y; }
        }
        public Color Color { get; set; }
        public Single RotateAngle { get; set; }
        public SpriteEffects SpriteEffects { get; set; }
        public Single Depth { get; set; }

        #endregion

        #region Constructor

        public DrawState(Game game, Vector4 bounds, Color color,
            Single rotateAngle = 0, SpriteEffects spriteEffects = SpriteEffects.None,
            Single depth = 0)
        {
            _game = game;
            _bounds = bounds;
            Color = color;
            RotateAngle = rotateAngle;
            SpriteEffects = spriteEffects;
            Depth = depth;
        }

        #endregion

    }
}
