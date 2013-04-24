using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;              // Required to use XNA features.
using RIPXNAGame;                // Required to use the RIPXNAGame Engine, remember to utilise this in classes that require the engines features
using RIPXNAGame.Resource;       // Required to use the RIPXNAGame Engine resource management features, same as above.

namespace RIPXNAGame.Entities
{
    class Bullet : X2DToken
    {
        #region Data Members
        private float damage;

        private bool friendlyFire;
        #endregion

        #region Properties
        public float Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public bool FriendlyFire
        {
            get { return friendlyFire; }
            set { friendlyFire = value; }
        }
        #endregion

        public void Fire(string pAssetName, Vector3 pPosition, float pDamage, Vector3 pVelocity, bool pFriendlyFire)
        {
            SetGraphic(pAssetName);
            Position = pPosition;
            Damage = pDamage;
            FriendlyFire = pFriendlyFire;

            Vector3 velocity = pVelocity;
            Velocity = velocity;
        }

        public override void Update(ref GameTime pGameTime)
        {
            if (Position.Y > 450)
            {
                EntityManager.Remove(UID);
            }
        }

        protected override void DefaultProperties()
        {
            SetGraphic("BulletVisual1");
        }
    }
}
