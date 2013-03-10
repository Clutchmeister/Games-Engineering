using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RIPXNAGame.Resource;

namespace RIPXNAGame.Rendering
{
    public interface IRenderableObject : IGameObjectComponent, IGraphicProperties
    {
        GenericAsset Asset { get; set; }
        Vector3 WorldPosition { get; }
    }
}
