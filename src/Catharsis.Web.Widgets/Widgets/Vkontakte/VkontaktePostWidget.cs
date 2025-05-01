using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontaktePostWidget"/>
public class VkontaktePostWidget : WebWidget, IVkontaktePostWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string OwnerProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId(string)"/>
  public virtual IVkontaktePostWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Id(string)"/>
  public virtual IVkontaktePostWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Owner(string)"/>
  public virtual IVkontaktePostWidget Owner(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    OwnerProperty = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Hash(string)"/>
  public virtual IVkontaktePostWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashProperty = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Width(string)"/>
  public virtual IVkontaktePostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  public override object Clone() => new VkontaktePostWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (IdProperty.IsUnset() || OwnerProperty.IsUnset() || HashProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>();
    
    if (!WidthProperty.IsUnset())
    {
      config["width"] = WidthProperty;
    }

    var id = ElementIdProperty ?? $"vk_post_${OwnerProperty}_${IdProperty}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"(function() {{ window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(\"{id}\", {OwnerProperty}, {IdProperty}, \"{HashProperty}\", {config.Json()}) || setTimeout(arguments.callee, 50); }}());"))
      .ToString();
  }
}