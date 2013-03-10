using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RIPXNAGame.Resource
{

        // 2D Asset
        public class GameAsset : GenericAsset
        {

            private Vector2 mOrigin;
            private Rectangle mImageDimension;
            private Texture2D mSpriteMap;
            private Vector2 mTopLeftCorner;


            public GameAsset(String pAssetIdentifier, String pAssetName)
                : base(pAssetIdentifier, pAssetName)
            {
            }


            // Origin coordinates in UV coordinates.

            Vector2 UWOriginCoordinates { get { return mOrigin; } }

            #region External Interface Method

            // Place the origin at the desired co-ordinates

            public GameAsset UVOriginAt(uint pU, uint pV)
            {
                mOrigin.X = pU;
                mOrigin.Y = pV;
                return this;
            }

            public GameAsset UVTopLeftCornerAt(uint pX, uint pY)
            {
                mTopLeftCorner.X = pX;
                mTopLeftCorner.Y = pY;
                return this;
            }

            public GameAsset Width(uint pWidth)
            {
                mImageDimension.Width = (int)pWidth;
                return this;
            }

            public GameAsset Height(uint pHeight)
            {
                mImageDimension.Height = (int)pHeight;
                return this;
            }
            #endregion


            internal Texture2D SpriteMap { get { return mSpriteMap; } set { mSpriteMap = value; } }
            internal Vector2 UVOrigin { get { return mOrigin; } }
            internal Vector2 UVTopLeftCorner { get { return mTopLeftCorner; } }
            internal int SpriteWidth { get { return mImageDimension.Width; } }
            internal int SpriteHeight { get { return mImageDimension.Height; } }

        }
    }

