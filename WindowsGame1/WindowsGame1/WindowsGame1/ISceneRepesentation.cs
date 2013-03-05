using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1
{



    /// <typeparam name="T">Type of the element in the scene</typeparam>
    public interface ISceneRepresentationTrait<T> : ISceneListener
    {

        // Add an element to scene representation

        /// <param name="pElement">element to add</param>
        void AddToScene(T pElement);

        // Remove an element from scene representation

        /// <param name="pElement">element to remove</param>
        void RemoveFromScene(T pElement);

    }
}
