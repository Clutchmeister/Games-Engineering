using System;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.Physics
{
    public interface IPhysicsActuator
    {
        void AddForce(Vector3 pForce);
    }
}
