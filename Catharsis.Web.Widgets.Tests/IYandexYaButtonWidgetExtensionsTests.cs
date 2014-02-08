using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYandexLikeButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IYandexYaButtonWidgetExtensionsTests
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
        Assert.True(widget.Field("size").To<string>() == "large");
      });
      new YandexLikeButtonWidget().With(widget => Assert.True(widget.Size(YandexLikeButtonSize.Small).Field("size").To<string>() == "small"));
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
        Assert.True(widget.Field("layout").To<string>() == "button");
      });
      new YandexLikeButtonWidget().With(widget => Assert.True(widget.Layout(YandexLikeButtonLayout.Icon).Field("layout").To<string>() == "icon"));
    }
  }
}