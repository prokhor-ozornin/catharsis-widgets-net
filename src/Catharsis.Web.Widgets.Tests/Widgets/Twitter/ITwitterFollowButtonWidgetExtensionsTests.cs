using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterFollowButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ITwitterFollowButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterFollowButtonWidgetExtensions.Language(ITwitterFollowButtonWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Language(new TwitterFollowButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

    new TwitterFollowButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Language(CultureInfo.CurrentCulture), widget));
      Assert.Equal(CultureInfo.CurrentCulture.TwoLetterISOLanguageName, widget.Language());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterFollowButtonWidgetExtensions.Size(ITwitterFollowButtonWidget, TwitterFollowButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new TwitterFollowButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Size(TwitterFollowButtonSize.Large), widget));
      Assert.Equal("large", widget.Size());
      Assert.Equal("medium", widget.Size(TwitterFollowButtonSize.Medium).Size());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterFollowButtonWidgetExtensions.Alignment(ITwitterFollowButtonWidget, TwitterFollowButtonAlignment)"/> method.</para>
  /// </summary>
  [Fact]
  public void Alignment_Method()
  {
    AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Alignment(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new TwitterFollowButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Alignment(TwitterFollowButtonAlignment.Left), widget));
      Assert.Equal("left", widget.Alignment());
      Assert.Equal("right", widget.Alignment(TwitterFollowButtonAlignment.Right).Alignment());
    });
  }
}