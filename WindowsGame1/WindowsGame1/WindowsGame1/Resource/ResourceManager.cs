using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using RIPXNAGame.Systems;

namespace RIPXNAGame.Resource
{
    internal class ResourceManager : IResourceManager
    {

        private ContentManager mContentManager = null;
        private AssetLib mAssetLibrary = null;

        public ResourceManager(ContentManager pContentManager)
        {
            mContentManager = pContentManager;
            mContentManager.RootDirectory = "Content";
        }

        public void Import(AssetLib pAssetLibrary)
        {
            mAssetLibrary = pAssetLibrary;
        }

        public void OnPlacedObject(GameObject pPlacedObject)
        {
            LoadAssets(pPlacedObject);
        }

        public void OnRemovedObject(GameObject pRemovedObject)
        {
            
        }

        public void RegisterTo(IScene pScene)
        {
            pScene.AddSceneListener("ResourceManager", this);
        }


        // Load a particular asset within the game

        /// <typeparam name="T">Asset Type</typeparam>
        /// <param name="pResourceName">Asset Name</param>
        /// <returns>Asset loaded</returns>
        private T Load<T>(String pResourceName)
        {
            return mContentManager.Load<T>(pResourceName);
        }

        public void Load(IScene pScene)
        {

        }
  
        private void LoadAssets(GameObject pGameObject)
        {
            if (pGameObject.IsRenderable() && pGameObject.Type == Dimension.X2D)
            {
                X2DAsset asset = (X2DAsset)mAssetLibrary.GetAsset(pGameObject.GetGraphicComponent().AssetID);
                asset.SpriteMap = mContentManager.Load<Texture2D>(asset.Name);
                pGameObject.GetGraphicComponent().Asset = asset;
            }
        }

    }
}