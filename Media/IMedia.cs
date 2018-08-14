using System;
using System.Collections.Generic;
using System.Text;

namespace AMailBuisnessCore.Media
{
    interface IMedia
    {
        string Name { get; }
        byte[] Content { get; }
        int ID { get; }
        string GUID { get; }
        string ContentType { get; }
        string Extension { get; }
        System.IO.MemoryStream MediaStream { get; }
        DateTime Created { get; }
    }
}
