using System.IO;
using NUnit.Framework;

namespace Terradue.GeoJson.Tests
{
  public static class DirectoryExtensions
  {
    internal static string TestDirectory(this string current)
    {
      var input = current ?? "";
      var testDirectory = Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory);
      return testDirectory != null ? Path.Combine(testDirectory, input) : input;
    }
  }
}