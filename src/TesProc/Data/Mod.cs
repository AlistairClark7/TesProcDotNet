using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TesEdit.Data.Record;
using TesEdit.Serialization;

namespace TesEdit.Data
{
    [Serializable]
    public class Mod : IMod
    {
        public ITes4Record Tes4Record { get; set; }
        public IEnumerable<IGrup> Grups { get; private set; }

        public IGrup this[GrupTypeEnum type]
        {
            get { throw new NotImplementedException(); }
        }

        public Mod()
        {
        }

        /// <summary>
        /// Constructor needed for deserialization.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Mod(SerializationInfo info, StreamingContext context)
        {
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}