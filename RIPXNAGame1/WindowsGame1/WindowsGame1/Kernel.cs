using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using RIPXNAGame;
using RIPXNAGame.Resource;
using RIPXNAGame.Rendering;  

namespace RIPXNAGame
{
    public class Kernel : XNAGame
    {

        #region Data Members

        ISceneCamera mScene = null;

        ICamera mCamera = null;

        public static Kernel mSingletonInstance = new Kernel();

        #endregion

        #region Properties

        public ISceneCamera Scene
        {
            get { return mScene; }
        }

        public ICamera Camera
        {
            get { return mCamera; }
        }

        private static Kernel MSingletonInstance
        {
            get
            {
                return mSingletonInstance; ;
            }

        }

        #endregion


        #region Constructors

        public Kernel()
            : base("RIPXNA")
        {
            this.IsMouseVisible = true;
        }

        #endregion


        #region Methods

        // Using AssetLib class, create a new library containing all visual assets to be utilised in the game.

        protected override AssetLib GetAssetLibrary()
        {
            AssetLib lib = AssetLib.CreateAnEmptyLibrary();             // Create a new library using AssetLib
            GameAsset A = null;                                                  // Use this to store/create visual assets

            A = new GameAsset("ThatFaceVisuals", "ThatFace").UVOriginAt(155, 135).UVTopLeftCornerAt(0, 0).Width(311).Height(270);

            lib.ImportAsset(A);

            A = new GameAsset("PlayerVisuals", "PlayerShip").UVOriginAt(19, 21).UVTopLeftCornerAt(0, 0).Width(39).Height(43);

            lib.ImportAsset(A);

            A = new GameAsset("BulletVisual1", "Bullet1").UVOriginAt(1, 12).UVTopLeftCornerAt(0, 0).Width(3).Height(9);

            lib.ImportAsset(A);
            return lib;
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            mScene = XNAGame.CreateA2DScene(800, 600, 0); // Change these values if you want a bigger screen

            Vector3 camPosition = new Vector3(0, 0, 1);

            // Instantiate and initialize camera, specifying its ID ("Camera #1"
            // in this case), and its position (the position stored in camPosition in this case).

             mCamera = mScene.CreateCameraAt("Camera #1", camPosition); // Example


             this.PlayScene(mScene); // Use this to initate scene
        }

        protected override void Update(GameTime gameTime)
        {
            // Perform standard update operations.
            base.Update(gameTime);



        }

        #endregion
    }
}
