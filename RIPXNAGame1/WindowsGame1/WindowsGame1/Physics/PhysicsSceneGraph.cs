using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame.Utility;

namespace RIPXNAGame.Physics
{
    class PhysicsSceneGraph : ListSceneRepresentation<PhysicsComponent>
    {
        // A list containing up to 30 instances of collisions

        IList<CollisionData> mCollisionList = new List<CollisionData>(30);

        public override void OnPlacedObject(GameObject pPlacedObject)
        {
            if (pPlacedObject.HasAPhysicalBody())
            {
                this.AddToScene(pPlacedObject.GetPhysicsComponent());
            }
        }

        public override void OnRemovedObject(GameObject pRemovedObject)
        {
            if (pRemovedObject.IsRenderable())
            {
                this.RemoveFromScene(pRemovedObject.GetPhysicsComponent());
            }
        }

        public void Update(ref GameTime pGameTime)
        {
            // resolve forces

            foreach (PhysicsComponent body in mList)
            {

                body.Integrate(ref pGameTime);
            }

            // detect collisions and define the parameters for the collision

            for (int i = 0; i < mList.Count; i++)
            {
                for (int j = (i + 1); j < mList.Count; j++)
                {
                    RecordContact contact = mList[i].CollideWith(mList[j], pGameTime.ElapsedGameTime.Milliseconds);
                    if (contact != null)
                    {
                        mCollisionList.Add(new CollisionData(mList[i], mList[j], contact));
                    }
                }
            }

            // Carry out collision decisions

            CollisionManager.ResolveCollisions(mCollisionList);

            // notify AI of events, addressing the need to inform entities rather than entities ask the collision management system

            TellAICollisions();

            // clears collision list so it does not become clogged with outdated information

            mCollisionList.Clear();
        }

        // Method to address need for collision manager to notify entities and not the other way around

        private void TellAICollisions()
        {

            for (int i = 0; i < mCollisionList.Count; i++)
            {
                mCollisionList[i].First.NotifyCollision(mCollisionList[i].Second);
                mCollisionList[i].Second.NotifyCollision(mCollisionList[i].First);
            }
        }

    }
}
