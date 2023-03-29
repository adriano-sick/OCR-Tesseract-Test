using Tesseract;

namespace OCR_Tesseract_Test.Utils
{
    public class OcrReader
    {
        public string OcrImageReader()
        {
            string image = @"img.png";

            try
            {
                using var engine = new TesseractEngine(@"tessdata", "por", EngineMode.Default);
                using var img = Pix.LoadFromFile(image);
                using (var page = engine.Process(img))
                {
                    var text = page.GetText();
                    var accurracy = page.GetMeanConfidence();

                    Console.WriteLine(text);
                    Console.WriteLine(accurracy);
                    return text;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }
    }
}
