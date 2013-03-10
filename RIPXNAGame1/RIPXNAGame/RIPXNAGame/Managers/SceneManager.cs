using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame;
using RIPXNAGame.Rendering;
using RIPXNAGame.Systems;

namespace RIPXNAGame.Managers
{
    class SceneManager : ISceneManager
    {
        protected Dictionary<string, ISceneListener> mRepresentations;
        protected IList<GameObject> mObjectList;

        // Singleton instance

        private static SceneManager mSingletonInstance = new SceneManager();

        private SceneManager()
        {
            mObjectList = new List<GameObject>();
            mRepresentations = new Dictionary<string, ISceneListener>();
            
        }

        public static SceneManager MSingletonInstance
        {
            get
        {
         return mSingletonInstance;;
        }

        }


        public ISceneListener GetRepresentation(string pIdentifier)
        {
            ISceneListener representaion = null;
            mRepresentations.TryGetValue(pIdentifier, out representaion);
            return representaion;
        }

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

        public void Load(IScene pScene)
        {

        }

        
    }
}
