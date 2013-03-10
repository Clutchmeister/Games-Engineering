using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;              // Required to use XNA features.
using RIPXNAGame;                // Required to use the RIPXNAGame Engine, remember to utilise this in classes that require the engines features
using RIPXNAGame.Resource;       // Required to use the RIPXNAGame Engine resource management features, same as above.

namespace FishORama
{
    class TokenTemplate : X2DToken // Tokens HAVE to inherit X2DToken to be built, just like the mind needs AIPlayer
    {
        #region Data Members

        // Reference to the simulation kernel (orchestrator of the whole application).
        private Kernel mKernel;

        // remember to put reference to mind here or any other sub component you wish to connect to a token

        #endregion

        #region Properties


        // Get reference to Kernel. Remember to do this for any other values a token might need
        /// </summary>
        public Kernel Kernel
        {
            get { return mKernel; }
        }

        #endregion

        #region Constructors


        // Constructor for the aquarium.
        // Uses base class to initialize the token name, and adds code to
        // initialize custom members.
        /// </summary
        /// <param name="pTokenName">Name of the token.</param>
        /// <param name="pKernel">Reference to the simulation kernel.</param>
        /// <param name="pWidth">Width of the aquarium.</param>
        /// <param name="pHeight">Height of the aquarium.</param>
        public TokenTemplate(String pTokenName) // pTokenName must be included to identify the token. If it's a scene token it will need the kernel as well as width/height etc. a token that belongs to the scene will need the scene identifier.
            : base(pTokenName)
        {
            
        }

        #endregion

        #region Methods

        /* LEARNING PILL: Token default properties.
         * In the XNA Machinationis Ratio engine tokens have properties that define
         * how the behave and are visualized. Using the DefaultProperties method 
         *  it is possible to assign deafult values to the token's properties,
         * after the token has been created.
         */

        /// <summary>
        /// Setup default values for this token's porperties.
        /// </summary>
        protected override void DefaultProperties()
        {
            // Specify which image should be associated to this token, assigning
            // the name of the graphic asset to be used ("AquariumVisuals" in this case)
            // to the property 'GraphicProperties.AssetID' of the token.
            this.GraphicProperties.AssetID = ""; // use this to set the graphics of the token.

            // Remember to create the mind and associate it with the token in this default properties method
        }

        #endregion
    }
}