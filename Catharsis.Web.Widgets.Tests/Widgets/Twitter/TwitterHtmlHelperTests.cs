using System;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TwitterHtmlHelper"/>.</para>
  /// </summary>
  public sealed class TwitterHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterHtmlHelper.Follow()"/> method.</para>
    /// </summary>
    [Fact]
    public void Follow_Method()
    {
      Assert.False(ReferenceEquals(this.html.Twitter().Follow(), this.html.Twitter().Follow()));
      Assert.True(this.html.Twitter().Follow() is TwitterFollowButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterHtmlHelper.Tweet()"/> method.</para>
    /// </summary>
    [Fact]
    public void Tweet_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterHtmlHelper().Tweet(null));

      Assert.False(ReferenceEquals(this.html.Twitter().Tweet(), this.html.Twitter().Tweet()));
      Assert.True(this.html.Twitter().Tweet() is TwitterTweetButtonWidget);
    }
  }
}