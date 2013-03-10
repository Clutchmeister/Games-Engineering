using System;
using System.Collections.Generic;

namespace RIPXNAGame.Physics
{
    public interface IPhysicsProperties
    {
        float Mass { set; get; }


        IPhysicsProperties SetCollisionRadius(float pCollisionRadius);


        IPhysicsProperties SetBlockable(bool pIsBlockable);

        IPhysicsProperties SetMovable(bool pIsMovable);
    }
}
