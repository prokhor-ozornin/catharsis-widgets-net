using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteRecommendationsWidget"/>.</para>
/// </summary>
public sealed class VkontakteRecommendationsWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteRecommendationsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteRecommendationsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteRecommendationsWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteRecommendationsWidget();
      widget.GetPropertyValue<string>("ElementIdProperty").Should().BeNull();
      widget.GetPropertyValue<byte?>("LimitProperty").Should().BeNull();
      widget.GetPropertyValue<short?>("MaxProperty").Should().BeNull();
      widget.GetPropertyValue<VkontakteRecommendationsPeriod?>("PeriodProperty").Should().BeNull();
      widget.GetPropertyValue<VkontakteRecommendationsSorting?>("SortingProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TargetProperty").Should().BeNull();
      widget.GetPropertyValue<VkontakteRecommendationsVerb?>("VerbProperty").Should().BeNull();
    }
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
      AssertionExtensions.Should(() => new VkontakteRecommendationsWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new VkontakteRecommendationsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IVkontakteRecommendationsWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Limit(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteRecommendationsWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte limit, IVkontakteRecommendationsWidget widget) => widget.Limit(limit).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("LimitProperty").Should().Be(limit);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Max(short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Max_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteRecommendationsWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short max, IVkontakteRecommendationsWidget widget) => widget.Max(max).Should().BeSameAs(widget).And.Subject.GetPropertyValue<short?>("MaxProperty").Should().Be(max);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/> method.</para>
  /// </summary>
  [Fact]
  public void Period_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteRecommendationsWidget().With(widget => Enum.GetValues<VkontakteRecommendationsPeriod>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(VkontakteRecommendationsPeriod period, IVkontakteRecommendationsWidget widget) => widget.Period(period).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteRecommendationsPeriod?>("PeriodProperty").Should().Be(period);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteRecommendationsWidget().With(widget => Enum.GetValues<VkontakteRecommendationsVerb>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(VkontakteRecommendationsVerb verb, IVkontakteRecommendationsWidget widget) => widget.Verb(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteRecommendationsVerb?>("VerbProperty").Should().Be(verb);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sorting_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteRecommendationsWidget().With(widget => Enum.GetValues<VkontakteRecommendationsSorting>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(VkontakteRecommendationsSorting verb, IVkontakteRecommendationsWidget widget) => widget.Sorting(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteRecommendationsSorting?>("SortingProperty").Should().Be(verb);
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
      AssertionExtensions.Should(() => new VkontakteRecommendationsWidget().Target(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("target");

      new VkontakteRecommendationsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string target, IVkontakteRecommendationsWidget widget) => widget.Target(target).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TargetProperty").Should().Be(target);
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
      if (html.IsUnset())
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