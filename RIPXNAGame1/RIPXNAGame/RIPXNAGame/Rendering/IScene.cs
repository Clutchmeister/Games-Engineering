using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame.Systems;
using RIPXNAGame.Rendering;

namespace RIPXNAGame
{
    public interface IScene
    { 
        Dimension Dimension { get; }

        ISceneListener GetRepresentation(string pIdentifier);

        void AddSceneListener(string pIdentifier, ISceneListener pScene);
    }
}

