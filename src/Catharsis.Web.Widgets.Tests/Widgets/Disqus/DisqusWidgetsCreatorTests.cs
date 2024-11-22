using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Test set for class <see cref="DisqusWidgetsCreator"/>.</para>
/// </summary>
public sealed class DisqusWidgetsCreatorTests : ClassTest<DisqusWidgetsCreator>
{
  private readonly IDisqusWidgetsCreator widgets = Widgets.Web.Disqus();

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    widgets.Comments().Should().BeOfType<DisqusCommentsWidget>().And.NotBeSameAs(widgets.Comments());
  }
}