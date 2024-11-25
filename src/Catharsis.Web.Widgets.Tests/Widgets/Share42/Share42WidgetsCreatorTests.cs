using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Share42WidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="Share42WidgetsCreator"/>
public sealed class Share42WidgetsCreatorTests : ClassTest<Share42WidgetsCreator>
{
  private readonly IShare42WidgetsCreator widgets = Widgets.Web.Share42();

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42WidgetsCreator.Panel()"/> method.</para>
  /// </summary>
  [Fact]
  public void Panel_Method()
  {
    widgets.Panel().Should().BeOfType<Share42PanelWidget>().And.NotBeSameAs(widgets.Panel());
  }
}