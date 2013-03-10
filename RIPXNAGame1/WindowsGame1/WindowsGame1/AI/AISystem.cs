using System;
using System.Collections.Generic;
using RIPXNAGame.Systems;
using Microsoft.Xna.Framework;

namespace RIPXNAGame.AI
{
    class AISystem : IAISystem
    {
        private AISceneGraph mSceneGraph;

        public AISystem()
        {
            mSceneGraph = new AISceneGraph();
        }

        public void Assemble(IScene pScene)
        {

            pScene.AddSceneListener("AIScene", mSceneGraph);
        }

        public void Assemble(GameObject pGameObject)
        {

        }
     
        public void Load(IScene pScene)
        {
            mSceneGraph = (AISceneGraph)pScene.GetRepresentation("AIScene");
        }
     
        public void Update(ref GameTime pGameTime)
        {
            mSceneGraph.Update(ref pGameTime);
        }
    }
}
