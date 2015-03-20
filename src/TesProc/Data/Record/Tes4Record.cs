using System.Runtime.Serialization;

namespace TesEdit.Data.Record
{
    public class Tes4Record : ITes4Record
    {

        static int firstAvailableID = 0xD62;

        public Tes4Record()
        {
            
        }

        /// <summary>
        /// Constructor needed for deserialization.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Tes4Record(SerializationInfo info, StreamingContext context)
        {
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}