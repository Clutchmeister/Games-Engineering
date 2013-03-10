using System;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.Systems
{
    interface IPhysicsSystem : IEngineSystem
    {
        void Update(ref GameTime pGameTime);
    }
}
