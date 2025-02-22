namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42PanelWidget"/>
public class Share42PanelWidget : WebWidget, IShare42PanelWidget
{
  private Share42PanelDirection DirectionProperty { get; set; } = Share42PanelDirection.Horizontal;
  private byte SizeProperty { get; set; } = (byte) Share42PanelSize.Size24;

  /// <inheritdoc cref="IShare42PanelWidget.Size()"/>
  public byte Size() => SizeProperty;

  /// <inheritdoc cref="IShare42PanelWidget.Size(byte)"/>
  public IShare42PanelWidget Size(byte size)
  {
    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IShare42PanelWidget.Direction()"/>
  public Share42PanelDirection Direction() => DirectionProperty;

  /// <inheritdoc cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
  public IShare42PanelWidget Direction(Share42PanelDirection direction)
  {
    DirectionProperty = direction;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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