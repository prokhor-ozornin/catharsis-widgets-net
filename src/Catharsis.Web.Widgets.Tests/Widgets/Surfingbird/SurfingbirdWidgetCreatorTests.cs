using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SurfingbirdWidgetsCreator"/>.</para>
/// </summary>
public sealed class SurfingbirdWidgetsCreatorTests : UnitTest
{
  private ISurfingbirdWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Surfingbird();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="SurfingbirdWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(SurfingbirdWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<ISurfingbirdWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SurfingbirdWidgetsCreator.SurfButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void SurfButton_Method()
  {
    Widgets.SurfButton().Should().BeOfType<SurfingbirdSurfButtonWidget>().And.NotBeSameAs(Widgets.SurfButton());
  }
}