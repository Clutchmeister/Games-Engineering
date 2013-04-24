using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using RIPXNAGame;
using RIPXNAGame.AI;
using RIPXNAGame.Tokens;

namespace RIPXNAGame.Entities
{
    class PlayerMind : AIPlayer
    {
        #region Data Members



        private float mRotation;

        #region Properties


        public float Rotation
        {
            get { return mRotation; }
            set { mRotation = value; }
        }

        public Vector3 mPosition
        {
            get {return PossessedToken.Position;}
            set { PossessedToken.Position = value; }
        }

        #endregion

        public override void Update(ref GameTime pGameTime)
        {
            
        }

        public override void Initialise(string pName)
        {
            Rotation = 0f;
        }

        #endregion
    }
}
