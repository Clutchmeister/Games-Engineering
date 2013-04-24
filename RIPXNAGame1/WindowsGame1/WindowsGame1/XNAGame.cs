using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

using RIPXNAGame.Systems;
using RIPXNAGame.Resource;
using RIPXNAGame.Rendering;

namespace RIPXNAGame
{

    // XNA Game class loaded by the engine
 
    public abstract class XNAGame : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        // XNAEngine used for this game
        private MainGame mEngine = null;

        public XNAGame(String pGameName)
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 800;
            graphics.PreferredBackBufferWidth = 600;
            mEngine = MainGame.getInstance();
        }


        // Allows the game to perform any initialization it needs before running.

        protected override void Initialize()
        {
            base.Initialize();
        }

 
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.

        protected override void LoadContent()
        {
            // initialize Engine and all internal systems
            mEngine.Init(graphics, this.Content, this);
            ImportAssets();
            base.LoadContent();
        }

        protected virtual void ImportAssets()
        {
            mEngine.Import(GetAssetLibrary());
        }
        protected abstract AssetLib GetAssetLibrary();


        /// UnloadContent will be called once per game and is the place to unload all content.

        protected override void UnloadContent()
        {
        }



        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Delegates update to Engine
            mEngine.Update(ref gameTime);

            base.Update(gameTime);
        }


        /// When called, game draws itself.

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // Delegates render to Engine
            mEngine.Render(ref gameTime);
            base.Draw(gameTime);
        }

        // Initiate a desired scene
 
        /// <param name="pScene">Scene to initialise</param>
        public void PlayScene(IScene pScene)
        {
            mEngine.PlayScene(pScene);
        }

        public static ISceneCamera CreateA2DScene(int pWidth, int pHeight, int pDepth)
        {
            ISceneCamera scene = new X2DScene(pHeight, pHeight, pDepth);
            MainGame.getInstance().InitScene(scene);
            return scene;
        }
    }
}
