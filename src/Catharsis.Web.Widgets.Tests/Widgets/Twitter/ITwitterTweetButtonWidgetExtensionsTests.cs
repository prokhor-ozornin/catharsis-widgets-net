using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterTweetButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ITwitterTweetButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.Language(ITwitterTweetButtonWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.Language(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

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
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

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
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.CounterPosition(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

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
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.HashTags(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.HashTags(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("tags");

    new TwitterTweetButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.HashTags(Enumerable.Empty<string>().ToArray()), widget));
      Assert.False(widget.HashTags().Any());
      Assert.True(widget.HashTags(["first", "second"]).HashTags().SequenceEqual(["first", "second"]));
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.RelatedAccounts(ITwitterTweetButtonWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void RelatedAccounts_Method()
  {
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("accounts");

    new TwitterTweetButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.RelatedAccounts(Enumerable.Empty<string>().ToArray()), widget));
      Assert.False(widget.RelatedAccounts().Any());
      Assert.True(widget.RelatedAccounts(new[] { "first", "second" }).RelatedAccounts().SequenceEqual(new[] { "first", "second" }));
    });
  }
}