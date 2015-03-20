using System.Runtime.Serialization;

namespace TesEdit.Data.Record
{
    public class Hedr : IHedr
    {
        public Hedr()
        {
            
        }

        /// <summary>
        /// Constructor needed for deserialization.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Hedr(SerializationInfo info, StreamingContext context)
        {
        }
        
        public byte[] Version { get; private set; }
        public int NumRecords { get; private set; }
        public ulong NextId { get; private set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}