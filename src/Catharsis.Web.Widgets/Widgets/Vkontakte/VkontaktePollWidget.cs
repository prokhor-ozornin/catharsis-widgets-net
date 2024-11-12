using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontaktePollWidget"/>
public class VkontaktePollWidget : HtmlWidget, IVkontaktePollWidget
{
  private string elementId;
  private string id;
  private string url;
  private string width;

  /// <summary>
  ///   <para>Unique identifier of poll.</para>
  /// </summary>
  /// <param name="id">Identifier of poll.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontaktePollWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;

    return this;
  }

  /// <summary>
  ///   <para>Unique identifier of poll.</para>
  /// </summary>
  /// <returns>Identifier of poll.</returns>
  public string Id() => id;

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <param name="id">HTML element's identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontaktePollWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;
      
    return this;
  }

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <returns>HTML element's identifier.</returns>
  public string ElementId() => elementId;

  /// <summary>
  ///   <para>Horizontal width of widget.</para>
  /// </summary>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontaktePollWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <summary>
  ///   <para>Horizontal width of widget.</para>
  /// </summary>
  /// <returns>Width of widget.</returns>
  public string Width() => width;

  /// <summary>
  ///   <para>URL address of poll's web page, if it differs from the current one.</para>
  /// </summary>
  /// <param name="url">Poll's web page URL.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontaktePollWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;

    return this;
  }

  /// <summary>
  ///   <para>URL address of poll's web page, if it differs from the current one.</para>
  /// </summary>
  /// <returns>Poll's web page URL.</returns>
  public string Url() => url;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    if (Id().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>();
    if (!Url().IsEmpty())
    {
      config["pageUrl"] = Url();
    }
    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }

    var elementId = ElementId() ?? $"vk_poll_{Id()}";
      
    return new TagBuilder("div").Attribute("id", elementId).ToString() + new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(string.Format(@"VK.Widgets.Poll(""{0}"", {1}, ""{2}""));", elementId, config.Json(), Id()));
  }
}