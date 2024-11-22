using Catharsis.Commons;
using Catharsis.Extensions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexLikeButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexLikeButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexLikeButtonWidgetExtensions.Size(IYandexLikeButtonWidget, YandexLikeButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IYandexLikeButtonWidgetExtensions.Size(null, YandexLikeButtonSize.Large));

    new YandexLikeButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Size(YandexLikeButtonSize.Large), widget));
      Assert.Equal("large", widget.Size());
    });
    new YandexLikeButtonWidget().With(widget => Assert.Equal("small", widget.Size(YandexLikeButtonSize.Small).Size()));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexLikeButtonWidgetExtensions.Layout(IYandexLikeButtonWidget, YandexLikeButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    new YandexLikeButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Layout(YandexLikeButtonLayout.Button), widget));
      Assert.Equal("button", widget.Layout());
    });
    new YandexLikeButtonWidget().With(widget => Assert.Equal("icon", widget.Layout(YandexLikeButtonLayout.Icon).Layout()));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexLikeButtonWidgetExtensions.Url(IYandexLikeButtonWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    throw new NotImplementedException();
  }
}