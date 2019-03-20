#region

using System.IO;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class FileInfoExtensions
    {
        public static Stream AsStream(this FileInfo file)
        {
            return file.Exists ? File.OpenRead(file.FullName) : null;
        }
    }
}