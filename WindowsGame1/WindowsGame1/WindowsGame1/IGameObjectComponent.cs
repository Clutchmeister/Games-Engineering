using System;
using Microsoft.Xna.Framework;

namespace WindowsGame1
{
    public interface IGameObjectComponent
    {

        // Initialize GameObjectComponent

        /// <param name="pGameObject">Name of Object you wish to intialise</param>
        void OnBind(GameObject pGameObject);
    }
    /* #PILL# Enum Type */
    public enum ComponentType
    {
        GRAPHICS,
        PHYSICS,
        AI,
        ANIMATION
    }
}
