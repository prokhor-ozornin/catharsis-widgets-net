using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="StringExtensions"/>.</para>
  /// </summary>
  public sealed class StringExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="StringExtensions.Json{T}(string)"/> method.</para>
    /// </summary>
    [Fact(Skip = "To be implemented")]
    public void Json_Method()
    {
      Assert.Throws<ArgumentNullException>(() => StringExtensions.Json<object>(null));
      Assert.Throws<ArgumentException>(() => string.Empty.Json<object>());

      throw new NotImplementedException();
    }
  }
}