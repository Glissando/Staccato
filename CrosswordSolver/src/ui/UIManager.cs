using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrosswordSolver
{
    public class UIManager
    {
        Group UILayer;
        public Game game;

        public UIManager(Game game)
        {
            this.game = game;
        }
    }
}
