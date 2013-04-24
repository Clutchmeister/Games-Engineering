using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RIPXNAGame.Physics;

namespace RIPXNAGame.AI
{
    public abstract class AIPlayer : GameObjectComponent, IAIController
    {
        #region Data Members
        protected IMovementBehaviour mActualMovementBehaviour = null;

        private Game mGame;
        private GameObject mPossessedToken;

        private int mUID;
        private string mUName;
        #endregion

        #region Properties
        public Game Game
        {
            get { return mGame; }
            set { mGame = value; }
        }

        public int UID
        {
            get { return mUID; }
            set { mUID = value; }
        }

        public string UName
        {
            get { return mUName; }
            set { mUName = value; }
        }
        #endregion

        /// <summary>
        /// Associate the controller to a specific Token in the Game
        /// </summary>
        /// <param name="pPossessedToken"></param>
        public void Possess(GameObject pPossessedToken)
        {
            /* injecting the token */
            pPossessedToken.Inject(ComponentType.AI, this);
            mPossessedToken = pPossessedToken;
        }
        /// <summary>
        /// Method inherited as IComponent
        /// </summary>
        /// <param name="pPossessedToken"></param>
        public override void OnBind(GameObject pPossessedToken)
        {
            if (Self != null && Self != pPossessedToken)
            {
                Self.Eject(ComponentType.AI);
            }
            base.OnBind(pPossessedToken);
        }

        public GameObject PossessedToken { 
            get { return mPossessedToken; }
            set { mPossessedToken = value; } }

        protected IPhysicsActuator GetActuator() {
            if (Self == null)
                return null;
            return Self.GetPhysicsComponent(); }

        public abstract void Update(ref GameTime pGameTime);

        public virtual void OnTouch(GameObject pOther)
        {
        }

        public abstract void Initialise(string pName);

    }
}
