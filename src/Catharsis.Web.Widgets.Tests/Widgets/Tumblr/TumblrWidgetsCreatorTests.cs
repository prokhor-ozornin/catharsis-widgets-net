using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TumblrWidgetsCreator"/></para>
/// </summary>
public sealed class TumblrWidgetsCreatorTests : ClassTest<TumblrWidgetsCreator>
{
  private readonly ITumblrWidgetsCreator widgets = Widgets.Web.Tumblr();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TumblrWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TumblrWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<ITumblrWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void FollowButton_Method()
  {
    widgets.FollowButton().Should().BeOfType<TumblrFollowButtonWidget>().And.NotBeSameAs(widgets.FollowButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrWidgetsCreator.ShareButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void ShareButton_Method()
  {
    widgets.ShareButton().Should().BeOfType<TumblrShareButtonWidget>().And.NotBeSameAs(widgets.ShareButton());
  }
}