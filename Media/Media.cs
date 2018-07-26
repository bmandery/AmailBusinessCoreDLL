using System;
using System.Collections.Generic;
using System.Text;

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
            this.Extension = Name.Substring(Name.IndexOf('.') + 1, Name.Length - Name.IndexOf('.') - 1);
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

        }

        /// <summary>
        /// Return a byte[] for a given stream
        /// </summary>
        /// <param name="s">The stream to read from</param>
        /// <returns>byte[] array</returns>
        public static byte[] ToByteArray(System.IO.Stream s)
        {
            //Create byte array
            byte[] mediaBits = new byte[s.Length];
            //read from stream into byte array
            try
            {
                s.Read(mediaBits, 0, (int)s.Length);
            }
            catch(System.IO.IOException)
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
    }
}
