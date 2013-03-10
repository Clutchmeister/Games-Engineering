using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIPXNAGame.Utility
{
    abstract class ListSceneRepresentation<T> : ISceneRepresentationTrait<T>
    {
        protected IList<T> mList;

        public ListSceneRepresentation()
        {
            mList = new List<T>();
        }

        public abstract void OnPlacedObject(GameObject pPlacedObject);
        public abstract void OnRemovedObject(GameObject pPlacedObject);

        public virtual void AddToScene(T pElement)
        {
            // If pElement is not null and mList does not contain pElement then add

            if (pElement != null && !mList.Contains(pElement))
            {
                mList.Add(pElement);
            }
        }

        // Remove pElement from list and therefore scene

        public virtual void RemoveFromScene(T pElement)
        {
            mList.Remove(pElement);
        }
    }
}
