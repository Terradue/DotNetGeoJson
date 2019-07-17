using System.IO;
using NUnit.Framework;

namespace Terradue.GeoJson.Tests
{
  public static class TextContextExtensions{
    public static string TestPath(this TestContext current, string relativePath){
      return Path.Combine(current.TestDirectory, "../../", relativePath ?? "");
    }
  }
}