using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontaktePostWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontaktePostWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontaktePostWidgetExtensions.Id(IVkontaktePostWidget, long)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontaktePostWidgetExtensions.Id(null, 0));

      new VkontaktePostWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Id(1), widget));
        Assert.Equal("1", widget.Id());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontaktePostWidgetExtensions.Owner(IVkontaktePostWidget, long)"/> method.</para>
    /// </summary>
    [Fact]
    public void Owner_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontaktePostWidgetExtensions.Owner(null, 0));

      new VkontaktePostWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Owner(1), widget));
        Assert.Equal("1", widget.Owner());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontaktePostWidgetExtensions.Width(IVkontaktePostWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontaktePostWidgetExtensions.Width(null, 0));

      new VkontaktePostWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Width());
      });
    }
  }
}