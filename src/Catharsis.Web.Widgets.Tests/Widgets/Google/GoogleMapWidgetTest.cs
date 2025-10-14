using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleMapWidget"/>.</para>
/// </summary>
/// <seealso cref="GoogleMapWidget"/>
public sealed class GoogleMapWidgetTest : Test
{
  private IGoogleMapWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public GoogleMapWidgetTest() => Widget = Fixture<IGoogleMapWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GoogleMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GoogleMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGoogleMapWidget>();

    using (new AssertionScope())
    {
      var widget = new GoogleMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleMapWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new GoogleMapWidget());
      Test(Fixture<GoogleMapWidget>.Create());
    }

    return;

    static void Test(IGoogleMapWidget original)
    {
      var clone = original.Clone<IGoogleMapWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      throw new NotImplementedException();
      Test(Fixture<GravatarImageUrlWidget>.Create());
    }

    return;

    static void Test(IGravatarImageUrlWidget widget, params string[] html)
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