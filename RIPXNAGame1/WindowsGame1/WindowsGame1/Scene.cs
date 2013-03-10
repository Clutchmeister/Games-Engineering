using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame;
using RIPXNAGame.Rendering;
using RIPXNAGame.Systems;


namespace RIPXNAGame
{
    internal class Scene : IScene
    {
        protected Dictionary<string, ISceneListener> mRepresentations;
        protected BoundingBox mSceneBoundingBox;
        protected Dimension mSceneDimension;

        public Scene(int pWidth, int pHeight, int pDepth)
        {
            mSceneBoundingBox = new BoundingBox(new Vector3(-pWidth / 2, -pHeight / 2, -pDepth / 2), new Vector3(pWidth / 2, pHeight / 2, pDepth / 2));
            mRepresentations = new Dictionary<string, ISceneListener>();
        }

        public ISceneListener GetRepresentation(string pIdentifier)
        {
            ISceneListener representaion = null;
            mRepresentations.TryGetValue(pIdentifier, out representaion);
            return representaion;
        }

        public Dimension Dimension { get { return mSceneDimension; } }

        public void AddSceneListener(string pIdentifier, ISceneListener pSceneRepresentation)
        {
            mRepresentations.Add(pIdentifier, pSceneRepresentation);
        }
    }
}
