using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1
{
    public interface ISceneListener
    {

        // Reacts to "object placed event"

        /// <param name="pPlacedObject">Placed object</param>
        void OnPlacedObject(GameObject pPlacedObject);

        // Reacts to "Object removed event"

        /// <param name="pPlacedObject">Removed object</param>
        void OnRemovedObject(GameObject pPlacedObject);
    }
}
