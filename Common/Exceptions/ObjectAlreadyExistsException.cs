using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class ObjectAlreadyExistsException: Exception
    {
        public object Object { get; }

        public ObjectAlreadyExistsException() { }

        public ObjectAlreadyExistsException(string message)
            : base(message) { }

        public ObjectAlreadyExistsException(string message, Exception inner)
            : base(message, inner) { }

        public ObjectAlreadyExistsException(string message, object obj)
            : this(message)
        {
            Object = obj;
        }

        protected ObjectAlreadyExistsException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
            // Dobijanje vrednosti dodatnih informacija iz SerializationInfo
            if (info != null)
            {
                // Pristupanje dodatnim podacima koji su serializovani
                // Primer: Ako postoji ključ "CustomProperty" u SerializationInfo, možete ga dohvatiti ovde
                // var customPropertyValue = info.GetString("CustomProperty");
            }
        }
    }
}
