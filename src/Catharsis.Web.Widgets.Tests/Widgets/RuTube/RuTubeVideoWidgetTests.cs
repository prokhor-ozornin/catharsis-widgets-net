using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RuTubeVideoWidget"/>.</para>
/// 
/// </summary>
public sealed class RuTubeVideoWidgetTests : ClassTest<RuTubeVideoWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="RuTubeVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(RuTubeVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IRuTubeVideoWidget>();

    var widget = new RuTubeVideoWidget();
    widget.Id().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new RuTubeVideoWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new RuTubeVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IRuTubeVideoWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new RuTubeVideoWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new RuTubeVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IRuTubeVideoWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new RuTubeVideoWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new RuTubeVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IRuTubeVideoWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new RuTubeVideoWidget().ToString());
    Assert.Equal(string.Empty, new RuTubeVideoWidget().Id("id").Height("height").ToString());
    Assert.Equal(string.Empty, new RuTubeVideoWidget().Id("id").Width("width").ToString());
    Assert.Equal(string.Empty, new RuTubeVideoWidget().Height("height").Width("width").ToString());
    Assert.Equal("""<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" scrolling="no" src="http://rutube.ru/embed/id" webkitallowfullscreen="true" width="width"></iframe>""", new RuTubeVideoWidget().Id("id").Height("height").Width("width").ToString());
  }
}