using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexLikeButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new YandexLikeButtonWidget();
      Enum.GetValues<YandexLikeButtonSize>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexLikeButtonSize size, IYandexLikeButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size.ToString().ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexLikeButtonWidgetExtensions.Layout(IYandexLikeButtonWidget, YandexLikeButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexLikeButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new YandexLikeButtonWidget();
      Enum.GetValues<YandexLikeButtonLayout>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexLikeButtonLayout layout, IYandexLikeButtonWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.Layout().Should().Be(layout.ToString().ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexLikeButtonWidgetExtensions.Url(IYandexLikeButtonWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexLikeButtonWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IYandexLikeButtonWidgetExtensions.Url(new YandexLikeButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      var widget = new YandexLikeButtonWidget();
      new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(Uri url, IYandexLikeButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url.ToString());
    }
  }
}