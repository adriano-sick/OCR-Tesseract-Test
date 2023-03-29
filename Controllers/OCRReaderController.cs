using Microsoft.AspNetCore.Mvc;
using OCR_Tesseract_Test.Entities;
using OCR_Tesseract_Test.Services;
using System.Xml.Linq;

namespace OCR_Tesseract_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OCRReaderController : ControllerBase
    {
        private readonly OcrReaderService _OcrReaderServices;

        public OCRReaderController()
        {
            _OcrReaderServices = new OcrReaderService();
        }

        [HttpPost(Name = "OcrReader")]
        public string PostImage([FromBody] string ImgPngBase64)
        {
            return _OcrReaderServices.OcrReader(ImgPngBase64);
        }
    }
}
