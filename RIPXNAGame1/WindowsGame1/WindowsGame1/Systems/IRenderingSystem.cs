using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RIPXNAGame.Rendering;

namespace RIPXNAGame.Systems
{
    /// <summary>
    /// Class responsible for rendering on screen
    /// </summary>
    interface IRenderingSystem : IEngineSystem
    {
 
        // Initialize the Renderer
  
        /// <param name="pDevice">DeviceManager to modify window and device attributes</param>
        void Init(GraphicsDeviceManager pDevice, IResourceManager pResourceManager);


        // Render the scene

 
        void Render(ref GameTime pGameTime);
        void SetCamera(ICamera pCamera);

    }
}
