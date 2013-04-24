using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIPXNAGame.Physics
{
    class CollisionData
    {
        public RecordContact Contact; // Contact data
        public PhysicsComponent First; // First collided entity
        public PhysicsComponent Second; // Second collided entity

        public CollisionData(PhysicsComponent pFirst, PhysicsComponent pSecond, RecordContact pContact)
        {
            Contact = pContact;
            First = pFirst;
            Second = pSecond;
        }
    }
    class CollisionManager
    {

        public static void ResolveCollisions(IList<CollisionData> pCollisionList)
        {
            // input what you want to happen during collisions here

            
            
        }
    }
}
