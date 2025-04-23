using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookRecommendationsFeedWidget"/>.</para>
/// </summary>
public sealed class FacebookRecommendationsFeedWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("DomainProperty").Should().BeNull();
      widget.GetPropertyValue<string>("AppIdProperty").Should().BeNull();
      widget.GetPropertyValue<IEnumerable<string>>("ActionsProperty").Should().BeEmpty();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("HeaderProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LinkTargetProperty").Should().BeNull();
      widget.GetPropertyValue<byte?>("MaxAgeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TrackLabelProperty").Should().BeNull();
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookRecommendationsFeedWidget widget) => widget.Domain(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainProperty").Should().Be(scheme);
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IFacebookRecommendationsFeedWidget widget) => widget.AppId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AppIdProperty").Should().Be(id);
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { Enumerable.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(IEnumerable<string> actions, IFacebookRecommendationsFeedWidget widget)
    {
      widget.Actions(actions).Should().BeSameAs(widget);
      widget.GetPropertyValue<IEnumerable<string>>("ActionsProperty").Should().Equal(actions);
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookRecommendationsFeedWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IFacebookRecommendationsFeedWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookRecommendationsFeedWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.Header(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      new FacebookRecommendationsFeedWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IFacebookRecommendationsFeedWidget widget) => widget.Header(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("HeaderProperty").Should().Be(enabled);
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string target, IFacebookRecommendationsFeedWidget widget) => widget.LinkTarget(target).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LinkTargetProperty").Should().Be(target);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.MaxAge(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxAge_Method()
  {
    using (new AssertionScope())
    {
      new FacebookRecommendationsFeedWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte max, IFacebookRecommendationsFeedWidget widget) => widget.MaxAge(max).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("MaxAgeProperty").Should().Be(max);
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

      new FacebookRecommendationsFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string label, IFacebookRecommendationsFeedWidget widget) => widget.TrackLabel(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TrackLabelProperty").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookRecommendationsFeedWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookRecommendationsFeedWidget(), """<div class="fb-recommendations"></div>""");
      Validate(new FacebookRecommendationsFeedWidget().Domain("domain").AppId("appId").Actions("actions").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Header(true).LinkTarget("linkTarget").MaxAge(1).TrackLabel("trackLabel"), """<div class="fb-recommendations" data-action="actions" data-app-id="appId" data-colorscheme="dark" data-header="true" data-height="height" data-linktarget="linkTarget" data-max-age="1" data-ref="trackLabel" data-site="domain" data-width="width"></div>""");
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