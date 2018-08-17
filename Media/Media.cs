using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;


namespace AMailBuisnessCore.Media
{
    /// <summary>
    /// 
    /// </summary>
    public class Media : IMedia
    {
        /// <summary>
        /// 
        /// </summary>
        public Media() { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="Name"></param>
        /// <param name="ContentType"></param>
        public Media(byte[] Content, string Name, string ContentType)
        {
            this.Content = Content;
            this.Name = Name;
            this.ContentType = ContentType;
            this.Extension = Name.Substring(Name.LastIndexOf('.') + 1, Name.Length - Name.LastIndexOf('.') - 1);
        }
        
        /// <summary>
        /// Full constuctor 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="Content"></param>
        /// <param name="GUID"></param>
        /// <param name="ContentType"></param>
        /// <param name="Extension"></param>
        /// <param name="Created"></param>
        public Media(int ID, string Name, byte[] Content, string GUID, string ContentType, string Extension, DateTime Created)
        {
            this.ID = ID;
            this.Name = Name;
            this.Content = Content;
            this.GUID = GUID;
            this.ContentType = ContentType;
            this.Extension = Extension;
            this.Created = Created;
        }

        /// <summary>
        /// Return a byte[] for a given stream
        /// </summary>
        /// <param name="s">The stream to read from</param>
        /// <returns>byte[] array</returns>
        public static byte[] ToByteArray(Stream s)
        {
            //Create byte array
            byte[] mediaBits = new byte[s.Length];
            //read from stream into byte array
            try
            {
                s.Read(mediaBits, 0, (int)s.Length);
            }
            catch(IOException)
            {
                //Throw exception to preserve the stack trace
                throw;
            }

            //return byte array to called
            return mediaBits;
            
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] Content { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GUID { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ContentType { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Extension { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime Created { get; protected set; }

        /// <summary>
        /// The Memory stream for this piece of media
        /// </summary>
        public MemoryStream MediaStream { get => new MemoryStream(this.Content); }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MediaCollection : CollectionBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MessageID"></param>
        public MediaCollection(int MessageID)
        {
            //Go get media for message
            AmailDataCore.MediaData _mediaData = new AmailDataCore.MediaData();
            System.Data.DataTable dt = _mediaData.GetMediaByMessage(MessageID);
            System.Data.DataView dv = new System.Data.DataView(dt);

            foreach(System.Data.DataRowView drv in dv)
            {
                List.Add(new Media(
                        Int32.Parse(drv["intMediaID"].ToString())
                        , drv["strName"].ToString()
                        , (byte[])drv["binMedia"]
                        , drv["guid"].ToString()
                        , drv["strContentType"].ToString()
                        , drv["strExtension"].ToString()
                        , DateTime.Parse(drv["dtCreated"].ToString())));
            }
        }
        
        /// <summary>
        /// Turn the collection into a generic List of type Media 
        /// </summary>
        public List<Media> ToList
        {
            //By doing this, it will allow you to use Find(predicate)
            get
            {
                List<Media> media = new List<Media>();
                foreach(object o in base.List)
                {
                    media.Add((Media)o);
                }
                return media;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Media this[int index]
        {
            get { return (Media)List[index]; }
        }
    }
}
