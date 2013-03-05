using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using WindowsGame1.Systems;
using WindowsGame1.Rendering;

namespace WindowsGame1
{
    interface IScene
    {
        void Place(GameObject pGameObject, Vector3 pPosition);
        
        void Remove(GameObject pGameObject);
        
        Dimension Dimension { get; }
        
        void AddSceneListener(string pIdentifier,ISceneListener pScene);

        ISceneListener GetRepresentation(string pIdentifier);
    }
}

