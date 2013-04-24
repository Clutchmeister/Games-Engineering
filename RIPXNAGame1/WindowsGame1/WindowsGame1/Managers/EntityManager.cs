using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using RIPXNAGame;


namespace RIPXNAGame
{
    class EntityManager : IEntityManager
    {
        #region Data Members
        protected IList<GameObject> mGameObjects;

        protected MainGame mGame;

        protected IScene mSceneManager;

        private int nextFree;

        #endregion

        #region
        public IList<GameObject> GameObjects
        {
            get { return mGameObjects; }
            set { mGameObjects = value; }
        }

        public MainGame MGame
        {
            get { return mGame; }
            set { mGame = value; }
        }

        public IScene SceneManager
        {
            get { return mSceneManager; }
            set { mSceneManager = value; }
        }

        #endregion

        public EntityManager()
        {        
            mGameObjects = new List<GameObject>();
            nextFree = 0;
        }

        public GameObject Create(string pEntityType)
        {
            Type entityType = Type.GetType("RIPXNAGame.Entities." + pEntityType);
            GameObjects.Add((GameObject)Activator.CreateInstance(entityType));

            GameObject newEntity = GameObjects[GameObjects.Count-1];
            Initialise(newEntity, pEntityType, new Vector3(0,0,0));

            return (newEntity);
        }

        public void Initialise(GameObject entity, string entityName, Vector3 pPosition)
        {
            entity.MGame = mGame;
            entity.UID = nextFree;
            entity.UName =  entityName + nextFree;
            nextFree++;
            entity.Initialise();
            entity.EntityManager = this;
            SceneManager.Place(entity, pPosition);
        }

        public void Remove(int UID)
        {
            int i = 0;
            while (GameObjects[i].UID != UID)
                i++;
            SceneManager.Remove(GameObjects[i]);
            GameObjects.RemoveAt(i);
        }

        public void Remove(GameObject entity)
        {
            SceneManager.Remove(entity);
            GameObjects.Remove(entity);
        }

        public GameObject Fetch(int UID)
        {
            int i = 0;
            while(GameObjects[i].UID != UID)
                i++;
            return GameObjects[i];
        }

        public GameObject Fetch(string uName)
        {
            int i = 0;
            while(GameObjects[i].UName != uName)
                i++;
            return GameObjects[i];
            }

        public void Load(IScene pScene, MainGame pGame)
        {
            SceneManager = pScene;
            mGame = pGame;
        }
    
    }
}
