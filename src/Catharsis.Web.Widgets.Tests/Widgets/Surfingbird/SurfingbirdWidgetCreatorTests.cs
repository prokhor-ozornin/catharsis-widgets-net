using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="SurfingbirdWidgetCreator"/>.</para>
/// </summary>
public sealed class SurfingbirdWidgetCreatorTests : ClassTest<SurfingbirdWidgetCreator>
{
  private readonly ISurfingbirdWidgetCreator widgets = Widgets.Web.Surfingbird();

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdWidgetCreator.SurfButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void SurfButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.SurfButton(), widgets.SurfButton()));
    Assert.True(widgets.SurfButton() is SurfingbirdSurfButtonWidget);
  }
}