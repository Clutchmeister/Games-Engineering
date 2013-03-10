using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame.Physics;

namespace RIPXNAGame
{
    public interface IAIController : IGameObjectComponent, ICollisionListener
    {
        void Update(ref GameTime pGameTime);
    }
}
