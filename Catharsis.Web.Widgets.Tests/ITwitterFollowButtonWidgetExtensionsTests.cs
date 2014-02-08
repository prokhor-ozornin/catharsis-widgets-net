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
        Assert.True(widget.Field("language").To<string>() == CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
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
        Assert.True(widget.Field("size").To<string>() == "large");
        Assert.True(widget.Size(TwitterFollowButtonSize.Medium).Field("size").To<string>() == "medium");
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
        Assert.True(widget.Field("alignment").To<string>() == "left");
        Assert.True(widget.Alignment(TwitterFollowButtonAlignment.Right).Field("alignment").To<string>() == "right");
      });
    }
  }
}