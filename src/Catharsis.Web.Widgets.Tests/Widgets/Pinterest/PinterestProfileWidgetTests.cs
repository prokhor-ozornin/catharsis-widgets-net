using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestProfileWidget"/>.</para>
/// </summary>
public sealed class PinterestProfileWidgetTests : ClassTest<PinterestProfileWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestProfileWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestProfileWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestProfileWidget>();

    var widget = new PinterestProfileWidget();
    widget.Account().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Image().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestProfileWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestProfileWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new PinterestProfileWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

      var widget = new PinterestProfileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IPinterestProfileWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestProfileWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestProfileWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new PinterestProfileWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("height");

      var widget = new PinterestProfileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IPinterestProfileWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestProfileWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestProfileWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new PinterestProfileWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("width");

      var widget = new PinterestProfileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IPinterestProfileWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestProfileWidget.Image(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestProfileWidget().Image(null)).ThrowExactly<ArgumentNullException>().WithParameterName("image");
      AssertionExtensions.Should(() => new PinterestProfileWidget().Image(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("image");

      var widget = new PinterestProfileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string image, IPinterestProfileWidget widget)
    {
      widget.Image(image).Should().BeSameAs(widget);
      widget.Image().Should().Be(image);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestProfileWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestProfileWidget());
      Validate(new PinterestProfileWidget().Account("account"), """<a data-pin-do="embedUser" href="http://www.pinterest.com/account"></a>""");
      Validate(new PinterestProfileWidget().Account("account").Width("width").Height("height").Image("image"), """<a data-pin-board-width="width" data-pin-do="embedUser" data-pin-scale-height="height" data-pin-scale-width="image" href="http://www.pinterest.com/account"></a>""");
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