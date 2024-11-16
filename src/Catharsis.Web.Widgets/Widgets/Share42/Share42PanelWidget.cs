namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42PanelWidget"/>
public class Share42PanelWidget : WebWidget, IShare42PanelWidget
{
  private Share42PanelDirection direction = Share42PanelDirection.Horizontal;
  private byte size = (byte) Share42PanelSize.Size24;

  /// <inheritdoc cref="IShare42PanelWidget.Size(byte)"/>
  public IShare42PanelWidget Size(byte size)
  {
    this.size = size;
    return this;
  }

  /// <inheritdoc cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
  public IShare42PanelWidget Direction(Share42PanelDirection direction)
  {
    this.direction = direction;
    return this;
  }

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    //writer.Write(this.ToTag("div", tag => tag.AddCssClass("share42init")));
    //direction switch
    //{
    //  Share42PanelDirection.Vertical => writer.Write(this.JavaScript(resources.share42_panel_vertical.FormatValue(size))),
    //  _ => writer.Write(this.JavaScript(resources.share42_panel_horizontal.FormatValue(size)))
    //};

    throw new NotImplementedException();
  }
}