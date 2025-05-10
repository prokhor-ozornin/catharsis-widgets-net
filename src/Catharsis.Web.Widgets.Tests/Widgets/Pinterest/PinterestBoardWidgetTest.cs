using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestBoardWidget"/>.</para>
/// </summary>
public sealed class PinterestBoardWidgetTest : Test
{
  private IPinterestBoardWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PinterestBoardWidgetTest() => Widget = Fixture.Create<IPinterestBoardWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestBoardWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestBoardWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestBoardWidget>();

    using (new AssertionScope())
    {
      var widget = new PinterestBoardWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("ImageValue").Should().BeNull();
    }
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
      AssertionExtensions.Should(() => new PinterestBoardWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, IPinterestBoardWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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
      AssertionExtensions.Should(() => new PinterestBoardWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IPinterestBoardWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
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
      AssertionExtensions.Should(() => new PinterestBoardWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IPinterestBoardWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
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
      AssertionExtensions.Should(() => new PinterestBoardWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IPinterestBoardWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id);
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
      AssertionExtensions.Should(() => new PinterestBoardWidget().Image(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("image");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string image, IPinterestBoardWidget widget) => widget.Image(image).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageValue").Should().Be(image);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestBoardWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new PinterestBoardWidget());
      Test(Fixture.Create<PinterestBoardWidget>());
    }

    return;

    static void Test(IPinterestBoardWidget original)
    {
      var clone = original.Clone<IPinterestBoardWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<string>("ImageValue").Should().Be(original.GetPropertyValue<string>("ImageValue"));
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
      Test(new PinterestBoardWidget());
      Test(new PinterestBoardWidget().Account("account"));
      Test(new PinterestBoardWidget().Id("id"));
      Test(new PinterestBoardWidget().Account("account").Id("id"), """<a data-pin-do="embedBoard" href="http://www.pinterest.com/account/id"></a>""");
      Test(new PinterestBoardWidget().Account("account").Id("id").Width("width").Height("height").Image("image"), """<a data-pin-board-width="width" data-pin-do="embedBoard" data-pin-scale-height="height" data-pin-scale-width="image" href="http://www.pinterest.com/account/id"></a>""");
      Test(Fixture.Create<PinterestBoardWidget>());
    }

    return;

    static void Test(IPinterestBoardWidget widget, params string[] html)
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