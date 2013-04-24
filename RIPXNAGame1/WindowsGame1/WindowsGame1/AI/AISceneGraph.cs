using System;
using System.Collections.Generic;
using RIPXNAGame.Utility;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using RIPXNAGame;

namespace RIPXNAGame.AI
{
    class AISceneGraph : ListSceneRepresentation<GameObject>
    {

        public override void OnPlacedObject(GameObject pPlacedObject)
        {
            AddToScene(pPlacedObject);
        }

        public override void OnRemovedObject(GameObject pPlacedObject)
        {
            RemoveFromScene(pPlacedObject);
        }

        public void Update(ref GameTime pGameTime)
        {
            //foreach (IAIController controller in mList) {
            GameObject controller;
            for (int i = 0; i < mList.Count; i++)
            {
                controller = mList[i];
                controller.Update(ref pGameTime);
            }
        }
    }
}
