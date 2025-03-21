using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteRecommendationsWidget"/>.</para>
/// </summary>
public sealed class VkontakteRecommendationsWidgetTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteRecommendationsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteRecommendationsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteRecommendationsWidget>();

    var widget = new VkontakteRecommendationsWidget();
    widget.ElementId().Should().BeNull();
    widget.Limit().Should().BeNull();
    widget.Max().Should().BeNull();
    widget.Period().Should().BeNull();
    widget.Sorting().Should().BeNull();
    widget.Target().Should().BeNull();
    widget.Verb().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteRecommendationsWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteRecommendationsWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("id");

      var widget = new VkontakteRecommendationsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteRecommendationsWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.ElementId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Limit(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteRecommendationsWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte limit, IVkontakteRecommendationsWidget widget)
    {
      widget.Limit(limit).Should().BeSameAs(widget);
      widget.Limit().Should().Be(limit);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Max(short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Max_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteRecommendationsWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short max, IVkontakteRecommendationsWidget widget)
    {
      widget.Max(max).Should().BeSameAs(widget);
      widget.Max().Should().Be(max);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/> method.</para>
  /// </summary>
  [Fact]
  public void Period_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteRecommendationsWidget();
      Enum.GetValues<VkontakteRecommendationsPeriod>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteRecommendationsPeriod period, IVkontakteRecommendationsWidget widget)
    {
      widget.Period(period).Should().BeSameAs(widget);
      widget.Period().Should().Be(period);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteRecommendationsWidget();
      Enum.GetValues<VkontakteRecommendationsVerb>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteRecommendationsVerb verb, IVkontakteRecommendationsWidget widget)
    {
      widget.Verb(verb).Should().BeSameAs(widget);
      widget.Verb().Should().Be(verb);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sorting_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteRecommendationsWidget();
      Enum.GetValues<VkontakteRecommendationsSorting>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteRecommendationsSorting verb, IVkontakteRecommendationsWidget widget)
    {
      widget.Sorting(verb).Should().BeSameAs(widget);
      widget.Sorting().Should().Be(verb);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Target(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Target_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteRecommendationsWidget().Target(null)).ThrowExactly<ArgumentNullException>().WithParameterName("target");
      AssertionExtensions.Should(() => new VkontakteRecommendationsWidget().Target(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("target");

      var widget = new VkontakteRecommendationsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string target, IVkontakteRecommendationsWidget widget)
    {
      widget.Target(target).Should().BeSameAs(widget);
      widget.Target().Should().Be(target);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteRecommendationsWidget(), """<div id="vk_recommendations"></div><script type="text/javascript">VK.Widgets.Recommended("vk_recommendations", {});</script>""");
      Validate(new VkontakteRecommendationsWidget().ElementId("elementId").Limit(VkontakteRecommendationsLimit.Five).Max(1).Period(VkontakteRecommendationsPeriod.Day).Verb(VkontakteRecommendationsVerb.Like).Sorting(VkontakteRecommendationsSorting.FriendLikes).Target("target"), """<div id="elementId"></div><script type="text/javascript">VK.Widgets.Recommended("elementId", {"limit":5,"max":1,"period":"day","verb":0,"sort":"friend_likes","target":"target"});</script>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}