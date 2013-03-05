using System;
using System.Collections.Generic;
using System.Diagnostics;
using WindowsGame1.Resource;

namespace WindowsGame1
{
    class AssetLib
    { 
    // A library of asset

    public class AssetLibrary {

        // Asset map : key String id

        IDictionary<String, GenericAsset> mAssetMap;
        
        protected AssetLibrary() {
            mAssetMap = new Dictionary<String, GenericAsset>();
        }

        // Create an empty asset library

        /// <returns>Empty asset library</returns>
        public static AssetLibrary CreateAnEmptyLibrary() {
            return new AssetLibrary();
        }

        // Import an asset in the library

        /// <param name="pAsset">Asset to import</param>
        public void ImportAsset(GenericAsset pAsset) {
            Debug.Assert(pAsset != null, "Asset to import shall not be null");
            mAssetMap.Add(pAsset.ID, pAsset);
        }

       

        // Get an asset by Id

        /// <param name="pAssetID">Id of the asset</param>

        public GenericAsset GetAsset(String pAssetID)
        {
            Debug.Assert(pAssetID != null, "Asset ID shall not be null");
            Debug.Assert(!pAssetID.Equals(""), "Asset ID shall be different from void string");
            GenericAsset asset;
            mAssetMap.TryGetValue(pAssetID, out asset);
            return asset;
        }
        }
    }
}
