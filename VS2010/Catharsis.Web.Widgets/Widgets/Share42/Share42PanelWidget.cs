using System;

namespace Catharsis.Web.Widgets
{
  internal sealed class Share42PanelWidget : HtmlWidgetBase, IShare42PanelWidget
  {
    private Share42PanelDirection direction = Share42PanelDirection.Horizontal;
    private byte size = (byte) Share42PanelSize.Size24;
    
    public IShare42PanelWidget Size(byte size)
    {
      this.size = size;
      return this;
    }

    public IShare42PanelWidget Direction(Share42PanelDirection direction)
    {
      this.direction = direction;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      /*writer.Write(this.ToTag("div", tag => tag.AddCssClass("share42init")));
      switch (this.direction)
      {
        case Share42PanelDirection.Vertical:
          //writer.Write(this.JavaScript(resources.share42_panel_vertical.FormatValue(this.size)));
          break;

        default:
          //writer.Write(this.JavaScript(resources.share42_panel_horizontal.FormatValue(this.size)));
          break;
      }*/

      throw new NotImplementedException();
    }
  }
}