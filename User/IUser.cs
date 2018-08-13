using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.User
{
    /// <summary>
    /// User Permission Enum
    /// </summary>
    public enum UserPermission
    {
        /// <summary>
        /// Standard User Roll ID
        /// </summary>
        Standard = 1,
        
        /// <summary>
        ///  Admin User Roll ID
        /// </summary>
        Admin = 2
    }

    /// <summary>
    /// Interface for all user types
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// 
        /// </summary>
        int UserID { get; }
        
        /// <summary>
        /// 
        /// </summary>
        string UserName { get; }
        
        /// <summary>
        /// 
        /// </summary>
        string PassWord { get; }
        
        /// <summary>
        /// 
        /// </summary>
        int LoginCount { get; }
        
        /// <summary>
        /// 
        /// </summary>
        UserPermission Permission { get; }

        /// <summary>
        /// When user last logged in
        /// </summary>
        DateTime LastLogin { get; }

        /// <summary>
        /// Default folder for inbox view
        /// </summary>
        int DefaultFolder { get; }
    }
}
