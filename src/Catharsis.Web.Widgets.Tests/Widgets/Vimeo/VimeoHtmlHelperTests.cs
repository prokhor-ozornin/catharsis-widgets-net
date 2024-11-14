using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VimeoWidgetCreator"/>.</para>
/// </summary>
public sealed class VimeoWidgetCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoWidgetCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(this.html.Vimeo().Video(), this.html.Vimeo().Video()));
    Assert.True(this.html.Vimeo().Video() is VimeoVideoWidget);
  }
}