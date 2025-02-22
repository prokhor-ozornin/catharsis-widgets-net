using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontaktePostWidget"/>
public class VkontaktePostWidget : WebWidget, IVkontaktePostWidget
{
  private string ElementIdProperty { get; set; }
  private string HashProperty { get; set; }
  private string IdProperty { get; set; }
  private string OwnerProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId(string)"/>
  public IVkontaktePostWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId()"/>
  public string ElementId() => ElementIdProperty;

  /// <inheritdoc cref="IVkontaktePostWidget.Id(string)"/>
  public IVkontaktePostWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId()"/>
  public string Id() => IdProperty;

  /// <inheritdoc cref="IVkontaktePostWidget.Owner(string)"/>
  public IVkontaktePostWidget Owner(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    OwnerProperty = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Owner()"/>
  public string Owner() => OwnerProperty;

  /// <inheritdoc cref="IVkontaktePostWidget.Hash(string)"/>
  public IVkontaktePostWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashProperty = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Hash()"/>
  public string Hash() => HashProperty;

  /// <inheritdoc cref="IVkontaktePostWidget.Width(string)"/>
  public IVkontaktePostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"(function() {{ window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(\"{id}\", {Owner()}, {Id()}, \"{Hash()}\", {config.Json()}) || setTimeout(arguments.callee, 50); }}());"))
      .ToString();
  }
}