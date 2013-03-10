using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RIPXNAGame.Systems;

namespace RIPXNAGame.Rendering
{
    class RenderingManager : IRenderingSystem
    {
        private GraphicsDeviceManager mDeviceManager = null;
        private ISceneGraph mSceneGraph = null;
        private ICamera mCamera = null;
        private IResourceManager mResourceManager;

        /// <summary>
        /// Perform Rendering System Initialization
        /// </summary>
        /// <param name="pDeviceManager">GraphicsDeviceManager</param>
        public void Init(GraphicsDeviceManager pDeviceManager, IResourceManager pResourceManager)
        {
            mResourceManager = pResourceManager;
            mDeviceManager = pDeviceManager;
        }

        public void Assemble(IScene pScene)
        {
            if (Dimension.X2D == pScene.Dimension)
                pScene.AddSceneListener("2DGraphicScene", new BaseSceneGraph(mResourceManager, this));
        }

        public void Assemble(GameObject pGameObject)
        {
            if (Dimension.X2D == pGameObject.Type)
                // inject a graphic component on token
                pGameObject.Inject(ComponentType.GRAPH, new X2DRenderableObject("NoAssetSpecifed"));
        }

        public void Load(IScene pScene)
        {
            Debug.Assert(null != mCamera, "There is no camera present,  therefore I shall be a fine sir/madam or whatever gender a computer may be and place one for you");
            mSceneGraph = (ISceneGraph)pScene.GetRepresentation("2DGraphicScene");
            mCamera.PresentScene(mSceneGraph);
        }

        public void SetCamera(ICamera pCamera)
        {
            Debug.Assert(null != pCamera, "Parameter is invalid, you cannot set a null camera....derp");
            mCamera = pCamera;
            mCamera.Init(mDeviceManager.GraphicsDevice);
        }


        /// <summary>
        /// Render the scene
        /// </summary>
        /// <param name="pSimTime">Time structure</param>
        public void Render(ref GameTime pSimTime)
        {
            if (mCamera != null)
                mCamera.RenderScene();
            else
            {
                mDeviceManager.GraphicsDevice.Clear(Color.Black);
            }
        }


    }
}
