using System.IO;
using System.Windows.Media.Imaging;

namespace WpUrbexfApp
{
    public static class Utility
    {
        public static BitmapImage ByteArrayToBitmapImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = memoryStream;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.EndInit();
                return image;
            }
        }
    }
}