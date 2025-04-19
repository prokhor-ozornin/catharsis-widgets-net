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

      new VkontakteAuthButtonWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short width, IVkontakteAuthButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Standard(IVkontakteAuthButtonWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Standard_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteAuthButtonWidgetExtensions.Standard(null, "url")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Standard(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Standard(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");
    }

    return;

    static void Validate(string url, IVkontakteAuthButtonWidget widget) => widget.Standard(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteAuthButtonType>("TypeProperty").Should().Be(VkontakteAuthButtonType.Standard).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Dynamic(IVkontakteAuthButtonWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Dynamic_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteAuthButtonWidgetExtensions.Dynamic(null, "callback")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Dynamic(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Dynamic(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");
    }

    return;

    static void Validate(string callback, IVkontakteAuthButtonWidget widget) => widget.Dynamic(callback).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteAuthButtonType>("TypeProperty").Should().Be(VkontakteAuthButtonType.Dynamic).And.Subject.GetPropertyValue<string>("CallbackProperty").Should().Be(callback);
  }
}