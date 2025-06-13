using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexLikeButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexLikeButtonWidgetExtensionsTest : Test
{
  private IYandexLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IYandexLikeButtonWidgetExtensionsTest() => Widget = Fixture<IYandexLikeButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexLikeButtonWidgetExtensions.Size(IYandexLikeButtonWidget, YandexLikeButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexLikeButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<YandexLikeButtonSize>().ForEach(size => Test(size, Widget));
    }

    return;

    static void Test(YandexLikeButtonSize size, IYandexLikeButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size.ToString().ToLowerInvariant());
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

      Enum.GetValues<YandexLikeButtonLayout>().ForEach(layout => Test(layout, Widget));
    }

    return;

    static void Test(YandexLikeButtonLayout layout, IYandexLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout.ToString().ToLowerInvariant());
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

      new[] { Fixture<Uri>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(Uri url, IYandexLikeButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url.ToString());
  }
}