using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SurfingbirdSurfButtonWidget"/>.</para>
/// </summary>
public sealed class SurfingbirdSurfButtonWidgetTest : Test
{
  private ISurfingbirdSurfButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public SurfingbirdSurfButtonWidgetTest() => Widget = Fixture<ISurfingbirdSurfButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="SurfingbirdSurfButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(SurfingbirdSurfButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ISurfingbirdSurfButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new SurfingbirdSurfButtonWidget();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutValue").Should().Be(nameof(SurfingbirdSurfButtonLayout.Common).ToLowerInvariant());
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<bool>("CounterValue").Should().BeFalse();
      widget.GetPropertyValue<string>("LabelValue").Should().Be("Surf");
      widget.GetPropertyValue<string>("ColorValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new[] { Fixture<string>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(string url, ISurfingbirdSurfButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Layout(null)).ThrowExactly<ArgumentNullException>().WithParameterName("layout");
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("layout");

      new[] { Fixture<string>.Create() }.ForEach(layout => Test(layout, Widget));
    }

    return;

    static void Test(string layout, ISurfingbirdSurfButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(string width, ISurfingbirdSurfButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(height => Test(height, Widget));
    }

    return;

    static void Test(string height, ISurfingbirdSurfButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Counter(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, ISurfingbirdSurfButtonWidget widget) => widget.Counter(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("CounterValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Label(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Label_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Label(null)).ThrowExactly<ArgumentNullException>().WithParameterName("label");
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Label(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("label");

      new[] { Fixture<string>.Create() }.ForEach(label => Test(label, Widget));
    }

    return;

    static void Test(string label, ISurfingbirdSurfButtonWidget widget) => widget.Label(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LabelValue").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Color(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Color(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Color(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new[] { Fixture<string>.Create() }.ForEach(color => Test(color, Widget));
    }

    return;

    static void Test(string color, ISurfingbirdSurfButtonWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new SurfingbirdSurfButtonWidget());
      Test(Fixture<SurfingbirdSurfButtonWidget>.Create());
    }

    return;

    static void Test(ISurfingbirdSurfButtonWidget original)
    {
      var clone = original.Clone<ISurfingbirdSurfButtonWidget>();

      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("LayoutValue").Should().Be(original.GetPropertyValue<string>("LayoutValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<bool>("CounterValue").Should().Be(original.GetPropertyValue<bool>("CounterValue"));
      clone.GetPropertyValue<string>("LabelValue").Should().Be(original.GetPropertyValue<string>("LabelValue"));
      clone.GetPropertyValue<string>("ColorValue").Should().Be(original.GetPropertyValue<string>("ColorValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new SurfingbirdSurfButtonWidget(), """<a class="surfinbird__like_button" data-surf-config="{&quot;layout&quot;:&quot;common-nocount&quot;}" href="http://surfingbird.ru/share" target="_blank">Surf</a>""");
      Test(new SurfingbirdSurfButtonWidget().Color(SurfingbirdSurfButtonColor.Blue).Counter(true).Label("Share").Url("url").Layout(SurfingbirdSurfButtonLayout.Common).Width("width").Height("height"), """<a class="surfinbird__like_button" data-surf-config="{&quot;layout&quot;:&quot;common-blue&quot;,&quot;url&quot;:&quot;url&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}" href="http://surfingbird.ru/share" target="_blank">Share</a>""");
      Test(Fixture<SurfingbirdSurfButtonWidget>.Create());
    }

    return;

    static void Test(ISurfingbirdSurfButtonWidget widget, params string[] html)
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