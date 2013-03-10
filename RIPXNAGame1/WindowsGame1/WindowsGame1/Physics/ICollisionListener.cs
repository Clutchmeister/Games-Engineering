using System;


namespace RIPXNAGame.Physics
{
    public interface ICollisionListener
    {
        void OnTouch(GameObject pOther);
    }
}
