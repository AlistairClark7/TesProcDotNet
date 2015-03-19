namespace TesEdit.Data
{
    public interface IRecord
    {
        /// <summary>
        /// Convert the record into bytes to be written to file.
        /// </summary>
        /// <returns></returns>
        byte[] ToBytes();
    }
}