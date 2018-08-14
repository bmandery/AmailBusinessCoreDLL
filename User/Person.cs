using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.User
{
    /// <summary>
    /// Abstract class person, inherited by user
    /// </summary>
    public abstract class Person : IUser
    {
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Nullable field
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The GUID that is created when the person data is saved to the db
        /// </summary>
        public string GUID { get; set; }

        //Interface Requirements

        /// <summary>
        /// Get the ID of the current user
        /// </summary>
        public int UserID { get; protected set; }
        
        /// <summary>
        /// Get the permissions the given user has
        /// </summary>
        public UserPermission Permission { get; protected set; }
        
        /// <summary>
        /// Get UserName of the current user
        /// </summary>
        public string UserName { get; protected set; }
        
        /// <summary>
        /// Get password for the current user
        /// </summary>
        public string PassWord { get; protected set; }

        /// <summary>
        /// Get the login count for the given user
        /// </summary>
        public int LoginCount { get; protected set; }

        /// <summary>
        /// Last login of the current user
        /// </summary>
        public DateTime LastLogin { get; protected set; }

        /// <summary>
        /// Default folder for inbox view
        /// </summary>
        public int DefaultFolder { get; protected set; }
    }
}
