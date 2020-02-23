using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CrosswordSolver
{
    public abstract class GUIObject
    {
        protected Geometry geometry;
        protected bool hovering;
        protected bool down;
        protected UIManager manager;
        protected InputManager input;

        public void Update(float dt)
        {
            
        }
    }
}
