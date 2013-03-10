using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.Rendering
{
    internal class CameraFactory
    {
        /// <summary>
        /// Create a Base fixed camera with a name
        /// </summary>
        /// <param name="pCameraName">Name of created camera</param>
        /// <returns>2D Camera</returns>
        public static X2DCamera Create2DCamera(string pCameraName)
        {
            return new X2DCamera(pCameraName, Vector3.Zero);
        }

    }
}
