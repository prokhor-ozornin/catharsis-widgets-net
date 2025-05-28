using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexMapWidget"/>.</para>
/// </summary>
public sealed class YandexMapWidgetTest : Test
{
  private IYandexMapWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexMapWidgetTest() => Widget = Fixture<IYandexMapWidget>.Create();

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
      Test(new YandexMapWidget());
      Test(Fixture<YandexMapWidget>.Create());
    }

    return;

    static void Test(IYandexMapWidget original)
    {
      var clone = original.Clone<IYandexMapWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(Fixture<YandexMapWidget>.Create());
      throw new NotImplementedException();
    }

    return;

    static void Test(IYandexMapWidget widget, params string[] html)
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