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
        /// New Message Status
        /// </summary>
        NEW = 0,

        /// <summary>
        /// Sent Message Status
        /// </summary>
        SENT = 1,

        /// <summary>
        /// Unread Message Status
        /// </summary>
        UNREAD = 2,

        /// <summary>
        /// Archived (trashed) Message Status
        /// </summary>
        ARCHIVED = 4,

        /// <summary>
        /// Forwarded Message Status
        /// </summary>
        FORWARDED = 8,

        /// <summary>
        /// Attachment y/n Status
        /// </summary>
        CONTAINS_ATTACHMENT = 16,

        /// <summary>
        /// Message Replied Flag
        /// </summary>
        REPLIED = 32,

        /// <summary>
        /// Message Read Status
        /// </summary>
        READ = 64        
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
        int RecipientID { get; }
        
        /// <summary>
        /// Subject of the current message
        /// </summary>
        string Subject { get; }
        
        /// <summary>
        /// Body of the current message
        /// </summary>
        string Body { get; }
        
        /// <summary>
        /// Status codes of the current message(each bit means something)
        /// Ex. 0=NEW
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

        /// <summary>
        /// Full name or the Receipient
        /// </summary>
        string RecipientFullName { get; }

        /// <summary>
        /// User name of the receipient
        /// </summary>
        string RecipientUserName { get; }

        /// <summary>
        /// The date the message was archived, can be null.
        /// </summary>
        DateTime? ArchiveDate { get; }
    }
}
