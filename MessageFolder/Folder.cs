using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.MessageFolder
{
    /// <summary>
    /// 
    /// </summary>
    public enum FolderType
    {
        /// <summary>
        /// 
        /// </summary>
        INBOX=1
        , SENT=2
        , TRASH=3
        , USER_DEFINED=4
    }
    /// <summary>
    /// Folder class, inherit iFolder.
    /// </summary>
    public class Folder : iFolder
    {
        /// <summary>
        /// Can be used to spool up a folder based on its ID
        /// </summary>
        /// <param name="ID"></param>
        public Folder(int ID) { this.ID = ID; /*Load Folder contents*/}
        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="MessageCount"></param>
        /// <param name="Created"></param>
        /// <param name="OwnerID">Owner of the folder</param>
        /// <param name="ParentFolderID">The folders parent if there is one Nullable</param>
        /// <param name="PermanentFolder">Indicates if this is permanent folder or not</param>
        /// <param name="type">The folder type -- refer to FolderType enum for types</param>
        public Folder(int ID, string Name, int MessageCount, int OwnerID, int? ParentFolderID, Boolean PermanentFolder, FolderType type, DateTime Created)
        {
            this.ID = ID;
            this.Name = Name;
            this.MessageCount = MessageCount;
            this.Created = Created;
            this.OwnerID = OwnerID;
            this.ParentFolderID = ParentFolderID;
            this.Permanent = PermanentFolder;
            this.Type = type;
        }

        /// <summary>
        /// Create and save a new folder for a user/owner
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="OwnerID"></param>
        /// <param name="ParentFolderID">Nullable</param>
        public Folder(string Name, int OwnerID, int? ParentFolderID=null)
        {
            this.Name = Name;
            this.OwnerID = OwnerID;
            this.ParentFolderID = ParentFolderID;
        }
        /// <summary>
        /// ID of the current folder
        /// </summary>
        public int ID { get; }
        /// <summary>
        /// Name of the current folder
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Message count of the current folder
        /// </summary>
        public int MessageCount { get; }
        /// <summary>
        /// Date created of the current folder
        /// </summary>
        public DateTime Created { get; }

        /// <summary>
        /// The owner of this folder
        /// </summary>
        public int OwnerID { get; }

        /// <summary>
        /// The parent of this folder. Can be null
        /// </summary>
        public int? ParentFolderID { get; protected set; }


        /// <summary>
        /// Indicates if this is a permanent folder or not
        /// </summary>
        public Boolean Permanent { get; }

        /// <summary>
        /// Get the folder type, this only appliles
        /// </summary>
        public FolderType Type { get; }

        


    }
}
