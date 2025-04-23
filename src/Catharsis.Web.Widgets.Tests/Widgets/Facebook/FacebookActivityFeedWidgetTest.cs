using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookActivityFeedWidget"/>.</para>
/// </summary>
public sealed class FacebookActivityFeedWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<IEnumerable<string>>("ActionsProperty").Should().BeEmpty();
      widget.GetPropertyValue<string>("AppIdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("DomainProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("HeaderProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LinkTargetProperty").Should().BeNull();
      widget.GetPropertyValue<byte?>("MaxAgeProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("RecommendationsProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TrackLabelProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
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

      new FacebookActivityFeedWidget().With(widget => new[] { Enumerable.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(IEnumerable<string> actions, IFacebookActivityFeedWidget widget) => widget.Actions(actions).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ActionsProperty").Should().Equal(actions);
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

      new FacebookActivityFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IFacebookActivityFeedWidget widget) => widget.AppId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AppIdProperty").Should().Be(id);
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

      new FacebookActivityFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookActivityFeedWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
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

      new FacebookActivityFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IFacebookActivityFeedWidget widget) => widget.Domain(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Header(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      new FacebookActivityFeedWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IFacebookActivityFeedWidget widget) => widget.Header(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("HeaderProperty").Should().Be(enabled);
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

      new FacebookActivityFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IFacebookActivityFeedWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
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

      new FacebookActivityFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string target, IFacebookActivityFeedWidget widget) => widget.LinkTarget(target).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LinkTargetProperty").Should().Be(target);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.MaxAge(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxAge_Method()
  {
    using (new AssertionScope())
    {
      new FacebookActivityFeedWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte max, IFacebookActivityFeedWidget widget) => widget.MaxAge(max).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("MaxAgeProperty").Should().Be(max);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Recommendations(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    using (new AssertionScope())
    {
      new FacebookActivityFeedWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IFacebookActivityFeedWidget widget) => widget.Recommendations(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("RecommendationsProperty").Should().Be(enabled);
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

      new FacebookActivityFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string label, IFacebookActivityFeedWidget widget) => widget.TrackLabel(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TrackLabelProperty").Should().Be(label);
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

      new FacebookActivityFeedWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookActivityFeedWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookActivityFeedWidget(), """<div class="fb-activity"></div>""");
      Validate(new FacebookActivityFeedWidget().Domain("domain").AppId("appId").Actions("actions").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Header(true).LinkTarget("linkTarget").MaxAge(1).Recommendations(true).TrackLabel("trackLabel"), """<div class="fb-activity" data-action="actions" data-app-id="appId" data-colorscheme="dark" data-header="true" data-height="height" data-linktarget="linkTarget" data-max-age="1" data-recommendations="true" data-ref="trackLabel" data-site="domain" data-width="width"></div>""");
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