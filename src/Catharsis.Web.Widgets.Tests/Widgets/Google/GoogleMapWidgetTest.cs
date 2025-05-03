using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleMapWidget"/>.</para>
/// </summary>
public sealed class GoogleMapWidgetTest : UnitTest
{
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
      Validate(new GoogleMapWidget());
      Validate(Attributes.GoogleMapWidget());
    }

    return;

    static void Validate(IGoogleMapWidget original)
    {
      var clone = original.Clone<IGoogleMapWidget>();

      clone.Id.Should().Be(original.Id);
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
    }

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