using iText.Html2pdf;

namespace RandomTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TODO: set path to files 
            var path = "C:\\";
            var inputFile = new FileInfo(path + @"\test.html");
            var outputFile = new FileInfo(path + @"\test.pdf");
            HtmlConverter.ConvertToPdf(inputFile, outputFile);

        }
    }
}
