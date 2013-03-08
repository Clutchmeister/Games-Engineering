using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame;
using RIPXNAGame.Rendering;
using RIPXNAGame.Systems;

namespace RIPXNAGame.Rendering
{
    internal class X2DScene : Scene, ISceneCamera
    {
        public X2DScene(int pWidth, int pHeight, int pDepth) : base(pWidth, pHeight, pDepth)
        {
            mSceneDimension = Dimension.X2D;
        }

        // Create a camera at a specified locaion

        /// <param name="pCameraName">Camera name</param>
        /// <param name="pCameraPosition">Camera position</param>
        /// <returns>2D Camera</returns>
        public ICamera CreateCameraAt(String pCameraName, Vector3 pCameraPosition)
        {
            X2DCamera camera = CameraFactory.Create2DCamera(pCameraName);
            this.Place(camera, pCameraPosition);
            return camera;
        }
    }
}
