using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookRecommendationsFeedWidget"/>.</para>
/// </summary>
/// <seealso cref="FacebookRecommendationsFeedWidget"/>
public sealed class FacebookRecommendationsFeedWidgetTest : Test
{
  private IFacebookRecommendationsFeedWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookRecommendationsFeedWidgetTest() => Widget = Fixture<IFacebookRecommendationsFeedWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookRecommendationsFeedWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookRecommendationsFeedWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookRecommendationsFeedWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookRecommendationsFeedWidget();
      widget.GetPropertyValue<string>("DomainValue").Should().BeNull();
      widget.GetPropertyValue<string>("AppIdValue").Should().BeNull();
      widget.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().BeEmpty();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("HeaderValue").Should().BeNull();
      widget.GetPropertyValue<string>("LinkTargetValue").Should().BeNull();
      widget.GetPropertyValue<byte?>("MaxAgeValue").Should().BeNull();
      widget.GetPropertyValue<string>("TrackLabelValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Domain(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Domain_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Domain(null)).ThrowExactly<ArgumentNullException>().WithParameterName("domain");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Domain(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("domain");

      new[] { Fixture<string>.Create() }.ForEach(scheme => Test(scheme, Widget));
    }

    return;

    static void Test(string scheme, IFacebookRecommendationsFeedWidget widget) => widget.Domain(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.AppId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AppId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().AppId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().AppId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IFacebookRecommendationsFeedWidget widget) => widget.AppId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AppIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Actions(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("actions");

      new[] { Enumerable.Empty<string>(), [Fixture<string>.Create()] }.ForEach(actions => Test(actions, Widget));
    }

    return;

    static void Test(IEnumerable<string> actions, IFacebookRecommendationsFeedWidget widget)
    {
      widget.Actions(actions).Should().BeSameAs(widget);
      widget.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(actions);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(string width, IFacebookRecommendationsFeedWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(height => Test(height, Widget));
    }

    return;

    static void Test(string height, IFacebookRecommendationsFeedWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new[] { Fixture<string>.Create() }.ForEach(scheme => Test(scheme, Widget));
    }

    return;

    static void Test(string scheme, IFacebookRecommendationsFeedWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Header(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookRecommendationsFeedWidget widget) => widget.Header(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("HeaderValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.LinkTarget(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkTarget_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().LinkTarget(null)).ThrowExactly<ArgumentNullException>().WithParameterName("target");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().LinkTarget(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("target");

      new[] { Fixture<string>.Create() }.ForEach(target => Test(target, Widget));
    }

    return;

    static void Test(string target, IFacebookRecommendationsFeedWidget widget) => widget.LinkTarget(target).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LinkTargetValue").Should().Be(target);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.MaxAge(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxAge_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(max => Test(max, Widget));
    }

    return;

    static void Test(byte max, IFacebookRecommendationsFeedWidget widget) => widget.MaxAge(max).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("MaxAgeValue").Should().Be(max);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().TrackLabel(null)).ThrowExactly<ArgumentNullException>().WithParameterName("label");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().TrackLabel(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("label");

      new[] { Fixture<string>.Create() }.ForEach(label => Test(label, Widget));
    }

    return;

    static void Test(string label, IFacebookRecommendationsFeedWidget widget) => widget.TrackLabel(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TrackLabelValue").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookRecommendationsFeedWidget());
      Test(Fixture<FacebookRecommendationsFeedWidget>.Create());
    }

    return;

    static void Test(IFacebookRecommendationsFeedWidget original)
    {
      var clone = original.Clone<IFacebookRecommendationsFeedWidget>();

      clone.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(original.GetPropertyValue<IEnumerable<string>>("ActionsValue"));
      clone.GetPropertyValue<string>("AppIdValue").Should().Be(original.GetPropertyValue<string>("AppIdValue"));
      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
      clone.GetPropertyValue<string>("DomainValue").Should().Be(original.GetPropertyValue<string>("DomainValue"));
      clone.GetPropertyValue<bool?>("HeaderValue").Should().Be(original.GetPropertyValue<bool?>("HeaderValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("LinkTargetValue").Should().Be(original.GetPropertyValue<string>("LinkTargetValue"));
      clone.GetPropertyValue<byte?>("MaxAgeValue").Should().Be(original.GetPropertyValue<byte?>("MaxAgeValue"));
      clone.GetPropertyValue<string>("TrackLabelValue").Should().Be(original.GetPropertyValue<string>("TrackLabelValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookRecommendationsFeedWidget(), """<div class="fb-recommendations"></div>""");
      Test(new FacebookRecommendationsFeedWidget().Domain("domain").AppId("appId").Actions("actions").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Header(true).LinkTarget("linkTarget").MaxAge(1).TrackLabel("trackLabel"), """<div class="fb-recommendations" data-action="actions" data-app-id="appId" data-colorscheme="dark" data-header="true" data-height="height" data-linktarget="linkTarget" data-max-age="1" data-ref="trackLabel" data-site="domain" data-width="width"></div>""");
      Test(Fixture<FacebookRecommendationsFeedWidget>.Create());
    }

    return;

    static void Test(IFacebookRecommendationsFeedWidget widget, params string[] html)
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