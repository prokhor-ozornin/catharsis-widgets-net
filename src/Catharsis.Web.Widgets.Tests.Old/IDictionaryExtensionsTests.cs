using System;
using System.Collections.Generic;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IDictionaryExtensions"/>.</para>
  /// </summary>
  public sealed class IDictionaryExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IDictionaryExtensions.ToUrlQuery(IDictionary{string, object})"/> method.</para>
    /// </summary>
    [Fact]
    public void ToUrlQuery_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IDictionaryExtensions.ToUrlQuery(null));

      Assert.Equal(string.Empty, new Dictionary<string, object>().ToUrlQuery());
      Assert.Equal("name=value", new Dictionary<string, object> { { "name", "value" } }.ToUrlQuery());
      Assert.Equal("first=1&second=2", new Dictionary<string, object> { { "first", 1 }, { "second", 2 } }.ToUrlQuery());
    }
  }
}