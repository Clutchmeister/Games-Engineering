using System;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.Rendering
{
    public interface ISceneCamera : IScene
    {
        ICamera CreateCameraAt(String pCameraName, Vector3 pCameraPosition);
    }
}
