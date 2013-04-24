using System;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.Physics
{

    // Contact from a collision
  
    class RecordContact
    {
        private long mTime;

        /// <param name="pTime">Contact Time</param>
        /// <param name="pDepth">Depth</param>
        /// <param name="pNormal">Normal</param>
        public RecordContact(long pTime)
        {

        }

        public long Time
        {
            get { return mTime; }
        }


    }
}
