using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontakteAuthButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteAuthButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Width(IVkontakteAuthButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteAuthButtonWidgetExtensions.Width(null, 0));

      new VkontakteAuthButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Standard(IVkontakteAuthButtonWidget, string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Standard_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteAuthButtonWidgetExtensions.Standard(null, "url"));
      Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Standard(null));
      Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Standard(string.Empty));

      new VkontakteAuthButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Standard("url"), widget));
        Assert.Equal(VkontakteAuthButtonType.Standard, widget.Type());
        Assert.Equal("url", widget.Url());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteAuthButtonWidgetExtensions.Dynamic(IVkontakteAuthButtonWidget, string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Dynamic_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteAuthButtonWidgetExtensions.Dynamic(null, "callback"));
      Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Dynamic(null));
      Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Dynamic(string.Empty));

      new VkontakteAuthButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Dynamic("callback"), widget));
        Assert.Equal(VkontakteAuthButtonType.Dynamic, widget.Type());
        Assert.Equal("callback", widget.Callback());
      });
    }
  }
}