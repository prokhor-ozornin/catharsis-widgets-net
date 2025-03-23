namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42PanelWidget"/>
public class Share42PanelWidget : WebWidget, IShare42PanelWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual Share42PanelDirection DirectionProperty { get; set; } = Share42PanelDirection.Horizontal;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte SizeProperty { get; set; } = (byte) Share42PanelSize.Size24;

  /// <inheritdoc cref="IShare42PanelWidget.Size(byte)"/>
  public virtual IShare42PanelWidget Size(byte size)
  {
    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
  public virtual IShare42PanelWidget Direction(Share42PanelDirection direction)
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