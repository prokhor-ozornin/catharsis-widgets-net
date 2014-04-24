using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ITwitterTweetButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class ITwitterTweetButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.Language(ITwitterTweetButtonWidget, CultureInfo)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture));
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.Language(new TwitterTweetButtonWidget(), null));

      new TwitterTweetButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Language(CultureInfo.CurrentCulture), widget));
        Assert.Equal(CultureInfo.CurrentCulture.TwoLetterISOLanguageName, widget.Field("language").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.Size(ITwitterTweetButtonWidget, TwitterTweetButtonSize)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.Size(null, TwitterTweetButtonSize.Large));

      new TwitterTweetButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Size(TwitterTweetButtonSize.Large), widget));
        Assert.Equal("large", widget.Field("size").To<string>());
        Assert.Equal("medium", widget.Size(TwitterTweetButtonSize.Medium).Field("size").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.CounterPosition(ITwitterTweetButtonWidget, TwitterTweetButtonCountBoxPosition)"/> method.</para>
    /// </summary>
    [Fact]
    public void CounterPosition_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.CounterPosition(null, TwitterTweetButtonCountBoxPosition.Horizontal));

      new TwitterTweetButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.CounterPosition(TwitterTweetButtonCountBoxPosition.Horizontal), widget));
        Assert.Equal("horizontal", widget.Field("counterPosition").To<string>());
        Assert.Equal("none", widget.CounterPosition(TwitterTweetButtonCountBoxPosition.None).Field("counterPosition").To<string>());
        Assert.Equal("vertical", widget.CounterPosition(TwitterTweetButtonCountBoxPosition.Vertical).Field("counterPosition").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.HashTags(ITwitterTweetButtonWidget, string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void HashTags_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.HashTags(null, Enumerable.Empty<string>().ToArray()));
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.HashTags(new TwitterTweetButtonWidget(), null));

      new TwitterTweetButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.HashTags(Enumerable.Empty<string>().ToArray()), widget));
        Assert.False(widget.Field("tags").To<IEnumerable<string>>().Any());
        Assert.True(widget.HashTags(new[] { "first", "second" }).Field("tags").To<IEnumerable<string>>().SequenceEqual(new[] { "first", "second" }));
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.RelatedAccounts(ITwitterTweetButtonWidget, string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void RelatedAccounts_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(null, Enumerable.Empty<string>().ToArray()));
      Assert.Throws<ArgumentNullException>(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(new TwitterTweetButtonWidget(), null));

      new TwitterTweetButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.RelatedAccounts(Enumerable.Empty<string>().ToArray()), widget));
        Assert.False(widget.Field("accounts").To<IEnumerable<string>>().Any());
        Assert.True(widget.RelatedAccounts(new[] { "first", "second" }).Field("accounts").To<IEnumerable<string>>().SequenceEqual(new[] { "first", "second" }));
      });
    }
  }
}