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

      Assert.Equal(new TwitterHtmlHelper().Follow().ToHtmlString(), new TwitterHtmlHelper().Follow(x => { }));
      Assert.Equal(new TwitterHtmlHelper().Follow().Account("account").ToHtmlString(), new TwitterHtmlHelper().Follow(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterHtmlHelperExtensions.Tweet(ITwitterHtmlHelper, Action{ITwitterTweetButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Tweet_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterHtmlHelperExtensions.Tweet(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new TwitterHtmlHelper().Tweet(null));

      Assert.Equal(new TwitterHtmlHelper().Tweet().ToHtmlString(), new TwitterHtmlHelper().Tweet(x => { }));
      Assert.Equal(new TwitterHtmlHelper().Tweet().Text("text").ToHtmlString(), new TwitterHtmlHelper().Tweet(x => x.Text("text")));
    }
  }
}