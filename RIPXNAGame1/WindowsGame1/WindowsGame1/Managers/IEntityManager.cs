using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace RIPXNAGame
{
    public interface IEntityManager
    {
        #region Data Members

        #endregion

        #region Properties
        #endregion


        GameObject Create(string pEntityType);

        void Initialise(GameObject pGameObject, string EntityName, Vector3 pPosition);

        void Remove(int UID);

        void Remove(GameObject entity);

        GameObject Fetch(int UID);

        GameObject Fetch(string uName);

        void Load(IScene pScene, MainGame pGame);

    }
}
