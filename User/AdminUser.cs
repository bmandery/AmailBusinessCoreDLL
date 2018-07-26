using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.User
{
    /// <summary>
    /// Class for the administrator user type
    /// </summary>
    public class AdminUser : Person, IUser
    {
        /// <summary>
        /// Create a admin user
        /// </summary>
        /// <param name="FirstName">Users First Name</param>
        /// <param name="LastName">users Last Name</param>
        /// <param name="DateOfBirth">Users Date of Birth</param>
        /// <param name="UserName">Users User name</param>
        /// <param name="Password">Users Password</param>
        /// <param name="UserID">Users ID in the db</param>
        /// <param name="GUID">The GUID assigned to the person when saved to the db</param>
        /// <param name="DefaultFolderID">Default folder to view when current user views their inbox</param>
        public AdminUser(int UserID, string FirstName, string LastName, DateTime? DateOfBirth, string UserName, string Password, string GUID, int DefaultFolderID)
        {
            this.UserID = UserID;
            base.FirstName = FirstName;
            base.LastName = LastName;
            base.GUID = GUID;
            base.DateOfBirth = DateOfBirth;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permission = UserPermission.Admin;
            this.DefaultFolder = DefaultFolderID;
        }
    }
}
