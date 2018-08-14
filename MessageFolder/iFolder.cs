using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.MessageFolder
{
    /// <summary>
    /// 
    /// </summary>
    public interface iFolder
    {
        /// <summary>
        /// ID of the current folder
        /// </summary>
        int ID { get; }
        
        /// <summary>
        /// Name of the current folder
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// Message count in the current folder
        /// </summary>
        int MessageCount { get; }
        
        /// <summary>
        /// Date current folder was created
        /// </summary>
        DateTime Created { get; }

        /// <summary>
        /// The current owner
        /// </summary>
        int OwnerID { get; }

        /// <summary>
        /// The parent of this folder. Can be null
        /// </summary>
        int? ParentFolderID { get; }

        /// <summary>
        /// Indicates if this is a permanent folder or not
        /// </summary>
        Boolean Permanent { get; }

        /// <summary>
        /// The type of folder
        /// </summary>
        FolderType Type { get; }
    }
}
