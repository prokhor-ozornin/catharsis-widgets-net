using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MediaSource"/>.</para>
  /// </summary>
  public sealed class MediaSourceTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="MediaSource(string, string)"/>
    [Fact]
    public void Constructors()
    {
      Assert.Throws<ArgumentNullException>(() => new MediaSource(null, "contentType"));
      Assert.Throws<ArgumentNullException>(() => new MediaSource("url", null));
      Assert.Throws<ArgumentException>(() => new MediaSource(string.Empty, "contentType"));
      Assert.Throws<ArgumentException>(() => new MediaSource("url", string.Empty));

      var source = new MediaSource("url", "contentType");
      Assert.Equal("url", source.Url);
      Assert.Equal("contentType", source.ContentType);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MediaSource.ContentType"/> property.</para>
    /// </summary>
    [Fact]
    public void ContentType_Property()
    {
      Assert.Throws<ArgumentNullException>(() => new MediaSource("url", null));
      Assert.Throws<ArgumentException>(() => new MediaSource("url", string.Empty));

      var source = new MediaSource("url", "contentType");
      source.ContentType = VideoContentTypes.Flash;
      Assert.Equal(VideoContentTypes.Flash, source.ContentType);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MediaSource.Url"/> property.</para>
    /// </summary>
    [Fact]
    public void Url_Property()
    {
      Assert.Throws<ArgumentNullException>(() => new MediaSource(null, "contentType"));
      Assert.Throws<ArgumentException>(() => new MediaSource(string.Empty, "contentType"));

      var source = new MediaSource("url", "contentType");
      source.Url = "http://yandex.ru";
      Assert.Equal("http://yandex.ru", source.Url);
    }

    /// <summary>
    ///   <para>Performs testing of following methods :</para>
    ///   <list type="bullet">
    ///     <item><description><see cref="MediaSource.Equals(MediaSource)"/></description></item>
    ///     <item><description><see cref="MediaSource.Equals(object)"/></description></item>
    ///   </list>
    /// </summary>
    [Fact]
    public void Equals_Methods()
    {
      var source = new MediaSource("url", "contentType");

      Assert.False(source.Equals(null));
      Assert.False(source.Equals(new object()));
      Assert.False(source.Equals(new MediaSource("newUrl", "contentType")));
      Assert.True(source.Equals(source));
      Assert.True(source.Equals(new MediaSource("url", "newContentType")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MediaSource.GetHashCode()"/> method.</para>
    /// </summary>
    [Fact]
    public void GetHashCode_Method()
    {
      var source = new MediaSource("url", "contentType");

      Assert.True(source.GetHashCode() != new object().GetHashCode());
      Assert.True(source.GetHashCode() != new MediaSource("newUrl", "contentType").GetHashCode());
      Assert.Equal(source.GetHashCode(), source.GetHashCode());
      Assert.Equal(new MediaSource("url", "newContentType").GetHashCode(), source.GetHashCode());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MediaSource.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<source src=""url"" type=""contentType""></source>", new MediaSource("url", "contentType").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MediaSource.ToString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToString_Method()
    {
      Assert.Equal(@"<source src=""url"" type=""contentType""></source>", new MediaSource("url", "contentType").ToHtmlString());
    }
  }
}