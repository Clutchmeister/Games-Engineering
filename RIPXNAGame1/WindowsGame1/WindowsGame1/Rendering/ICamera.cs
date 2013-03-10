using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RIPXNAGame.Rendering;

namespace RIPXNAGame.Rendering
{
    public interface ICamera {
 
        // Camera Position

        Vector3 Position { get; set; }

        // Render the scene from the POV of the camera

        void RenderScene();
        void Init(GraphicsDevice pDevice);
        void PresentScene(ISceneGraph pSceneGraph);
        Vector3 CameraToWorld(Vector2 pScreenPosition);
    }
}
