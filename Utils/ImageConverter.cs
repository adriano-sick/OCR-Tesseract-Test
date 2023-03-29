namespace OCR_Tesseract_Test.Utils
{
    public class ImageConverter
    {
        public void DecodeBase64(string ImgPngBase64)
        {
            ImgPngBase64 = FixBase64ForImage(ImgPngBase64);
            var bytes = Convert.FromBase64String(ImgPngBase64);


            using var writer = new BinaryWriter(File.OpenWrite(@"img.png"));
            writer.Write(bytes);
        }

        public string FixBase64ForImage(string ImgPngBase64)
        {
            System.Text.StringBuilder sbText = new System.Text.StringBuilder(ImgPngBase64, ImgPngBase64.Length);
            sbText.Replace("\r\n", System.String.Empty);
            sbText.Replace(" ", "+");
            return sbText.ToString();
        }
    }
}
