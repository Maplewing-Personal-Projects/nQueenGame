using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using nQueenGame.State;

namespace nQueenGame.Manager
{
    public class StateManager : GameComponent
    {
        #region Variable
        
        public const int FPS = 60;

        private DrawState _goalState;
        private int _addframe;
        private Vector2 _addPosition;
        private Vector2 _addSize;
        private Vector3 _addColor;

        #endregion
        
        #region Property
        
        public DrawState CurrentState { get; set; }
        
        #endregion

        #region Methods

        public StateManager(Game game, DrawState state) : base(game)
        {
            CurrentState = state;
        }

        public void Update()
        {
            if (_addframe > 0)
            {
                CurrentState.Bounds = new Vector4( CurrentState.Position.X + _addPosition.X,
                    CurrentState.Position.Y + _addPosition.Y,
                    CurrentState.Size.X + _addPosition.X,
                    CurrentState.Size.Y + _addPosition.Y );
                
                Vector3 color = CurrentState.Color.ToVector3();
                CurrentState.Color = new Color(color.X + _addColor.X,
                    color.Y + _addColor.Y, color.Z + _addColor.Z);

                --_addframe;
                if (_addframe <= 0) CurrentState = _goalState;
            }
        }

        public void SetNextState( float second, DrawState state ){
            _addPosition = new Vector2(((state.Position.X - CurrentState.Position.X) / second / FPS),
                ((state.Position.Y - CurrentState.Position.Y) / second / FPS));
            _addSize = new Vector2(((state.Size.X - CurrentState.Size.X) / second / FPS),
                ((state.Size.Y - CurrentState.Size.Y) / second / FPS));
            Vector3 color = state.Color.ToVector3(), currentColor = CurrentState.Color.ToVector3();
            _addColor = new Vector3(((color.X - currentColor.X) / second / FPS),
                ((color.Y - currentColor.Y) / second / FPS),
                ((color.Z - currentColor.Z) / second / FPS));
            _addframe = (int)(second * (float)FPS) + 1;
            _goalState = state;
        }

        #endregion


    }
}
