using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestProfileWidget"/>.</para>
/// </summary>
public sealed class PinterestProfileWidgetTest : Test
{
  private IPinterestProfileWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PinterestProfileWidgetTest() => Widget = Fixture<IPinterestProfileWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestProfileWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestProfileWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestProfileWidget>();

    using (new AssertionScope())
    {
      var widget = new PinterestProfileWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("ImageValue").Should().BeNull();
    }
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
      AssertionExtensions.Should(() => new PinterestProfileWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, IPinterestProfileWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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
      AssertionExtensions.Should(() => new PinterestProfileWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IPinterestProfileWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
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
      AssertionExtensions.Should(() => new PinterestProfileWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IPinterestProfileWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
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
      AssertionExtensions.Should(() => new PinterestProfileWidget().Image(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("image");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string image, IPinterestProfileWidget widget) => widget.Image(image).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageValue").Should().Be(image);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestProfileWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new PinterestProfileWidget());
      Test(Fixture<PinterestProfileWidget>.Create());
    }

    return;

    static void Test(IPinterestProfileWidget original)
    {
      var clone = original.Clone<IPinterestProfileWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("ImageValue").Should().Be(original.GetPropertyValue<string>("ImageValue"));
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
      Test(new PinterestProfileWidget());
      Test(new PinterestProfileWidget().Account("account"), """<a data-pin-do="embedUser" href="http://www.pinterest.com/account"></a>""");
      Test(new PinterestProfileWidget().Account("account").Width("width").Height("height").Image("image"), """<a data-pin-board-width="width" data-pin-do="embedUser" data-pin-scale-height="height" data-pin-scale-width="image" href="http://www.pinterest.com/account"></a>""");
      Test(Fixture<PinterestProfileWidget>.Create());
    }

    return;

    static void Test(IPinterestProfileWidget widget, params string[] html)
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