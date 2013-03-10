using System;
using RIPXNAGame.Resource;

namespace RIPXNAGame.Systems
{
    public interface IResourceManager : ISceneListener
    {
        void RegisterTo(IScene pScene);
        void Import(AssetLib pAssetLibrary);
        void Load(IScene pScene);
    }
}
