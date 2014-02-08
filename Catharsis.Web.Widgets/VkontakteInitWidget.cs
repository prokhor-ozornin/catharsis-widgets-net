using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class VkontakteInitWidget : HtmlWidgetBase<IVkontakteInitWidget>, IVkontakteInitWidget
  {
    private string apiId;

    public IVkontakteInitWidget ApiId(string apiId)
    {
      Assertion.NotEmpty(apiId);

      this.apiId = apiId;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.apiId.IsEmpty())
      {
        return;
      }

      writer.Write(this.JavaScript("VK.init({{apiId:{0}, onlyWidgets:true}});".FormatValue(this.apiId)));
    }
  }
}