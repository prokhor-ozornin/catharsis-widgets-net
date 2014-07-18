using System;
using System.Web;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HttpRequestExtensions"/>.</para>
  /// </summary>
  public sealed class HttpRequestExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="HttpRequestExtensions.Parameter(HttpRequest, string)"/> method.</para>
    /// </summary>
    [Fact(Skip = "Tests must run in context of web application")]
    public void Parameter_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HttpRequestExtensions.Parameter(null, "name"));
      Assert.Throws<ArgumentNullException>(() => new HttpRequest("filename", "url", "queryString").Parameter(null));
      Assert.Throws<ArgumentException>(() => new HttpRequest("filename", "url", "queryString").Parameter(string.Empty));

      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HttpRequestExtensions.Culture(HttpRequest)"/> method.</para>
    /// </summary>
    [Fact(Skip = "Tests must run in context of web application")]
    public void Culture_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HttpRequestExtensions.Culture(null));

      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="HttpRequestExtensions.Language(HttpRequest)"/> method.</para>
    /// </summary>
    [Fact(Skip = "Tests must run in context of web application")]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => HttpRequestExtensions.Language(null));

      throw new NotImplementedException();
    }
  }
}