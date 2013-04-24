using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;              // Required to use XNA features.
using Microsoft.Xna.Framework.Input;
using RIPXNAGame;                // Required to use the RIPXNAGame Engine, remember to utilise this in classes that require the engines features
using RIPXNAGame.Resource;       // Required to use the RIPXNAGame Engine resource management features, same as above.

namespace RIPXNAGame.Entities
{
    class Player : Ship
    {

        private GamePadState gamePadState;
        private KeyboardState keyboardState;

        public override void Update(ref GameTime pGameTime)
        {
            GetInput();
            HandleInput();
            ClampToScreen();


            if (keyboardState.IsKeyDown(Keys.Space))
            {
                 int five = 0;
            }
            if(BSpeedCD>0) BSpeedCD--;
        }

        private void GetInput()
        {
            gamePadState = MGame.gamePadState;
            keyboardState = MGame.keyboardState;
            
        }

        private void HandleInput()
        {
            Vector3 velocity = Acceleration;
            if (gamePadState.IsConnected)
            {
                if (gamePadState.ThumbSticks.Left.X != 0) velocity.X = gamePadState.ThumbSticks.Left.X * Speed;
                if (gamePadState.ThumbSticks.Left.Y != 0) velocity.Y = gamePadState.ThumbSticks.Left.Y * Speed;

                
            }
            else
            {
                if (keyboardState.IsKeyDown(Keys.Up)) velocity.Y += Speed;
                if (keyboardState.IsKeyDown(Keys.Down)) velocity.Y += -Speed;
                if (keyboardState.IsKeyDown(Keys.Right)) velocity.X += Speed;
                if (keyboardState.IsKeyDown(Keys.Left)) velocity.X += -Speed;

                if((keyboardState.IsKeyDown(Keys.LeftShift) || (keyboardState.IsKeyDown(Keys.RightShift))))
                    if (BSpeedCD == 0)
                    {
                        FireBullet();
                        BSpeedCD = BSpeed;
                    }
            }
            Velocity = velocity;
        }

        private void ClampToScreen()
        {
            Vector3 position = Position;
            position.X = MathHelper.Clamp(Position.X, -300 + 20, 300 - 20);
            position.Y = MathHelper.Clamp(Position.Y, -400 + 22, 400 - 22);
            Position = position;

        }


        protected override void DefaultProperties()
        {
            GraphicProperties.AssetID = "PlayerVisuals";
            SetPosition(400, 300, 1);
            Speed = 200;
            BAssetName = "BulletVisual1";
            BDamage = 2f;
            BFriendlyFire = false;
            BSpeed = 15;
            BSpeedCD = 0;
            BVelocity = new Vector3(0, 400, 0);
            
        }
    }
}
