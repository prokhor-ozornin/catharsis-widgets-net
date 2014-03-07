using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders hyperlink to Vimeo video.</para>
  /// </summary>
  public sealed class VimeoVideoLinkWidget : HtmlWidgetBase<IVimeoVideoLinkWidget>, IVimeoVideoLinkWidget
  {
    private string id;

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVimeoVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "https://vimeo.com/{0}".FormatSelf(this.id))
        .InnerHtml(this.HtmlBody)));
    }
  }
}