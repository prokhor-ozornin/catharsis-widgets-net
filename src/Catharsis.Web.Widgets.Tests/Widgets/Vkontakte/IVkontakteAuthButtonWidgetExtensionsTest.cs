using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteAuthButtonWidgetExtensions"/>.</para>
/// </summary>
/// <seealso cref="IVkontakteAuthButtonWidgetExtensions"/>
public sealed class IVkontakteAuthButtonWidgetExtensionsTest : Test
{
  private IVkontakteAuthButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVkontakteAuthButtonWidgetExtensionsTest() => Widget = Fixture<IVkontakteAuthButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Width(IVkontakteAuthButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteAuthButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(short width, IVkontakteAuthButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
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
      
      throw new NotImplementedException();
    }

    return;

    static void Test(string url, IVkontakteAuthButtonWidget widget) => widget.Standard(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteAuthButtonType>("TypeValue").Should().Be(VkontakteAuthButtonType.Standard).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
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
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Dynamic(null)).ThrowExactly<ArgumentNullException>().WithParameterName("callback");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Dynamic(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("callback");
      
      throw new NotImplementedException();
    }

    return;

    static void Test(string callback, IVkontakteAuthButtonWidget widget) => widget.Dynamic(callback).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteAuthButtonType>("TypeValue").Should().Be(VkontakteAuthButtonType.Dynamic).And.Subject.GetPropertyValue<string>("CallbackValue").Should().Be(callback);
  }
}