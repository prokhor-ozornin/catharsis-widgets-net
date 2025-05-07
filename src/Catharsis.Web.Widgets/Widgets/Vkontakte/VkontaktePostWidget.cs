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
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string OwnerValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IVkontaktePostWidget.ElementId(string)"/>
  public virtual IVkontaktePostWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Id(string)"/>
  public virtual IVkontaktePostWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Owner(string)"/>
  public virtual IVkontaktePostWidget Owner(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    OwnerValue = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Hash(string)"/>
  public virtual IVkontaktePostWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashValue = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePostWidget.Width(string)"/>
  public virtual IVkontaktePostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontaktePostWidget
  {
    ElementIdValue = ElementIdValue,
    HashValue = HashValue,
    IdValue = IdValue,
    OwnerValue = OwnerValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (IdValue.IsUnset() || OwnerValue.IsUnset() || HashValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>();
    
    if (!WidthValue.IsUnset())
    {
      config["width"] = WidthValue;
    }

    var id = ElementIdValue ?? $"vk_post_${OwnerValue}_${IdValue}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"(function() {{ window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(\"{id}\", {OwnerValue}, {IdValue}, \"{HashValue}\", {config.Json()}) || setTimeout(arguments.callee, 50); }}());"))
      .ToString();
  }
}