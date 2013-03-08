﻿using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace RIPXNAGame
{
    public abstract class X2DToken : GameObject
    {

        protected X2DToken(String pTokenName)
            : base(pTokenName, Vector3.Zero)
        {
            InjectComponents();
            DefaultProperties();
        }

        public override Dimension Type { get { return Dimension.X2D; } }

        // Initialize Token Default Properties

        private void InjectComponents()
        {
            MainEngine.getInstance().RenderingSystem.Assemble(this);
            MainEngine.getInstance().PhysicsSystem.Assemble(this);
        }

        protected abstract void DefaultProperties();
    }
}
