using System;

namespace ConsoleApplicationTestIFilter
{
  class Program
  {
    static void Main(string[] args)
    {
      // remember to rename the output exe to "filtdump.exe" to get access to the Adobe PDF IFilter 
      // installed with Acrobat Reader

      // read more: http://www.squarepdf.net/parsing-pdf-files-using-ifilter-c-net

      string path = "test.pdf";
      Console.WriteLine("Parsing " + path);
      Console.WriteLine(ExtractTextFromPdf(path));
      Console.WriteLine("press a key to exit:");
      Console.ReadKey();

    }

    public static string ExtractTextFromPdf(string path)
    {
      return DefaultParser.Extract(path);
    }
  }
}
