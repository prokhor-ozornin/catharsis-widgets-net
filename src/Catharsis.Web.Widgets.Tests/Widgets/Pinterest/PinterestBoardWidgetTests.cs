using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestBoardWidget"/>.</para>
/// </summary>
public sealed class PinterestBoardWidgetTests : ClassTest<PinterestBoardWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestBoardWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestBoardWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestBoardWidget>();

    var widget = new PinterestBoardWidget();
    widget.Account().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Id().Should().BeNull();
    widget.Image().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestBoardWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestBoardWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new PinterestBoardWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

      var widget = new PinterestBoardWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IPinterestBoardWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestBoardWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestBoardWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new PinterestBoardWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("height");

      var widget = new PinterestBoardWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IPinterestBoardWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestBoardWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestBoardWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new PinterestBoardWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("width");

      var widget = new PinterestBoardWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IPinterestBoardWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestBoardWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestBoardWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new PinterestBoardWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("id");

      var widget = new PinterestBoardWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IPinterestBoardWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestBoardWidget.Image(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestBoardWidget().Image(null)).ThrowExactly<ArgumentNullException>().WithParameterName("image");
      AssertionExtensions.Should(() => new PinterestBoardWidget().Image(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("image");

      var widget = new PinterestBoardWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string image, IPinterestBoardWidget widget)
    {
      widget.Image(image).Should().BeSameAs(widget);
      widget.Image().Should().Be(image);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestBoardWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestBoardWidget());
      Validate(new PinterestBoardWidget().Account("account"));
      Validate(new PinterestBoardWidget().Id("id"));
      Validate(new PinterestBoardWidget().Account("account").Id("id"), """<a data-pin-do="embedBoard" href="http://www.pinterest.com/account/id"></a>""");
      Validate(new PinterestBoardWidget().Account("account").Id("id").Width("width").Height("height").Image("image"), """<a data-pin-board-width="width" data-pin-do="embedBoard" data-pin-scale-height="height" data-pin-scale-width="image" href="http://www.pinterest.com/account/id"></a>""");
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