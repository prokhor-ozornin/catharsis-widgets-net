using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IShare42PanelWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IShare42PanelWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IShare42PanelWidgetExtensions.Horizontal(IShare42PanelWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Horizontal_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IShare42PanelWidgetExtensions.Horizontal(null));

      new Share42PanelWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Horizontal(), widget));
        Assert.True(widget.Field("direction").To<Share42PanelDirection>() == Share42PanelDirection.Horizontal);
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IShare42PanelWidgetExtensions.Size(IShare42PanelWidget, Share42PanelSize)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IShare42PanelWidgetExtensions.Size(null, Share42PanelSize.Size16));

      new Share42PanelWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Size(1), widget));
        Assert.True(widget.Field("size").To<byte>() == 1);
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IShare42PanelWidgetExtensions.Vertical(IShare42PanelWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vertical_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IShare42PanelWidgetExtensions.Horizontal(null));

      new Share42PanelWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Vertical(), widget));
        Assert.True(widget.Field("direction").To<Share42PanelDirection>() == Share42PanelDirection.Vertical);
      });
    }
  }
}