using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumansAndCanibals.ViewModels
{
    public class Boat
    {
        #region Properties

        /// <summary>
        /// Boolean variable wich indicates whether the boat is loaded or not
        /// </summary>
        public bool IsLoaded { get; protected set; }

        /// <summary>
        /// Possition of the boat
        /// </summary>
        public char Possition { get; protected set; }

        public Shore Passegers { get; protected set; }

        /// <summary>
        /// Last action made by boat
        /// </summary>
        public string LastAction { get; set; }

        #endregion

        #region Constructors

        public Boat(bool isLoaded, char pos, Shore passegers, string lastAction)
        {
            this.IsLoaded = isLoaded;
            this.Possition = pos;
            this.Passegers = passegers;
            this.LastAction = lastAction;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Unloads the boat and return object of type Shore with unloaded passegers
        /// </summary>
        /// <returns>Object of unloaded passagers</returns>
        public Shore Unload()
        {
            Shore unloadedPassegers = this.Passegers.Clone() as Shore;
            this.Passegers = new Shore();
            this.IsLoaded = false;

            return unloadedPassegers;
        }
        /// <summary>
        /// Loads the boat with passagers
        /// </summary>
        /// <param name="passegers">Passagers to be loaded</param>
        public void Load(Shore passegers)
        {
            this.Passegers = passegers.Clone() as Shore;
            this.IsLoaded = true;
        }

        /// <summary>
        /// Change possition of the boat
        /// </summary>
        public void Move()
        {
            this.Possition = this.Possition == 'L' ? 'R' : 'L';
        }

        #endregion
    }
}
