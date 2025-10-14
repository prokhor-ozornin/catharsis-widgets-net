using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TwitterWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="TwitterWidgetsCreator"/>
public sealed class TwitterWidgetsCreatorTest : Test
{
  private ITwitterWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Twitter();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TwitterWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(TwitterWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<ITwitterWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetsCreator.FollowButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Follow_Method()
  {
    Widgets.FollowButton().Should().BeOfType<TwitterFollowButtonWidget>().And.NotBeSameAs(Widgets.FollowButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TwitterWidgetsCreator.TweetButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void Tweet_Method()
  {
    Widgets.TweetButton().Should().BeOfType<TwitterTweetButtonWidget>().And.NotBeSameAs(Widgets.TweetButton());
  }
}