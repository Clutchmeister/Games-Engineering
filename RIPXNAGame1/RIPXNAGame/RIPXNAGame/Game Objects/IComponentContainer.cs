using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIPXNAGame
{
    public interface IComponentContainer
    {


        // Inject a Component within the container

        /// <param name="pType">Type of the component I.E. AI (mind class)</param>
        /// <param name="pComponentToAdd">Component to Inject</param>
        void Inject(ComponentType pType, IGameObjectComponent pComponentToAdd);


        // Eject a Component within the container

        /// <param name="pType">Type of the component to eject I.E. AI</param>
        void Eject(ComponentType pType);
    }
}