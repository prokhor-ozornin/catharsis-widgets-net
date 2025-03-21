using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Share42WidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="Share42WidgetsCreator"/>
public sealed class Share42WidgetsCreatorTests : UnitTest
{
  private IShare42WidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Share42();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="Share42WidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(Share42WidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IShare42WidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42WidgetsCreator.Panel()"/> method.</para>
  /// </summary>
  [Fact]
  public void Panel_Method()
  {
    Widgets.Panel().Should().BeOfType<Share42PanelWidget>().And.NotBeSameAs(Widgets.Panel());
  }
}