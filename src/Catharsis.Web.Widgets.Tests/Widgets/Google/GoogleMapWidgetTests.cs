using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleMapWidget"/>.</para>
/// </summary>
public sealed class GoogleMapWidgetTests : ClassTest<GoogleMapWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GoogleMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GoogleMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGoogleMapWidget>();

    var widget = new GoogleMapWidget();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleMapWidget.Write(TextWriter)"/> method.</para>
  /// </summary>
  public void Write_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new GoogleMapWidget().Write(null));

    throw new NotImplementedException();
  }
}