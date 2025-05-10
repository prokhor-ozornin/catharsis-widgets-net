using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookActivityFeedWidget"/>.</para>
/// </summary>
public sealed class FacebookActivityFeedWidgetTest : Test
{
  private IFacebookActivityFeedWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookActivityFeedWidgetTest() => Widget = Fixture.Create<IFacebookActivityFeedWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookActivityFeedWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookActivityFeedWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookActivityFeedWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      widget.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().BeEmpty();
      widget.GetPropertyValue<string>("AppIdValue").Should().BeNull();
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().BeNull();
      widget.GetPropertyValue<string>("DomainValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("HeaderValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<string>("LinkTargetValue").Should().BeNull();
      widget.GetPropertyValue<byte?>("MaxAgeValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("RecommendationsValue").Should().BeNull();
      widget.GetPropertyValue<string>("TrackLabelValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Actions(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("actions");

      new[] { Enumerable.Empty<string>(), [Fixture.Create<string>()] }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(IEnumerable<string> actions, IFacebookActivityFeedWidget widget) => widget.Actions(actions).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(actions);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.AppId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AppId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().AppId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().AppId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IFacebookActivityFeedWidget widget) => widget.AppId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AppIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string scheme, IFacebookActivityFeedWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Domain(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Domain_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().Domain(null)).ThrowExactly<ArgumentNullException>().WithParameterName("domain");
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().Domain(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("domain");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IFacebookActivityFeedWidget widget) => widget.Domain(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Header(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookActivityFeedWidget widget) => widget.Header(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("HeaderValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IFacebookActivityFeedWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.LinkTarget(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkTarget_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().LinkTarget(null)).ThrowExactly<ArgumentNullException>().WithParameterName("target");
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().LinkTarget(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("target");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string target, IFacebookActivityFeedWidget widget) => widget.LinkTarget(target).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LinkTargetValue").Should().Be(target);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.MaxAge(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxAge_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture.Create<byte>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte max, IFacebookActivityFeedWidget widget) => widget.MaxAge(max).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("MaxAgeValue").Should().Be(max);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Recommendations(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookActivityFeedWidget widget) => widget.Recommendations(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("RecommendationsValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().TrackLabel(null)).ThrowExactly<ArgumentNullException>().WithParameterName("label");
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().TrackLabel(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("label");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string label, IFacebookActivityFeedWidget widget) => widget.TrackLabel(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TrackLabelValue").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookActivityFeedWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IFacebookActivityFeedWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookActivityFeedWidget());
      Test(Fixture.Create<FacebookActivityFeedWidget>());
    }

    return;

    static void Test(IFacebookActivityFeedWidget original)
    {
      var clone = original.Clone<IFacebookActivityFeedWidget>();

      clone.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(original.GetPropertyValue<IEnumerable<string>>("ActionsValue"));
      clone.GetPropertyValue<string>("AppIdValue").Should().Be(original.GetPropertyValue<string>("AppIdValue"));
      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
      clone.GetPropertyValue<string>("DomainValue").Should().Be(original.GetPropertyValue<string>("DomainValue"));
      clone.GetPropertyValue<bool?>("HeaderValue").Should().Be(original.GetPropertyValue<bool?>("HeaderValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("LinkTargetValue").Should().Be(original.GetPropertyValue<string>("LinkTargetValue"));
      clone.GetPropertyValue<byte?>("MaxAgeValue").Should().Be(original.GetPropertyValue<byte?>("MaxAgeValue"));
      clone.GetPropertyValue<bool?>("RecommendationsValue").Should().Be(original.GetPropertyValue<bool?>("RecommendationsValue"));
      clone.GetPropertyValue<string>("TrackLabelValue").Should().Be(original.GetPropertyValue<string>("TrackLabelValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookActivityFeedWidget(), """<div class="fb-activity"></div>""");
      Test(new FacebookActivityFeedWidget().Domain("domain").AppId("appId").Actions("actions").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Header(true).LinkTarget("linkTarget").MaxAge(1).Recommendations(true).TrackLabel("trackLabel"), """<div class="fb-activity" data-action="actions" data-app-id="appId" data-colorscheme="dark" data-header="true" data-height="height" data-linktarget="linkTarget" data-max-age="1" data-recommendations="true" data-ref="trackLabel" data-site="domain" data-width="width"></div>""");
      Test(Fixture.Create<FacebookActivityFeedWidget>());
    }

    return;

    static void Test(IFacebookActivityFeedWidget widget, params string[] html)
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