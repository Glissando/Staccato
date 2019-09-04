using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Forms.Controls;
using System.Windows.Forms;
using Priority_Queue;

namespace CrosswordSolver
{
    public class EditorWindow : MonoGameControl
    {
        string WelcomeMessage = "Hello MonoGame.Forms!";
        //FastPriorityQueue<Sprite> spriteBuffer;
        Game game;

        protected override void Initialize()
        {
            base.Initialize();
            Editor.Content.RootDirectory = "Content";
            game = LuaInit.game;
        }

        protected override void Draw()
        {
            base.Draw();
            
            Editor.BeginCamera2D(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            Editor.spriteBatch.DrawString(Editor.Font, WelcomeMessage, new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(WelcomeMessage).X / 2),
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2)),
                Color.White);

            game.state.Draw(Editor);
            
            Editor.EndCamera2D();
            
            Editor.DrawDisplay();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void Update(GameTime gameTime)
        {
            //Calculate Change in time
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            //Update input state
            var keyboard = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            game.input.Update(keyboard);

            //Update Timer(s)
            game.timer.Update(dt);

            //Update current game state
            base.Update(gameTime);
            game.state.Update(dt);
        }
    }
}
