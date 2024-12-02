using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterWidgetsCreator"/>.</para>
/// </summary>
public sealed class TwitterWidgetsCreatorTests : ClassTest<TwitterWidgetsCreator>
{
  private readonly ITwitterWidgetsCreator widgets = Widgets.Web.Twitter();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TwitterWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TwitterWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<ITwitterWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Follow_Method()
  {
    widgets.FollowButton().Should().BeOfType<TwitterFollowButtonWidget>().And.NotBeSameAs(widgets.FollowButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetsCreator.TweetButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Tweet_Method()
  {
    widgets.TweetButton().Should().BeOfType<TwitterTweetButtonWidget>().And.NotBeSameAs(widgets.TweetButton());
  }
}