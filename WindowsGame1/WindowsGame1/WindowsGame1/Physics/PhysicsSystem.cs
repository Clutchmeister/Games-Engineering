﻿using System;
using Microsoft.Xna.Framework;
using RIPXNAGame.Systems;

namespace RIPXNAGame.Physics
{
    class PhysicsSystem : IPhysicsSystem
    {
        private const String REPRESENTATION_NAME = "PhysicsScene";

        private PhysicsSceneGraph mSceneGraph;

        public PhysicsSystem()
        {
            mSceneGraph = new PhysicsSceneGraph();
        }

        public void Update(ref GameTime pGameTime)
        {
            mSceneGraph.Update(ref pGameTime);
        }

        public void Assemble(IScene pScene)
        {
            pScene.AddSceneListener(REPRESENTATION_NAME, new PhysicsSceneGraph());
        }
        public void Assemble(GameObject pObject)
        {
            pObject.Inject(ComponentType.PHYS, new PhysicalBody());
        }

        public void Load(IScene pScene)
        {
            mSceneGraph = (PhysicsSceneGraph)pScene.GetRepresentation(REPRESENTATION_NAME);
        }
    }
}
