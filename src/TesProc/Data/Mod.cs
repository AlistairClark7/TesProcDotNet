using TesEdit.Data.Record;
using TesEdit.Serialization;

namespace TesEdit.Data
{
    public class Mod : IMod
    {
        public ITes4Record Tes4Record { get; set; }

        public Mod()
        {
        }

        public Mod(ModReader modStream)
        {
            
        }
    }
}