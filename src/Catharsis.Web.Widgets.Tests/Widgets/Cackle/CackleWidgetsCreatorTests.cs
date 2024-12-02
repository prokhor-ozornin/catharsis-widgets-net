using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleWidgetsCreator"/>.</para>
/// </summary>
public sealed class CackleWidgetsCreatorTests : ClassTest<CackleWidgetsCreator>
{
  private readonly ICackleWidgetsCreator widgets = Widgets.Web.Cackle();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<ICackleWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    widgets.Comments().Should().BeOfType<CackleCommentsWidget>().And.NotBeSameAs(widgets.Comments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.CommentsCount()"/> method.</para>
  /// </summary>
  [Fact]
  public void CommentsCount_Method()
  {
    widgets.CommentsCount().Should().BeOfType<CackleCommentsCountWidget>().And.NotBeSameAs(widgets.CommentsCount());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.LatestComments()"/> method.</para>
  /// </summary>
  [Fact]
  public void LatestComments_Method()
  {
    widgets.LatestComments().Should().BeOfType<CackleLatestCommentsWidget>().And.NotBeSameAs(widgets.LatestComments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.Login()"/> method.</para>
  /// </summary>
  [Fact]
  public void Login_Method()
  {
    widgets.Login().Should().BeOfType<CackleWidgetsCreator>().And.NotBeSameAs(widgets.Login());
  }
}