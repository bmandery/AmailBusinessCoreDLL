using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AMailBuisnessCore.Media
{
    interface IMedia
    {
        string Name { get; }
        string ShortName { get; }
        byte[] Content { get; }
        int ID { get; }
        string GUID { get; }
        string ContentType { get; }
        string Extension { get; }
        MemoryStream MediaStream { get; }
        DateTime Created { get; }
    }
}
