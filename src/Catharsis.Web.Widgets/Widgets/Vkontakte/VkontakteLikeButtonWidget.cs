using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteLikeButtonWidget"/>
public class VkontakteLikeButtonWidget : WebWidget, IVkontakteLikeButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? VerbProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DescriptionProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ImageProperty { get; set; }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.ElementId(string)"/>
  public virtual IVkontakteLikeButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Height(string)"/>
  public virtual IVkontakteLikeButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Layout(string)"/>
  public virtual IVkontakteLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Description(string)"/>
  public virtual IVkontakteLikeButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionProperty = description;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Image(string)"/>
  public virtual IVkontakteLikeButtonWidget Image(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    ImageProperty = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Title(string)"/>
  public virtual IVkontakteLikeButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleProperty = title;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Url(string)"/>
  public virtual IVkontakteLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Text(string)"/>
  public virtual IVkontakteLikeButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextProperty = text;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Verb(byte)"/>
  public virtual IVkontakteLikeButtonWidget Verb(byte verb)
  {
    VerbProperty = verb;
    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Width(string)"/>
  public virtual IVkontakteLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  public override object Clone() => new VkontakteLikeButtonWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>();
      
    if (!LayoutProperty.IsUnset())
    {
      config["type"] = LayoutProperty;
    }

    if (!WidthProperty.IsUnset())
    {
      config["width"] = WidthProperty;
    }

    if (!TitleProperty.IsUnset())
    {
      config["pageTitle"] = TitleProperty;
    }

    if (!DescriptionProperty.IsUnset())
    {
      config["pageDescription"] = DescriptionProperty;
    }

    if (!UrlProperty.IsUnset())
    {
      config["pageUrl"] = UrlProperty;
    }

    if (!ImageProperty.IsUnset())
    {
      config["pageImage"] = ImageProperty;
    }

    if (!TextProperty.IsUnset())
    {
      config["text"] = TextProperty;
    }
    
    if (!HeightProperty.IsUnset())
    {
      config["height"] = HeightProperty;
    }
    
    if (VerbProperty is not null)
    {
      config["verb"] = VerbProperty;
    }

    var id = ElementIdProperty ?? "vk_like";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Like(\"${id}\", ${config.Json()});"))
      .ToString();
  }
}