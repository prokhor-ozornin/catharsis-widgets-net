using System.Text;
using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteCommentsWidget"/>
public class VkontakteCommentsWidget : WebWidget, IVkontakteCommentsWidget
{
  private IEnumerable<string> attach = Enumerable.Empty<string>();
  private bool? autoPublish;
  private bool? autoUpdate;
  private string elementId;
  private byte limit = (byte)VkontakteCommentsLimit.Limit5;
  private bool? mini;
  private string width;

  /// <summary>
  ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
  /// </summary>
  /// <param name="types">Allowed types of post attachments.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="types"/> is a <c>null</c> reference.</exception>
  public IVkontakteCommentsWidget Attach(params string[] types)
  {
    if (attach is null) throw new ArgumentNullException(nameof(types));

    attach = types;
      
    return this;
  }

  /// <summary>
  ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
  /// </summary>
  /// <returns>Allowed types of post attachments.</returns>
  public IEnumerable<string> Attach() => attach;

  /// <summary>
  ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVkontakteCommentsWidget AutoPublish(bool enabled)
  {
    autoPublish = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</returns>
  public bool? AutoPublish() => autoPublish;

  /// <summary>
  ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVkontakteCommentsWidget AutoUpdate(bool enabled)
  {
    autoUpdate = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</returns>
  public bool? AutoUpdate() => autoUpdate;

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <param name="id">HTML element's identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommentsWidget ElementId(string id)
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
  ///   <para>Whether to use minimalistic mode of widget (small fonts, images, etc.). Default is to use auto mode (determine automatically).</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable minimalistic mode, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVkontakteCommentsWidget Mini(bool? enabled)
  {
    mini = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to use minimalistic mode of widget (small fonts, images, etc.). Default is to use auto mode (determine automatically).</para>
  /// </summary>
  /// <returns><c>true</c> to enable minimalistic mode, <c>false</c> to disable it.</returns>
  public bool? Mini() => mini;

  /// <summary>
  ///   <para>Maximum number of comments to display.</para>
  /// </summary>
  /// <param name="limit">Maximum number of comments.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVkontakteCommentsWidget Limit(byte limit)
  {
    this.limit = limit;
    return this;
  }

  /// <summary>
  ///   <para>Maximum number of comments to display.</para>
  /// </summary>
  /// <returns>Maximum number of comments.</returns>
  public byte Limit() => limit;

  /// <summary>
  ///   <para>Horizontal width of comment area.</para>
  /// </summary>
  /// <param name="width">Width of comments widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <summary>
  ///   <para>Horizontal width of comment area.</para>
  /// </summary>
  /// <returns>Width of comments widget.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "limit", Limit() }
    };
      
    if (Attach().Any())
    {
      config["attach"] = Attach().Join(",");
    }
    else
    {
      config["attach"] = false;
    }

    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }
    
    if (AutoPublish() is not null)
    {
      config["autoPublish"] = AutoPublish().Value ? 1 : 0;
    }
    
    if (AutoUpdate() is not null)
    {
      config["norealtime"] = AutoUpdate().Value ? 0 : 1;
    }
    
    if (Mini() is not null)
    {
      config["mini"] = Mini().Value ? 1 : 0;
    }

    var elementId = ElementId() ?? "vk_comments";

    return new StringBuilder().Append(new TagBuilder("div").Attribute("id", elementId)).Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($@"VK.Widgets.Comments(""${elementId}"", ${config.Json()}))).ToString();
  }
}