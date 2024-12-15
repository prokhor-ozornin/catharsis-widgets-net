using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SurfingbirdSurfButtonWidget"/>.</para>
/// </summary>
public sealed class SurfingbirdSurfButtonWidgetTests : ClassTest<SurfingbirdSurfButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="SurfingbirdSurfButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(SurfingbirdSurfButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ISurfingbirdSurfButtonWidget>();

    var widget = new SurfingbirdSurfButtonWidget();
    Assert.Null(widget.Url().Should().BeNull());
    widget.Layout().Should().Be(SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant());
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Counter().Should().BeFalse();
    widget.Label().Should().Be("Surf");
    widget.Color().Should().BeNull();
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
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("url");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
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
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("layout");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string layout, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.Layout().Should().Be(layout);
    }
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
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("width");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
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
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("height");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Counter(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      var widget = new SurfingbirdSurfButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Counter(enabled).Should().BeSameAs(widget);
      widget.Counter().Should().Be(enabled);
    }
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
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Label(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("label");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string label, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Label(label).Should().BeSameAs(widget);
      widget.Label().Should().Be(label);
    }
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
      AssertionExtensions.Should(() => new SurfingbirdSurfButtonWidget().Color(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("color");

      var widget = new SurfingbirdSurfButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, ISurfingbirdSurfButtonWidget widget)
    {
      widget.Color(color).Should().BeSameAs(widget);
      widget.Color().Should().Be(color);
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
      Validate(new SurfingbirdSurfButtonWidget(), """<a class="surfinbird__like_button" data-surf-config="{&quot;layout&quot;:&quot;common-nocount&quot;}" href="http://surfingbird.ru/share" target="_blank">Surf</a>""");
      Validate(new SurfingbirdSurfButtonWidget().Color(SurfingbirdSurfButtonColor.Blue).Counter(true).Label("Share").Url("url").Layout(SurfingbirdSurfButtonLayout.Common).Width("width").Height("height"), """<a class="surfinbird__like_button" data-surf-config="{&quot;layout&quot;:&quot;common-blue&quot;,&quot;url&quot;:&quot;url&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}" href="http://surfingbird.ru/share" target="_blank">Share</a>""");
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