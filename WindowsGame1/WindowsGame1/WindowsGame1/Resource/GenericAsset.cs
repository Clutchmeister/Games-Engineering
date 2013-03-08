using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RIPXNAGame
{
  public abstract class GenericAsset {

        protected String mAssetName;
        protected String mAssetID;


        /// <param name="pAssetIdentifier">Asset ID</param>
        /// <param name="pAssetName">Asset Name</param>
        public GenericAsset(String pAssetIdentifier, String pAssetName) {
            mAssetName = pAssetName;
            mAssetID = pAssetIdentifier;
        }

        // Asset Name : shall be a name contained in Content Project

        public String Name { get { return mAssetName; } }
        
        // Asset Id : Used to uniquely identfiy a particular asset
       
        public String ID { get { return mAssetID; } }
    }
}
