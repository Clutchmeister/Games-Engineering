using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame.Systems;
using RIPXNAGame.Rendering;

namespace RIPXNAGame.Managers
{
    interface ISceneManager
    {
        void Place(GameObject pGameObject, Vector3 pPosition);

        void Remove(GameObject pGameObject);

        void RegisterTo(IScene pScene);

        void Load(IScene pScene);
    }
}
