using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace RIPXNAGame
{
    public abstract class X2DToken : GameObject
    {

        public override Dimension Type { get { return Dimension.X2D; } }


        // Initialize Token Default Properties
        public override void Initialise()
        {
            InitialiseEntity(UName, new Vector3(0, 0, 0));
            InjectComponents();
            DefaultProperties();
            IsRenderable();
            HasAPhysicalBody();
        }

        private void InjectComponents()
        {
            MainGame.getInstance().RenderingSystem.Assemble(this);
            MainGame.getInstance().PhysicsSystem.Assemble(this);
        }

        public void SetGraphic(string pAssetName)
        {
            this.GraphicProperties.AssetID = pAssetName;
        }

        protected abstract void DefaultProperties();
    }
}
