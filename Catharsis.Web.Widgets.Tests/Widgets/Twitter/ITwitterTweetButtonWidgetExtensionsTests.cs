using System;
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
        Assert.Equal(CultureInfo.CurrentCulture.TwoLetterISOLanguageName, widget.Language());
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
        Assert.Equal("large", widget.Size());
        Assert.Equal("medium", widget.Size(TwitterTweetButtonSize.Medium).Size());
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
        Assert.Equal("horizontal", widget.CounterPosition());
        Assert.Equal("none", widget.CounterPosition(TwitterTweetButtonCountBoxPosition.None).CounterPosition());
        Assert.Equal("vertical", widget.CounterPosition(TwitterTweetButtonCountBoxPosition.Vertical).CounterPosition());
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
        Assert.False(widget.HashTags().Any());
        Assert.True(widget.HashTags(new[] { "first", "second" }).HashTags().SequenceEqual(new[] { "first", "second" }));
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
        Assert.False(widget.RelatedAccounts().Any());
        Assert.True(widget.RelatedAccounts(new[] { "first", "second" }).RelatedAccounts().SequenceEqual(new[] { "first", "second" }));
      });
    }
  }
}