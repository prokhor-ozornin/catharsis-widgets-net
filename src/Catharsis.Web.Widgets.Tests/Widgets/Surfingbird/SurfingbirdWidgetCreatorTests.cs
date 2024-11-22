using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SurfingbirdWidgetsCreator"/>.</para>
/// </summary>
public sealed class SurfingbirdWidgetsCreatorTests : ClassTest<SurfingbirdWidgetsCreator>
{
  private readonly ISurfingbirdWidgetsCreator widgets = Widgets.Web.Surfingbird();

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdWidgetsCreator.SurfButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void SurfButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.SurfButton(), widgets.SurfButton()));
    Assert.True(widgets.SurfButton() is SurfingbirdSurfButtonWidget);
  }
}