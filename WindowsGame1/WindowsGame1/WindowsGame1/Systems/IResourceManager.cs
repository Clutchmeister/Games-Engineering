using System;
using WindowsGame1.Resource;

namespace WindowsGame1.Systems
{
    public interface IResourceManager : ISceneListener
    {
        void RegisterTo(IScene pScene);
        void Import(AssetLib pAssetLibrary);
        void Load(IScene pScene);
    }
}
