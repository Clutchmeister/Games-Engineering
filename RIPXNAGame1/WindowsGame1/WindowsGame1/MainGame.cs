using System;
using System.Collections.Generic;
using System.Diagnostics;
using RIPXNAGame.Resource;
using RIPXNAGame.Physics;
using RIPXNAGame.Rendering;
using RIPXNAGame.Systems;
using RIPXNAGame.AI;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace RIPXNAGame
{
    public enum Dimension
    {
        X2D
    }

    /// MainGame is responsible to handling all managers
 
    public class MainGame
    {
        private IResourceManager mResourceManager = null;
        private IAISystem mAISystem = null;
        private IRenderingSystem mRenderingSystem = null;
        private IPhysicsSystem mPhysicsSystem = null;


        // Singleton instance
   
        private static MainGame mSingletonInstance = new MainGame();

        private MainGame()
        {
            mRenderingSystem = new RenderingManager();
            mAISystem = new AISystem();
            mPhysicsSystem = new PhysicsSystem();
        }


        // Singleton method to access the unique instance of the MainGame

        /// <returns>MainGame instance</returns>
        public static MainGame getInstance()
        {
            return mSingletonInstance;
        }


        // Initialize the Game MainGame

        /// <param name="pDeviceManager">GraphicsDeviceManager previously associated to the Game class</param>
        /// <param name="pContentManager">Content Manager</param>
        public void Init(GraphicsDeviceManager pDeviceManager, ContentManager pContentManager)
        {
            Debug.Assert(pDeviceManager != null, "Device Manager cannot be null");
            Debug.Assert(pContentManager != null, "Content Manager cannot be null");

            mResourceManager = new ResourceManager(pContentManager);
            mRenderingSystem.Init(pDeviceManager, mResourceManager);
        }


        public void Update(ref GameTime pGameTime)
        {
            mAISystem.Update(ref pGameTime);
            mPhysicsSystem.Update(ref pGameTime);
        }


        // Render the scene

        public void Render(ref GameTime pGameTime)
        {
            mRenderingSystem.Render(ref pGameTime);
        }

        // Initiate scene

        public void InitScene(IScene pScene)
        {
            mRenderingSystem.Assemble(pScene);
            mAISystem.Assemble(pScene);
            mPhysicsSystem.Assemble(pScene);
            mResourceManager.RegisterTo(pScene);
        }


        /// Start a scene

        /// <param name="pScene">Scene To Start</param>
        public void PlayScene(IScene pScene)
        {
            mResourceManager.Load(pScene);
            mAISystem.Load(pScene);
            mRenderingSystem.Load(pScene);
            mPhysicsSystem.Load(pScene);
        }

        public void Import(AssetLib pAssetLibrary)
        {
            mResourceManager.Import(pAssetLibrary);
        }

        internal IPhysicsSystem PhysicsSystem { get { return mPhysicsSystem; } }
        internal IRenderingSystem RenderingSystem { get { return mRenderingSystem; } }
        internal IAISystem AISystem { get { return mAISystem; } }
    }
}
