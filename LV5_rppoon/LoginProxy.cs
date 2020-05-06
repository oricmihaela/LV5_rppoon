using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5_rppoon
{
    class LoginProxy : IDataset
    {
        private Dataset dataset;
        private List<int> allowedIDs;
        public User user { private get; set; }
        public LoginProxy(User user)
        {
            this.allowedIDs = new List<int>(new int[] { 1, 3, 5 });
            this.user = user;
        }
        private bool AuthenticateUser()
        {
            return allowedIDs.Contains(this.user.ID);
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            ConsoleLogger.GetInstance().Log("User " + user.Name + "logged in at " + DateTime.Now.ToShortTimeString());
            return null;
        }
    }
}
