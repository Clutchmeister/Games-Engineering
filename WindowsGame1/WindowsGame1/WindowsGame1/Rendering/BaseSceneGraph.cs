using System;
using System.Collections.Generic;
using WindowsGame1.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using WindowsGame1.Utility;
using WindowsGame1.Systems;

namespace WindowsGame1.Rendering
{
    class BaseSceneGraph : ListSceneRepresentation<IRenderableObject>, ISceneGraph
    {

        private IResourceManager mResourceManager;
        private IRenderingSystem mRenderingSystem;

        public BaseSceneGraph(IResourceManager pResourceManager, IRenderingSystem pRenderingSystem)
        {
            mRenderingSystem = pRenderingSystem;
            mResourceManager = pResourceManager;

        }

        public override void OnPlacedObject(GameObject pPlacedObject)
        {
            if (pPlacedObject.GetType() == typeof(X2DCamera))
            {
                mRenderingSystem.SetCamera((X2DCamera)pPlacedObject);
            }
          
            if (pPlacedObject.IsRenderable())
            {
                this.AddToScene(pPlacedObject.GetGraphicComponent());
            }
        }

        public override void OnRemovedObject(GameObject pRemovedObject)
        {
            return;
            if (pRemovedObject.IsRenderable())
            {
                this.RemoveFromScene(pRemovedObject.GetGraphicComponent());
            }
        }


        /// <param name="pRenderableObject"></param>
        public override void AddToScene(IRenderableObject pRenderableObject)
        {
            if (!mList.Contains(pRenderableObject))
            {
                int i = 0;
                for (i = 0; i < mList.Count; i++)
                {
                    if (!(mList.ElementAt(i).WorldPosition.Z < pRenderableObject.WorldPosition.Z))
                    {
                        break;
                    }
                }
                mList.Insert(i, pRenderableObject);
            }
        }


        /// <param name="pVisibleArea"></param>

        public List<IRenderableObject> GetVisibleSet(Rectangle pVisibleArea)
        {
            return mList.ToList();
        }

    }
}
