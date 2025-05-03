using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMapWidget"/>.</para>
/// </summary>
public sealed class YandexMapWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexMapWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMapWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexMapWidget());
      Validate(Attributes.YandexMapWidget());
    }

    return;

    static void Validate(IYandexMapWidget original)
    {
      var clone = original.Clone<IYandexMapWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    throw new NotImplementedException();

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