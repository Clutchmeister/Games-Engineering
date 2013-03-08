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



        public ISceneCamera mScene = null;

        ICamera mCamera = null;

        private int bFishAmount = 0;

        private int rFishAmount = 0;

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

        #endregion


        #region Constructors


        // Default constructor.

        public Kernel()
            : base("FishO'Rama")
        {
            this.IsMouseVisible = true;
        }

        #endregion


        #region Methods

        // Using AssetLib class, create a new library containing all visual assets to be utilised in the game.

        protected override AssetLib GetAssetLibrary()
        {
            AssetLib lib = AssetLib.CreateAnEmptyLibrary();             // Create a new library using AssetLib
            X2DAsset A = null;                                                  // Use this to store/create visual assets

            return lib;
        }

        /// <summary>
        /// Load contents for the simulation.
        /// LoadContent will be called only once, at the beginning of the simulation,
        /// is the place to load all of your content (e.g. graphics and sounds).
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();

            // Use this to instantiate/inistialise scene 
            mScene = XNAGame.CreateA2DScene(800, 600, 0);

            // Create tokens here



            // Place tokens here



            Vector3 tokenPos;        // Empty Vector3, use this to define positions within the game world

            tokenPos = new Vector3(0, 0, 0);            // Use this to state where you want the token to be placed
            // mScene.Place(,);           // Use this to finally place your object in the game world


            // Create the world camera here

            Vector3 camPosition = new Vector3(0, 0, 1);

            // Instantiate and initialize camera, specifying its ID ("Camera 01"
            // in this case), and its position (camPosition in this case).

             mCamera = mScene.CreateCameraAt("Camera 01", camPosition); // Example


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
