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
        protected IList<GameObject> mObjectList;
        protected Dictionary<string, ISceneListener> mRepresentations;
        protected BoundingBox mSceneBoundingBox;
        protected Dimension mSceneDimension;

        public Scene(int pWidth, int pHeight, int pDepth)
        {
            mSceneBoundingBox = new BoundingBox(new Vector3(-pWidth / 2, -pHeight / 2, -pDepth / 2), new Vector3(pWidth / 2, pHeight / 2, pDepth / 2));
            mObjectList = new List<GameObject>();
            mRepresentations = new Dictionary<string, ISceneListener>();
        }


        public void AddSceneListener(string pIdentifier, ISceneListener pSceneRepresentation)
        {
            mRepresentations.Add(pIdentifier, pSceneRepresentation);
        }

        public ISceneListener GetRepresentation(string pIdentifier)
        {
            ISceneListener representaion = null;
            mRepresentations.TryGetValue(pIdentifier, out representaion);
            return representaion;
        }



        // Place an object at a desired location

        /// <param name="pGameObject">Game Object</param>
        /// <param name="pPosition">Position</param>
        public virtual void Place(GameObject pGameObject, Vector3 pPosition)
        {

            pGameObject.Position = pPosition;
            if (!mObjectList.Contains(pGameObject))
            {
                mObjectList.Add(pGameObject);

                foreach (ISceneListener representation in mRepresentations.Values)
                {
                    representation.OnPlacedObject(pGameObject);
                }
            }
        }

        public virtual void Remove(GameObject pGameObject)
        {
            this.mObjectList.Remove(pGameObject);
            foreach (ISceneListener representation in mRepresentations.Values)
            {
                representation.OnRemovedObject(pGameObject);
            }
        }

        public IList<GameObject> ObjectList
        {
            get
            {
                return mObjectList;
            }
        }
        public Dimension Dimension { get { return mSceneDimension; } }
    }
}
