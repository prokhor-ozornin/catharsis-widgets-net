using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteRecommendationsWidget"/>.</para>
/// </summary>
public sealed class VkontakteRecommendationsWidgetTest : Test
{
  private IVkontakteRecommendationsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteRecommendationsWidgetTest() => Widget = Fixture.Create<IVkontakteRecommendationsWidget>();

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
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<byte?>("LimitValue").Should().BeNull();
      widget.GetPropertyValue<short?>("MaxValue").Should().BeNull();
      widget.GetPropertyValue<VkontakteRecommendationsPeriod?>("PeriodValue").Should().BeNull();
      widget.GetPropertyValue<VkontakteRecommendationsSorting?>("SortingValue").Should().BeNull();
      widget.GetPropertyValue<string>("TargetValue").Should().BeNull();
      widget.GetPropertyValue<VkontakteRecommendationsVerb?>("VerbValue").Should().BeNull();
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string id, IVkontakteRecommendationsWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Limit(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(byte limit, IVkontakteRecommendationsWidget widget) => widget.Limit(limit).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("LimitValue").Should().Be(limit);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Max(short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Max_Method()
  {
    using (new AssertionScope())
    {
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short max, IVkontakteRecommendationsWidget widget) => widget.Max(max).Should().BeSameAs(widget).And.Subject.GetPropertyValue<short?>("MaxValue").Should().Be(max);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/> method.</para>
  /// </summary>
  [Fact]
  public void Period_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<VkontakteRecommendationsPeriod>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(VkontakteRecommendationsPeriod period, IVkontakteRecommendationsWidget widget) => widget.Period(period).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteRecommendationsPeriod?>("PeriodValue").Should().Be(period);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<VkontakteRecommendationsVerb>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(VkontakteRecommendationsVerb verb, IVkontakteRecommendationsWidget widget) => widget.Verb(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteRecommendationsVerb?>("VerbValue").Should().Be(verb);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sorting_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<VkontakteRecommendationsSorting>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(VkontakteRecommendationsSorting verb, IVkontakteRecommendationsWidget widget) => widget.Sorting(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteRecommendationsSorting?>("SortingValue").Should().Be(verb);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string target, IVkontakteRecommendationsWidget widget) => widget.Target(target).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TargetValue").Should().Be(target);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteRecommendationsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteRecommendationsWidget());
      Validate(Fixture.Create<IVkontakteRecommendationsWidget>());
    }

    return;

    static void Validate(IVkontakteRecommendationsWidget original)
    {
      var clone = original.Clone<IVkontakteRecommendationsWidget>();

      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<byte?>("LimitValue").Should().Be(original.GetPropertyValue<byte?>("LimitValue"));
      clone.GetPropertyValue<short?>("MaxValue").Should().Be(original.GetPropertyValue<short?>("MaxValue"));
      clone.GetPropertyValue<VkontakteRecommendationsPeriod?>("PeriodValue").Should().Be(original.GetPropertyValue<VkontakteRecommendationsPeriod?>("PeriodValue"));
      clone.GetPropertyValue<VkontakteRecommendationsSorting?>("SortingValue").Should().Be(original.GetPropertyValue<VkontakteRecommendationsSorting?>("SortingValue"));
      clone.GetPropertyValue<string>("TargetValue").Should().Be(original.GetPropertyValue<string>("TargetValue"));
      clone.GetPropertyValue<VkontakteRecommendationsVerb?>("VerbValue").Should().Be(original.GetPropertyValue<VkontakteRecommendationsVerb?>("VerbValue"));
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
      Validate(Fixture.Create<IVkontakteRecommendationsWidget>());
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