using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VimeoWidgetsCreator"/>.</para>
/// </summary>
public sealed class VimeoWidgetsCreatorTests : ClassTest<VimeoWidgetsCreator>
{
  private IVimeoWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Vimeo();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VimeoWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VimeoWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IVimeoWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Widgets.Video().Should().BeOfType<VimeoVideoWidget>().And.NotBeSameAs(Widgets.Video());
  }
}