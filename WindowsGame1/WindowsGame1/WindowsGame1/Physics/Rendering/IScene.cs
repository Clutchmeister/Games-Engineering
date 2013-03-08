using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame.Systems;
using RIPXNAGame.Rendering;

namespace RIPXNAGame
{
    public interface IScene
    {
        void Place(GameObject pGameObject, Vector3 pPosition);
        
        void Remove(GameObject pGameObject);
        
        Dimension Dimension { get; }
        
        void AddSceneListener(string pIdentifier,ISceneListener pScene);

        ISceneListener GetRepresentation(string pIdentifier);
    }
}

