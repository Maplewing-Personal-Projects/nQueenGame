using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using nQueenGame.State;
using nQueenGame.Manager;

namespace nQueenGame.Component
{
    public class Container : BasicComponent
    {
        #region Variable

        Texture2D _background;
        StateManager _state;
        List<BasicComponent> _contain;
        
        #endregion

        #region Constructor

        public Container(Game game, Texture2D background, DrawState state)
            : base(game)
        {
            _background = background;
            _state = new StateManager(game, state);
        }

        public void AddComponent(BasicComponent component)
        {
            _contain.Add(component);
        }

        public void RemoveComponent(BasicComponent component)
        {
            _contain.Remove(component);
        }

        public override void Start()
        {
            base.Start();
            _state.Start();
            foreach (var bc in _contain)
            {
                bc.Start();
            }
        }

        public override void End()
        {
            base.End();
            _state.End();
            foreach (var bc in _contain)
            {
                bc.End();
            }
        }

        #endregion
    }
}
