using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.Rendering
{
    public interface ISceneGraph : ISceneRepresentationTrait<IRenderableObject>
    {

        // Return visible set of graphic objects inside visible area

        /// <param name="pVisibleArea">Rectangle</param>
        /// <returns>List of Graphics</returns>
        List<IRenderableObject> GetVisibleSet(Rectangle pVisibleArea);
    }
}
