using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace RIPXNAGame
{

    // Object's component

    public abstract class GameObjectComponent : IGameObjectComponent
    {

        // Reference to GameObject

        protected GameObject Self;

        // On the binding of a specific component to game object

        /// <param name="pGameObject">object binded</param>
        public virtual void OnBind(GameObject pGameObject)
        {
            Debug.Assert(pGameObject != null, "I'm afraid you cannot have a null object!");
            Self = pGameObject;
        }
        public void SetWorldPosition(Vector3 pPosition)
        {
            Self.SetPosition(pPosition.X, pPosition.Y, pPosition.Z);
        }
        public Vector3 WorldPosition
        {
            get
            {
                return Self.Position;
            }
        }
    }
}
