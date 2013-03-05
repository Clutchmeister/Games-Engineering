using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1
{
    public interface IComponentContainer
    {


        // Inject a Component within the container

        /// <param name="pType">Type of the component I.E. AI</param>
        /// <param name="pComponentToAdd">Component to Inject</param>
        void Inject(ComponentType pType, IGameObjectComponent pComponentToAdd);

        /// <summary>
        /// Eject a Component from the container
        /// </summary>
        /// <param name="pType">Type of the component to eject I.E. AI</param>
        void Eject(ComponentType pType);
    }
}