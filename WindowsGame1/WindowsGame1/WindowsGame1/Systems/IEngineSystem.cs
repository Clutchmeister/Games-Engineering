using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIPXNAGame.Systems
{
    public interface IEngineSystem
    {
        void Assemble(IScene pScene);
        void Assemble(GameObject pGameObject);
        void Load(IScene pScene);

    }
}
