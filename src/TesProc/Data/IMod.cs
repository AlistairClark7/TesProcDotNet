using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TesEdit.Data.Record;

namespace TesEdit.Data
{
    public interface IMod : ISerializable
    {
        ITes4Record Tes4Record { get; }

        IEnumerable<IGrup> Grups { get; }

        /// <summary>
        /// Accessor for the IGrup of GrupTypeEnum.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IGrup this[GrupTypeEnum type] { get; }
    }
}