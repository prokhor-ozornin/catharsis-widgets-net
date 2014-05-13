using System;
using System.Globalization;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ITwitterFollowButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class ITwitterFollowButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ITwitterFollowButtonWidgetExtensions.Language(ITwitterFollowButtonWidget, CultureInfo)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITwitterFollowButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture));
      Assert.Throws<ArgumentNullException>(() => ITwitterFollowButtonWidgetExtensions.Language(new TwitterFollowButtonWidget(), null));

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
      Assert.Throws<ArgumentNullException>(() => ITwitterFollowButtonWidgetExtensions.Size(null, TwitterFollowButtonSize.Large));

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
      Assert.Throws<ArgumentNullException>(() => ITwitterFollowButtonWidgetExtensions.Alignment(null, TwitterFollowButtonAlignment.Left));

      new TwitterFollowButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Alignment(TwitterFollowButtonAlignment.Left), widget));
        Assert.Equal("left", widget.Alignment());
        Assert.Equal("right", widget.Alignment(TwitterFollowButtonAlignment.Right).Alignment());
      });
    }
  }
}