using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteAuthButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteAuthButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Width(IVkontakteAuthButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteAuthButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontakteAuthButtonWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IVkontakteAuthButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Standard(IVkontakteAuthButtonWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Standard_Method()
  {
    AssertionExtensions.Should(() => IVkontakteAuthButtonWidgetExtensions.Standard(null, "url")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Standard(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
    AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Standard(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

    new VkontakteAuthButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Standard("url"), widget));
      Assert.Equal(VkontakteAuthButtonType.Standard, widget.GetPropertyValue<VkontakteAuthButtonType>("TypeProperty"));
      Assert.Equal("url", widget.GetPropertyValue<string>("UrlProperty"));
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Dynamic(IVkontakteAuthButtonWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Dynamic_Method()
  {
    AssertionExtensions.Should(() => IVkontakteAuthButtonWidgetExtensions.Dynamic(null, "callback")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Dynamic(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
    AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Dynamic(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

    new VkontakteAuthButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Dynamic("callback"), widget));
      Assert.Equal(VkontakteAuthButtonType.Dynamic, widget.GetPropertyValue<VkontakteAuthButtonType>("TypeProperty"));
      Assert.Equal("callback", widget.GetPropertyValue<string>("CallbackProperty"));
    });
  }
}