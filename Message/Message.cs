﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.Message
{
    /// <summary>
    /// 
    /// </summary>
    public class Message : iMessage
    {
        private AMailBuisnessCore.Media.MediaCollection _attachmentCollection;
        /// <summary>
        /// Constructor w/o media attachment data
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <param name="AuthorID"></param>
        /// <param name="RecipientID"></param>
        /// <param name="Status"></param>
        /// <param name="GUID"></param>
        /// <param name="Sent"></param>
        /// <param name="AuthorFullName"></param>
        /// <param name="AuthorUserName"></param>
        /// <param name="RecipientFullName">Full name of the receipient</param>
        /// <param name="RecipientUserName">User name of the receipient</param>
        /// <param name="ArchiveDate">The date the message was archived -- Can be null</param>
        public Message(int ID, string Subject, string Body, int AuthorID, int RecipientID, int Status, string GUID, string AuthorUserName, string AuthorFullName, string RecipientFullName, string RecipientUserName, DateTime Sent, DateTime? ArchiveDate)
        {
            this.ID = ID;
            this.Subject = Subject;
            this.Body = Body;
            this.AuthorID = AuthorID;
            this.RecipientID = RecipientID;
            this.Status = Status;
            this.GUID = GUID;
            this.AuthorUserName = AuthorUserName;
            this.AuthorFullName = AuthorFullName;
            this.Sent = Sent;
            this.RecipientFullName = RecipientFullName;
            this.RecipientUserName = RecipientUserName;
            this.ArchiveDate = ArchiveDate;
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
        public int RecipientID { get; }
            
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

        /// <summary>
        /// ID of the media file attachment
        /// </summary>
        public int MediaID { get; }

        /// <summary>
        /// Name of the media file attachment
        /// </summary>
        public string MediaName { get; }

        /// <summary>
        /// Full name or the Receipient
        /// </summary>
        public string RecipientFullName { get; }

        /// <summary>
        /// User name of the receipient
        /// </summary>
        public string RecipientUserName { get; }

        /// <summary>
        /// 
        /// </summary>
        public Media.MediaCollection MyAttachments
        {
            get => _attachmentCollection ?? (_attachmentCollection = new Media.MediaCollection(this.ID));
        }

        /// <summary>
        /// The date the message was archived, can be null.
        /// </summary>
        public DateTime? ArchiveDate { get; }


    }
}
