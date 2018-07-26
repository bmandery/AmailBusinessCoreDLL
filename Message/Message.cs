using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.Message
{
    /// <summary>
    /// 
    /// </summary>
    public class Message : iMessage
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <param name="AuthorID"></param>
        /// <param name="ReceipientID"></param>
        /// <param name="Status"></param>
        /// <param name="GUID"></param>
        /// <param name="Sent"></param>
        /// <param name="AuthorFullName"></param>
        /// <param name="AuthorUserName"></param>
        public Message(int ID, string Subject, string Body, int AuthorID, int ReceipientID, int Status, string GUID, string AuthorUserName, string AuthorFullName, DateTime Sent)
        {
            this.ID = ID;
            this.Subject = Subject;
            this.Body = Body;
            this.AuthorID = AuthorID;
            this.ReceipientID = ReceipientID;
            this.Status = Status;
            this.GUID = GUID;
            this.AuthorUserName = AuthorUserName;
            this.AuthorFullName = AuthorFullName;
            this.Sent = Sent;
        }
        /// <summary>
        /// Database ID of the current message
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Author ID of the current message
        /// </summary>
        public int AuthorID { get; }

        /// <summary>
        /// Receipient ID of the current message
        /// </summary>
        public int ReceipientID { get; }
            
        /// <summary>
        /// Subject of the current message
        /// </summary>
        public string Subject { get; }

        /// <summary>
        /// Body of the current message
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Status of the current message
        /// </summary>
        public int Status { get; }

        /// <summary>
        /// GUID of the current message
        /// </summary>
        public string GUID { get; }

        /// <summary>
        /// Sent time stamp of the current message
        /// </summary>
        public DateTime Sent { get; }

        /// <summary>
        /// user name of the author of the current message
        /// </summary>
        public string AuthorUserName { get; }

        /// <summary>
        /// Full name of the author of the current message
        /// </summary>
        public string AuthorFullName { get; }

    }
}
