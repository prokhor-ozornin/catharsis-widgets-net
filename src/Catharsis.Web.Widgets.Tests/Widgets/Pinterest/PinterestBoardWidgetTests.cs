using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

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
    Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Account(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Height(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Width(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Id(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new PinterestBoardWidget().Image(null));
    Assert.Throws<ArgumentException>(() => new PinterestBoardWidget().Image(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Equal(string.Empty, new PinterestBoardWidget().ToString());
    Assert.Equal(string.Empty, new PinterestBoardWidget().Account("account").ToString());
    Assert.Equal(string.Empty, new PinterestBoardWidget().Id("id").ToString());
    Assert.Equal("""<a data-pin-do="embedBoard" href="http://www.pinterest.com/account/id"></a>""", new PinterestBoardWidget().Account("account").Id("id").ToString());
    Assert.Equal("""<a data-pin-board-width="width" data-pin-do="embedBoard" data-pin-scale-height="height" data-pin-scale-width="image" href="http://www.pinterest.com/account/id"></a>""", new PinterestBoardWidget().Account("account").Id("id").Width("width").Height("height").Image("image").ToString());
  }
}