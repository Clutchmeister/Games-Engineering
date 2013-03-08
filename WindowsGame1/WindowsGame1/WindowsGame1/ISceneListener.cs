using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIPXNAGame
{
    public interface ISceneListener
    {

        // Reacts when object is placed in screen

        /// <param name="pPlacedObject">Placed object</param>
        void OnPlacedObject(GameObject pPlacedObject);

        // Reacts when object is removed

        /// <param name="pPlacedObject">Removed object</param>
        void OnRemovedObject(GameObject pPlacedObject);
    }
}
