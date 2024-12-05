using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Share42PanelWidget"/>.</para>
/// </summary>
public sealed class Share42PanelWidgetTests : ClassTest<Share42PanelWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="Share42PanelWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(Share42PanelWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IShare42PanelWidget>();

    var widget = new Share42PanelWidget();
    widget.Size().Should().Be((byte) Share42PanelSize.Size24);
    widget.Direction().Should().Be(Share42PanelDirection.Horizontal);
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