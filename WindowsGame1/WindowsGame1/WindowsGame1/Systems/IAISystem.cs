using System;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.Systems
{
 interface IAISystem : IEngineSystem {

        // Method to constantly check code 

        void Update(ref GameTime pGameTime);
    }
}

