using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders hyperlink to Yandex video.</para>
  /// </summary>
  public sealed class YandexVideoLinkWidget : HtmlWidgetBase<IYandexVideoLinkWidget>, IYandexVideoLinkWidget
  {
    private string id;
    private bool highQuality;
    private string user;

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Whether to create link for playing High Definition video. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="highQuality"><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexVideoLinkWidget HighQuality(bool highQuality = true)
    {
      this.highQuality = highQuality;
      return this;
    }

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <param name="user">User's account identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexVideoLinkWidget User(string user)
    {
      Assertion.NotEmpty(user);

      this.user = user;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.user.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "http://video.yandex.ru/users/{1}/view/{0}/#{2}".FormatSelf(this.id, this.user, this.highQuality ? "hq" : string.Empty))
        .InnerHtml(this.HtmlBody)));
    }
  }
}