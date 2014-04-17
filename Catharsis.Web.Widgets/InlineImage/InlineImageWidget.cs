using System.Web.Mvc;
using Catharsis.Commons;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public class InlineImageWidget : HtmlWidgetBase, IInlineImageWidget
  {
    private byte[] contents;
    private string format;

    public IInlineImageWidget Contents(byte[] contents)
    {
      Assertion.NotNull(contents);

      this.contents = contents;
      return this;
    }

    public IInlineImageWidget Format(string format)
    {
      Assertion.NotEmpty(format);

      this.format = format;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (contents == null)
      {
        return string.Empty;
      }

      return new TagBuilder("img")
        .Attribute("src", "data:{1};base64,{0}".FormatSelf(Convert.ToBase64String(this.contents), this.format.IsEmpty() ? "image" : this.format))
        .ToString();
    }
  }
}