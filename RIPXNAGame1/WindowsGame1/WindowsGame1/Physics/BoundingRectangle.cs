using System;
using Microsoft.Xna.Framework;
using RIPXNAGame;
using RIPXNAGame.Utility;
using RIPXNAGame.Systems;
using RIPXNAGame.Rendering;
using System.Collections.Generic;

namespace RIPXNAGame.Physics
{
    class BoundingRectangle
    {
        // Possible improvement for final submission instead of bounding rectangles

        private PhysicalBody mBody;
        private Rectangle spriteRectangle;
        protected IList<GameObject> mObjectList;

        public BoundingRectangle(PhysicalBody body)
        {
            mBody = body;
        }

        public Vector3 Center
        {
            get { return mBody.WorldPosition; }
        }

        public createBox()
        {
         foreach (GameObject gameObject in mObjectList)
         {
             spriteRectangle = new Rectangle(gameObject.mWorldPosition.position.X, RenderableObject.WorldPosition.Y, RenderableObject.texture.Width, RenderableObject.texture.Height)
         }
        }
    }
}
