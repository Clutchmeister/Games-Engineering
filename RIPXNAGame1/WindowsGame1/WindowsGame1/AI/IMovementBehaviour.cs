using System;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.AI
{
    public interface IMovementBehaviour
    {

        // Code used to command the object to move in the desired direction

        /// <param name="pGameTime">Game time</param>
        /// <param name="pObjectToMove">Object to move</param>
        /// <param name="pDesiredDirection">Desired direction</param>
        void Move(GameTime pGameTime, GameObject pObjectToMove, Vector3 pDesiredDirection);
    }
}
