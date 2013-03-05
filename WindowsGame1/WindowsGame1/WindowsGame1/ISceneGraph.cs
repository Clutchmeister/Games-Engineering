using System;
using Microsoft.Xna.Framework;

namespace WindowsGame1
{
    public interface ISceneGraph : ISceneRepresentationTrait<// Renderable Object interface reference goes here>
    {

        // Return visible set of graphic objects inside visible area

        /// <param name="pVisibleArea">Rectangle</param>
        /// <returns>List of Graphics</returns>

        // Make a list using the the Renderable Object interface, then get the visible set utilising rectangles.
    }
}
