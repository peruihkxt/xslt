using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Xsl;
using System.Xml;

namespace xslt {
  class Program {
    static void Main(string[] args) {
      if (args.Length != 3) {
        Console.WriteLine(Properties.Resources.ShortDocs);
        return;
      }
      try {
        XslCompiledTransform transform = new XslCompiledTransform(true);
        transform.Load(args[1]);
        transform.Transform(args[0], args[2]);
        Console.WriteLine("Transform completed successfully.");
      } catch (XsltException ex) {
        Console.WriteLine("Exception while processing StyleSheet: " + ex.Message);
        Console.WriteLine("Position: {0}, {1}", ex.LineNumber, ex.LinePosition);
        Console.WriteLine("Stack Trace:");
        Console.WriteLine(ex.StackTrace);
      } catch (XmlException ex) {
        Console.WriteLine("Exception while processing StyleSheet: " + ex.Message);
        Console.WriteLine("Position: {0}, {1}", ex.LineNumber, ex.LinePosition);
        Console.WriteLine("Stack Trace:");
        Console.WriteLine(ex.StackTrace);
      } catch (Exception ex) {
        Console.WriteLine("Exception: " + ex.Message);
        Console.WriteLine("Stack Trace:");
        Console.WriteLine(ex.StackTrace);
      }

    }
  }
}
