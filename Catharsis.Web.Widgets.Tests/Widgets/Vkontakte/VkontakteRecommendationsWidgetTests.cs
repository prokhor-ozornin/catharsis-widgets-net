using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteRecommendationsWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteRecommendationsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontakteRecommendationsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.ElementId());
      Assert.Null(widget.Limit());
      Assert.Null(widget.Max());
      Assert.Null(widget.Period());
      Assert.Null(widget.Sorting());
      Assert.Null(widget.Target());
      Assert.Null(widget.Verb());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.ElementId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ElementId_Method()
    {
      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.ElementId());
      Assert.True(ReferenceEquals(widget.ElementId("elementId"), widget));
      Assert.Equal("elementId", widget.ElementId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Limit(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Limit_Method()
    {
      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.Limit());
      Assert.True(ReferenceEquals(widget.Limit(1), widget));
      Assert.Equal((byte) 1, widget.Limit());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Max(short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Max_Method()
    {
      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.Max());
      Assert.True(ReferenceEquals(widget.Max(1), widget));
      Assert.Equal((short)1, widget.Max());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/> method.</para>
    /// </summary>
    [Fact]
    public void Period_Method()
    {
      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.Period());
      Assert.True(ReferenceEquals(widget.Period(VkontakteRecommendationsPeriod.Day), widget));
      Assert.Equal(VkontakteRecommendationsPeriod.Day, widget.Period());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/> method.</para>
    /// </summary>
    [Fact]
    public void Verb_Method()
    {
      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.Verb());
      Assert.True(ReferenceEquals(widget.Verb(VkontakteRecommendationsVerb.Interest), widget));
      Assert.Equal(VkontakteRecommendationsVerb.Interest, widget.Verb());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sorting_Method()
    {
      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.Sorting());
      Assert.True(ReferenceEquals(widget.Sorting(VkontakteRecommendationsSorting.FriendLikes), widget));
      Assert.Equal(VkontakteRecommendationsSorting.FriendLikes, widget.Sorting());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Target(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Target_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteRecommendationsWidget().Target(null));
      Assert.Throws<ArgumentException>(() => new VkontakteRecommendationsWidget().Target(string.Empty));

      var widget = new VkontakteRecommendationsWidget();
      Assert.Null(widget.Target());
      Assert.True(ReferenceEquals(widget.Target("target"), widget));
      Assert.Equal("target", widget.Target());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<div id=""vk_recommendations""></div><script type=""text/javascript"">VK.Widgets.Recommended(""vk_recommendations"", {});</script>", new VkontakteRecommendationsWidget().ToString());
      Assert.Equal(@"<div id=""elementId""></div><script type=""text/javascript"">VK.Widgets.Recommended(""elementId"", {""limit"":5,""max"":1,""period"":""day"",""verb"":0,""sort"":""friend_likes"",""target"":""target""});</script>", new VkontakteRecommendationsWidget().ElementId("elementId").Limit(VkontakteRecommendationsLimit.Five).Max(1).Period(VkontakteRecommendationsPeriod.Day).Verb(VkontakteRecommendationsVerb.Like).Sorting(VkontakteRecommendationsSorting.FriendLikes).Target("target").ToString());
    }
  }
}