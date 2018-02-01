using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialDocument.Classes
{
    public class DocumentEventArgs : EventArgs
    {
        public object Document { get; private set; }

        public DocumentEventArgs(object document)
            : base()
        {
            Document = document;
        }

        public DocumentEventArgs() : this(null) { }
    }
}
