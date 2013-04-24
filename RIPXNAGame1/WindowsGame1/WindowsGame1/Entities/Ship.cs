using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;              // Required to use XNA features.
using RIPXNAGame;                // Required to use the RIPXNAGame Engine, remember to utilise this in classes that require the engines features
using RIPXNAGame.Resource;       // Required to use the RIPXNAGame Engine resource management features, same as above.

namespace RIPXNAGame.Entities
{
    class Ship : X2DToken // Tokens HAVE to inherit X2DToken to be built, just like the mind needs AIPlayer
    {
        #region Data Members

        private float speed;


        private string bAssetName;
        private float bDamage;
        private Vector3 bVelocity;
        private bool bFriendlyFire;
        private int bSpeed;
        private int bSpeedCD;

        // remember to put reference to mind here or any other sub component you wish to connect to a token

        #endregion

        #region Properties

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string BAssetName
        {
            get { return bAssetName; }
            set { bAssetName = value; }
        }

        public float BDamage
        {
            get { return bDamage; }
            set { bDamage = value; }
        }

        public Vector3 BVelocity
        {
            get { return bVelocity; }
            set { bVelocity = value; }
        }

        public bool BFriendlyFire
        {
            get { return bFriendlyFire; }
            set { bFriendlyFire = value; }
        }

        public int BSpeed
        {
            get { return bSpeed; }
            set { bSpeed = value; }
        }

        public int BSpeedCD
        {
            get { return bSpeedCD; }
            set { bSpeedCD = value; }
        }

        // Get reference to Kernel. Remember to do this for any other values a token might need
        /// </summary>

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public override void Update(ref GameTime pGameTime)
        {
        }

        public void FireBullet()
        {
            GameObject entity = (GameObject)EntityManager.Create("Bullet");
            Bullet tBullet = (Bullet)entity;
            tBullet.Fire(bAssetName, Position, bDamage, bVelocity, bFriendlyFire);
        }



        /// <summary>
        /// Setup default values for this token's porperties.
        /// </summary>
        protected override void DefaultProperties()
        {
        }

        #endregion
    }
}