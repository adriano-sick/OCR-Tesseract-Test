using OCR_Tesseract_Test.Utils;

namespace OCR_Tesseract_Test.Services
{
    public class OcrReaderService
    {
        private readonly ImageConverter _imageConverter;
        private readonly OcrReader _ocrReader;
        public OcrReaderService()
        {
            _imageConverter = new ImageConverter();
            _ocrReader = new OcrReader();
        }

        public string OcrReader(string ImgPngBase64)
        {
            _imageConverter.DecodeBase64(ImgPngBase64);
            return _ocrReader.OcrImageReader();
        }
    }
}
