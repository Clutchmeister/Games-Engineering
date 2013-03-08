using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RIPXNAGame
{
    
    // A library of asset

    public class AssetLib {

        // Asset map : key String id

        IDictionary<String, GenericAsset> mAssetMap;
        
        protected AssetLib() {
            mAssetMap = new Dictionary<String, GenericAsset>();
        }

        // Create an empty asset library

        /// <returns>Empty asset library</returns>
        public static AssetLib CreateAnEmptyLibrary() {
            return new AssetLib();
        }

        // Import an asset in the library

        /// <param name="pAsset">Asset to import</param>
        public void ImportAsset(GenericAsset pAsset) {
            Debug.Assert(pAsset != null, "Cannot import a null asset dummy!");
            mAssetMap.Add(pAsset.ID, pAsset);
        }

        // Get an asset by Id

        /// <param name="pAssetID">Id of the asset</param>

        public GenericAsset GetAsset(String pAssetID)
        {
            Debug.Assert(pAssetID != null, "There is no asset ID....How am I supposed to know what to import?!?!?!");
            Debug.Assert(!pAssetID.Equals(""), "ID has to be different than the void string, bah...");
            GenericAsset asset;
            mAssetMap.TryGetValue(pAssetID, out asset);
            return asset;
        }
        }
}

