using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="Share42PanelWidget"/>.</para>
  /// </summary>
  public sealed class Share42PanelWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="Share42PanelWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new Share42PanelWidget();
      Assert.True(widget.Field("direction").To<Share42PanelDirection>() == Share42PanelDirection.Horizontal);
      Assert.True(widget.Field("size").To<byte>() == (byte) Share42PanelSize.Size24);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="Share42PanelWidget.Size(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      var widget = new Share42PanelWidget();
      Assert.True(widget.Field("size").To<byte>() == (byte)Share42PanelSize.Size24);
      Assert.True(ReferenceEquals(widget.Size(1), widget));
      Assert.True(widget.Field("size").To<byte>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="Share42PanelWidget.Direction(Share42PanelDirection)"/> method.</para>
    /// </summary>
    [Fact]
    public void Direction_Method()
    {
      var widget = new Share42PanelWidget();
      Assert.True(widget.Field("direction").To<Share42PanelDirection>() == Share42PanelDirection.Horizontal);
      Assert.True(ReferenceEquals(widget.Direction(Share42PanelDirection.Vertical), widget));
      Assert.True(widget.Field("direction").To<Share42PanelDirection>() == Share42PanelDirection.Vertical);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="Share42PanelWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      /*new StringWriter().With(writer =>
      {
        new Share42PanelWidget().Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div class=""share42init""></div>"));
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains("http://share42.com"));
        Assert.True(html.Contains("width:24px;height:24px"));
      });
      Assert.True(new StringWriter().With(writer => new Share42PanelWidget().Direction(Share42PanelDirection.Horizontal).Size(Share42PanelSize.Size16).Write(writer)).ToString().Contains("width:16px;height:16px"));
      */

      throw new NotImplementedException();
    }
  }
}