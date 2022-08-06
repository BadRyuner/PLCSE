
namespace PLCSE
{
    public static partial class Save
    {
		public static SaveGameData CurrentSave;
	}

	public static class BinaryReaderExtensions
    {
		public static Vector3 ReadVector3(this BinaryReader br)
        {
			return new Vector3(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
        }
    }
}
