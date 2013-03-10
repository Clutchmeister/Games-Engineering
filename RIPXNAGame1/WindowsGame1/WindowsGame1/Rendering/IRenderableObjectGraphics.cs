using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RIPXNAGame.Resource;

namespace RIPXNAGame.Rendering
{
    interface IRenderableObjectGraphics : IRenderableObject
    {
        Texture2D SpriteMap { get; }
        Rectangle SourceRegion { get; }
        Vector2 Origin { get; }
        Vector3 Orientation { get; }
    }
}
