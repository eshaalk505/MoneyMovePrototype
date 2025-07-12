using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public sealed class SessionManager
    {
        //holds reference to created instance
        private static SessionManager instance = null;

        //lock needed for instance of SessionManager created
        private static readonly object padlock = new object();
        public string _usernameOfUser { get; private set; }
        public string _forenameOfUser { get; private set; }
        public string _surnameOfUser { get; private set; }


        //private, parameterless constructor- prevents other classes from instantiating it & subclassing (both of which would violate the pattern)
        private SessionManager() { }

        //used for getting details of the currently existing session
        public static SessionManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SessionManager();
                    }
                    return instance;
                }
            }
        }

        //upon successful login, a new session is created and values needed for creating a session are added
        public void CreateSession(string userUsername, string userForename, string userSurname)
        {
            this._usernameOfUser = userUsername;
            this._forenameOfUser = userForename;
            this._surnameOfUser = userSurname;
        }

        //once user is done with their session, it is ended + program is closed
        public void FinishSession()
        {
            _usernameOfUser = null;
            _forenameOfUser = null;
            _surnameOfUser = null;
            Application.Exit();
        }
    }
}
