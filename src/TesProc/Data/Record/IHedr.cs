namespace TesEdit.Data.Record
{
    public interface IHedr : IRecord
    {
        byte[] Version { get; }
        int NumRecords { get; }
        ulong NextId { get; } 
    }
}