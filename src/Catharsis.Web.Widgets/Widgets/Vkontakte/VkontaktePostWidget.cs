using System.Web.Mvc;
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

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <param name="id">HTML element's identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontaktePostWidget ElementId(string id)
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
  ///   <para>Unique identifier of wall's post.</para>
  /// </summary>
  /// <param name="id">Identifier of post.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontaktePostWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;
      
    return this;
  }

  /// <summary>
  ///   <para>Unique identifier of wall's post.</para>
  /// </summary>
  /// <returns>Identifier of post.</returns>
  public string Id() => id;

  /// <summary>
  ///   <para>Unique identifier of Vkontakte wall's owner.</para>
  /// </summary>
  /// <param name="id">Identifier of wall's owner.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontaktePostWidget Owner(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    owner = id;
      
    return this;
  }

  /// <summary>
  ///   <para>Unique identifier of Vkontakte wall's owner.</para>
  /// </summary>
  /// <returns>Identifier of wall's owner.</returns>
  public string Owner() => owner;

  /// <summary>
  ///   <para>Unique hash code of wall's post.</para>
  /// </summary>
  /// <param name="hash">Hash code of post.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontaktePostWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    this.hash = hash;

    return this;
  }

  /// <summary>
  ///   <para>Unique hash code of wall's post.</para>
  /// </summary>
  /// <returns>Hash code of post.</returns>
  public string Hash() => hash;

  /// <summary>
  ///   <para>Width of wall's post. Default is the width of entire screen.</para>
  /// </summary>
  /// <param name="width">Width of post.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontaktePostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <summary>
  ///   <para>Width of wall's post.</para>
  /// </summary>
  /// <returns>Width of post.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
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

    var elementId = ElementId() ?? $"vk_post_${Owner()}_${Id()}";

    return new TagBuilder("div").Attribute("id", elementId).ToString() + new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($@"(function() {{ window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(""{elementId}"", {Owner()}, {Id()}, ""{Hash()}"", {config.Json()}) || setTimeout(arguments.callee, 50); }}());");
  }
}