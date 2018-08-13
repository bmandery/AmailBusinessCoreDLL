using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.User
{
    /// <summary>
    /// Class for the standard user type
    /// </summary>
    public class StandardUser : Person, IUser
    {
        /// <summary>
        /// Create a standard user
        /// </summary>
        /// <param name="FirstName">Users First Name</param>
        /// <param name="LastName">users Last Name</param>
        /// <param name="DateOfBirth">Users Date of Birth</param>
        /// <param name="UserName">Users User name</param>
        /// <param name="PassWord">Users Password</param>
        /// <param name="UserID">Users ID in the DB</param>
        /// <param name="GUID">The GUID assigned to the person when saved to the db</param>
        /// <param name="DefaultFolderID">The default folder to pull up when the current user views their inbox</param>
        public StandardUser(int UserID, string FirstName, string LastName, DateTime? DateOfBirth, string UserName, string PassWord, string GUID, int DefaultFolderID)
        {
            this.UserID = UserID;
            base.FirstName = FirstName;
            base.LastName = LastName;
            base.DateOfBirth = DateOfBirth;
            base.GUID = GUID;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permission = UserPermission.Standard;
            this.DefaultFolder = DefaultFolderID;
        }     
    }
}
