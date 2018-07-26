using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.Message
{
    /// <summary>
    /// Simple message status enum
    /// </summary>
    public enum MessageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        NEW=0,
        /// <summary>
        /// 
        /// </summary>
        Sent=1,
        /// <summary>
        /// 
        /// </summary>
        UNREAD=2,
        /// <summary>
        /// 
        /// </summary>
        ARCHIVED=4,
        /// <summary>
        /// 
        /// </summary>
        FORWARDED=8,
        /// <summary>
        /// 
        /// </summary>
        CONTAINS_ATTACHMENT=16
    }
    /// <summary>
    /// Interface for all message objects
    /// </summary>
    public interface iMessage
    {
        /// <summary>
        /// ID of the current mesasge
        /// </summary>
        int ID { get; }
        /// <summary>
        /// Author ID of the current message
        /// </summary>
        int AuthorID { get; }
        /// <summary>
        /// Receipient ID of the current message
        /// </summary>
        int ReceipientID { get; }
        /// <summary>
        /// Subject of the current message
        /// </summary>
        string Subject { get; }
        /// <summary>
        /// Body of the current message
        /// </summary>
        string Body { get; }
        /// <summary>
        /// Status codes of the current message(each bits means sometime)
        /// 0=new
        /// </summary>
        int Status { get; }
        /// <summary>
        /// GUID of the current message
        /// </summary>
        string GUID { get; }
        /// <summary>
        /// Time the message was sent
        /// </summary>
        DateTime Sent { get; }

        /// <summary>
        /// user name of the author of the current message
        /// </summary>
        string AuthorUserName { get; }

        /// <summary>
        /// Full name of the author of the current message
        /// </summary>
        string AuthorFullName { get; }
    }
}
