using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontaktePostWidget"/>
public class VkontaktePostWidget : WebWidget, IVkontaktePostWidget
{
  private string elementId;
  private string hash;
  private string id;
  private string owner;
  private string width;

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId(string)"/>
  public IVkontaktePostWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId()"/>
  public string ElementId() => elementId;

  /// <inheritdoc cref="IVkontaktePostWidget.Id(string)"/>
  public IVkontaktePostWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId()"/>
  public string Id() => id;

  /// <inheritdoc cref="IVkontaktePostWidget.Owner(string)"/>
  public IVkontaktePostWidget Owner(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    owner = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Owner()"/>
  public string Owner() => owner;

  /// <inheritdoc cref="IVkontaktePostWidget.Hash(string)"/>
  public IVkontaktePostWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    this.hash = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Hash()"/>
  public string Hash() => hash;

  /// <inheritdoc cref="IVkontaktePostWidget.Width(string)"/>
  public IVkontaktePostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty() || Owner().IsEmpty() || Hash().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>();
    
    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }

    var id = ElementId() ?? $"vk_post_${Owner()}_${Id()}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($@"(function() {{ window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(""{id}"", {Owner()}, {Id()}, ""{Hash()}"", {config.Json()}) || setTimeout(arguments.callee, 50); }}());"))
      .ToString();
  }
}