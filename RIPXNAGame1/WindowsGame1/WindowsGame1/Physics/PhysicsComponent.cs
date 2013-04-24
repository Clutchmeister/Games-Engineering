using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame.Utility;

namespace RIPXNAGame.Physics
{
    public class PhysicsComponent : GameObjectComponent, IPhysicsProperties, IPhysicsActuator
    {

        private const float DEFAULT_INVERSE_MASS = 1.0f;

        private Vector3 mForceAccumulator;
        private float mInverseMass;
        private Rectangle mBoundingVolume; // The bounding rectangle
        private bool mIsBlockable;
        private bool mIsMovable;

        public PhysicsComponent()
        {
            mInverseMass = DEFAULT_INVERSE_MASS;
        }
        /// <summary>
        /// Add a force to the game object
        /// </summary>
        /// <param name="pForce"></param>
        public void AddForce(Vector3 pForce)
        {
            mForceAccumulator = Vector3.Add(mForceAccumulator, pForce);
        }

        internal void Move(float pX, float pY, float pZ)
        {
            SetWorldPosition(Vector3.Add(Self.Position, new Vector3(pX, pY, pZ)));
        }

        public void Integrate(ref GameTime pGameTime)
        {
            // update position
            SetWorldPosition(Vector3.Add(Self.Position, Vector3.Multiply(Self.Velocity, (float)pGameTime.ElapsedGameTime.TotalSeconds)));
            // acceleration = Force * inversemass
            Vector3 resultingacceleration = Vector3.Multiply(mForceAccumulator, mInverseMass);
            // update acceleration
            Self.Acceleration = Vector3.Add(Self.Acceleration, resultingacceleration);
            // velocity = velocity + acceleration * time            
            Self.Velocity = Vector3.Add(Self.Velocity, Vector3.Multiply(mForceAccumulator, (float)pGameTime.ElapsedGameTime.TotalSeconds));
            // reset force accumulator
            mForceAccumulator = Vector3.Zero;
        }

        // method to record a new collision

        internal RecordContact collideWith(Rectangle other, long pGameTime)
        {

            if ((mBoundingVolume.Intersects(other)))
            {
                return new RecordContact(pGameTime);
            }
            return null;
        } 

        // If there is a bounding volume, record collision

         internal RecordContact CollideWith(PhysicsComponent pOther, long pGameTime)
        {
            if (mBoundingVolume == null)
                return null;
            return this.collideWith(pOther.mBoundingVolume, pGameTime);
        }

    

        
        public float Mass
        {
            get { return 1.0f / mInverseMass; }
            set
            {
                if (value < 1.0f)
                    mInverseMass = DEFAULT_INVERSE_MASS;
                else
                    mInverseMass = 1 / value;
            }
        }

   

        public IPhysicsProperties SetBlockable(bool pIsBlockable)
        {
            mIsBlockable = pIsBlockable;
            return this;
        }

        public IPhysicsProperties SetMovable(bool pIsMovable)
        {
            mIsMovable = pIsMovable;
            return this;
        }

        // enter physical body characteristics here

        public bool IsBlockable()
        {
            return mIsBlockable;
        }


        // Defines whether an object is movable or isn't (I.E. A wall)

        internal bool IsMovable()
        {
            return mIsMovable;
        }

        // Listens for collisions so it can identify the event

        internal void NotifyCollision(PhysicsComponent physicalBody)
        {
            ICollisionListener collisionListener = Self.GetAIComponent();
            if (null != collisionListener)
            {
                collisionListener.OnTouch(physicalBody.Self);
            }
        }
    }
}
