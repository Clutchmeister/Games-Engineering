using System;
using System.Collections.Generic;
using RIPXNAGame.Rendering;
using RIPXNAGame.Physics;
using Microsoft.Xna.Framework;

namespace RIPXNAGame
{
    public abstract class GameObject : IComponentContainer
    {

        protected Dictionary<ComponentType, IGameObjectComponent> mComponentSet = null;

        private Vector3 mWorldPosition;
        private Vector3 mOrientation;

        private Vector3 mVelocity;
        private Vector3 mAceleration;

        private Quaternion mRotation;
        private Vector3 mMaxVelocity;
        private Vector3 mMaxRotation;


        // GameObject unique name

        private String mName = null;

        /// <param name="pTokenName">Token Name</param>
        /// <param name="pWorldPosition">Initial World Position</param>
        protected GameObject(String pTokenName, Vector3 pWorldPosition)
        {
            mComponentSet = new Dictionary<ComponentType, IGameObjectComponent>();
            mName = pTokenName;
            Position = pWorldPosition;
        }

        // Name of the Game Object

        public String Name
        {
            get { return mName; }
            private set { mName = value; }
        }

        // World position of the Game Object

        public virtual Vector3 Position
        {
            get { return mWorldPosition; }
            set { mWorldPosition = value; }
        }

        // Orientation of the Game Object

        public Vector3 Orientation
        {
            get { return mOrientation; }
            set { mOrientation = value; mOrientation.Normalize(); }
        }

        /// Velocity : The speed at which the object is moving
        
        public Vector3 Velocity
        {
            get { return mVelocity; }
            set { mVelocity = value; }
        }
        /// <summary>
        /// Acceleration : The rate at which the object is speeding up
        /// </summary>
        public Vector3 Acceleration
        {
            get { return mAceleration; }
            set { mAceleration = value; }
        }

        // Max Velocity : The maximum speed the object can reach
 
        public Vector3 MaxVelocity
        {
            get { return mMaxVelocity; }
            set { mMaxVelocity = value; }
        }

        // Set Game Object Position

        /// <param name="pX">X coordinate</param>
        /// <param name="pY">Y coordinate</param>
        /// <param name="pZ">Z coordinate</param>
        public void SetPosition(float pX, float pY, float pZ)
        {
            mWorldPosition.X = pX;
            mWorldPosition.Y = pY;
            mWorldPosition.Z = pZ;
        }
        #region Component Management

        // Inject component

        /// <param name="pType">Component Type</param>
        /// <param name="pComponentToAdd">Component to Inject</param>
        public void Inject(ComponentType pType, IGameObjectComponent pComponentToAdd)
        {
            if (pComponentToAdd != null)
            {
                pComponentToAdd.OnBind(this);
                mComponentSet.Add(pType, pComponentToAdd);
            }
        }


        // Eject a component

        /// <param name="pType">Component Type to Eject</param>
        public virtual void Eject(ComponentType pType)
        {
            mComponentSet.Remove(pType);
        }

  
        // Get if object is Renderable

        public bool IsRenderable()
        {
            return mComponentSet.ContainsKey(ComponentType.GRAPH);
        }

        // Get if object has a physical body

        public bool HasAPhysicalBody()
        {
            return mComponentSet.ContainsKey(ComponentType.PHYS);
        }


        internal IRenderableObject GetGraphicComponent()
        {
            IGameObjectComponent graphic = null;
            mComponentSet.TryGetValue(ComponentType.GRAPH, out graphic);
            return (IRenderableObject)graphic;
        }

        internal PhysicalBody GetPhysicsComponent()
        {
            IGameObjectComponent phys = null;
            mComponentSet.TryGetValue(ComponentType.PHYS, out phys);
            return (PhysicalBody)phys;
        }

        internal IAIController GetAIComponent()
        {
            IGameObjectComponent ai = null;
            mComponentSet.TryGetValue(ComponentType.AI, out ai);
            return (IAIController)ai;
        }

        #endregion

        #region Editing Properties Accessors

        protected internal IGraphicProperties GraphicProperties
        {
            get { return GetGraphicComponent(); }

        }
        protected internal IPhysicsProperties PhysicsProperties
        {
            get { return GetPhysicsComponent(); }
        }

        #endregion

        // Get Object dimension
  
        public abstract Dimension Type { get; }
    }
}
