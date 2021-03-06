﻿namespace Spm.Shared
{
    public struct ConnectionData
    {
        public ConnectionData(string servName, string useName, string pass, string db)
        {
            ServerName = servName;
            UserName = useName;
            Password = pass;
            Database = db;
        }

        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }        
        public string Database { get; set; }
    }
}
