using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ITwitterHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class ITwitterHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterHtmlHelperExtensions.Follow(ITwitterHtmlHelper, Action{ITwitterFollowButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Follow_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterHtmlHelperExtensions.Follow(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TwitterHtmlHelper().Follow(null));

      Assert.True(new TwitterHtmlHelper().Follow(x => { }) == new TwitterHtmlHelper().Follow().ToHtmlString());
      Assert.True(new TwitterHtmlHelper().Follow(x => x.Account("account")) == new TwitterHtmlHelper().Follow().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterHtmlHelperExtensions.Tweet(ITwitterHtmlHelper, Action{ITwitterTweetButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Tweet_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterHtmlHelperExtensions.Tweet(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TwitterHtmlHelper().Tweet(null));

      Assert.True(new TwitterHtmlHelper().Tweet(x => { }) == new TwitterHtmlHelper().Tweet().ToHtmlString());
      Assert.True(new TwitterHtmlHelper().Tweet(x => x.Text("text")) == new TwitterHtmlHelper().Tweet().Text("text").ToHtmlString());
    }
  }
}