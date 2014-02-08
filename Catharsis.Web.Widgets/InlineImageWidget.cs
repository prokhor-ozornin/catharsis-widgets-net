using System.IO;
using Catharsis.Commons;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class InlineImageWidget : HtmlWidgetBase<IInlineImageWidget>, IInlineImageWidget
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

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (contents == null)
      {
        return;
      }

      writer.Write(this.ToTag("img", tag => tag.Attribute("src", "data:{1};base64,{0}".FormatValue(Convert.ToBase64String(this.contents), this.format.IsEmpty() ? "image" : this.format))));
    }
  }
}