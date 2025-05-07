namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42PanelWidget"/>
public class Share42PanelWidget : WebWidget, IShare42PanelWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual Share42PanelDirection DirectionValue { get; set; } = Share42PanelDirection.Horizontal;
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte SizeValue { get; set; } = (byte) Share42PanelSize.Size24;

  /// <inheritdoc cref="IShare42PanelWidget.Size(byte)"/>
  public virtual IShare42PanelWidget Size(byte size)
  {
    SizeValue = size;
    return this;
  }

  /// <inheritdoc cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
  public virtual IShare42PanelWidget Direction(Share42PanelDirection direction)
  {
    DirectionValue = direction;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new Share42PanelWidget
  {
    DirectionValue = DirectionValue,
    SizeValue = SizeValue
  };

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