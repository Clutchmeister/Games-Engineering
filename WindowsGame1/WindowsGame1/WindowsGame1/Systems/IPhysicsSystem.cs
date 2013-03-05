using System;
using Microsoft.Xna.Framework;

namespace WindowsGame1.Systems
{
    interface IPhysicsSystem : IEngineSystem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pGameTime"></param>
        void Update(ref GameTime pGameTime);
    }
}
