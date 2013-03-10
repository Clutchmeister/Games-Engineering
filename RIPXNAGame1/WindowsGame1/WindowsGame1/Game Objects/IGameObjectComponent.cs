﻿using System;
using Microsoft.Xna.Framework;

namespace RIPXNAGame
{
    public interface IGameObjectComponent
    {

        // Initialize GameObjectComponent

        /// <param name="pGameObject">Name of Object you wish to intialise</param>
        void OnBind(GameObject pGameObject);
    }
    /* Enumerator to define type. Used to address dynamic typing requirement. May be replaced by template types through later edits.
     Use this with entity manager.*/
    public enum ComponentType
    {
        GRAPH,
        PHYS,
        AI,
        ANIM
    }
}
