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
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? VerbValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DescriptionValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ImageValue { get; set; }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.ElementId(string)"/>
  public virtual IVkontakteLikeButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Height(string)"/>
  public virtual IVkontakteLikeButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Layout(string)"/>
  public virtual IVkontakteLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutValue = layout;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Description(string)"/>
  public virtual IVkontakteLikeButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionValue = description;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Image(string)"/>
  public virtual IVkontakteLikeButtonWidget Image(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    ImageValue = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Title(string)"/>
  public virtual IVkontakteLikeButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleValue = title;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Url(string)"/>
  public virtual IVkontakteLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Text(string)"/>
  public virtual IVkontakteLikeButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextValue = text;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Verb(byte)"/>
  public virtual IVkontakteLikeButtonWidget Verb(byte verb)
  {
    VerbValue = verb;
    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Width(string)"/>
  public virtual IVkontakteLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteLikeButtonWidget
  {
    ElementIdValue = ElementIdValue,
    TextValue = TextValue,
    VerbValue = VerbValue,
    LayoutValue = LayoutValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue,
    TitleValue = TitleValue,
    UrlValue = UrlValue,
    DescriptionValue = DescriptionValue,
    ImageValue = ImageValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>();
      
    if (!LayoutValue.IsUnset())
    {
      config["type"] = LayoutValue;
    }

    if (!WidthValue.IsUnset())
    {
      config["width"] = WidthValue;
    }

    if (!TitleValue.IsUnset())
    {
      config["pageTitle"] = TitleValue;
    }

    if (!DescriptionValue.IsUnset())
    {
      config["pageDescription"] = DescriptionValue;
    }

    if (!UrlValue.IsUnset())
    {
      config["pageUrl"] = UrlValue;
    }

    if (!ImageValue.IsUnset())
    {
      config["pageImage"] = ImageValue;
    }

    if (!TextValue.IsUnset())
    {
      config["text"] = TextValue;
    }
    
    if (!HeightValue.IsUnset())
    {
      config["height"] = HeightValue;
    }
    
    if (VerbValue is not null)
    {
      config["verb"] = VerbValue;
    }

    var id = ElementIdValue ?? "vk_like";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Like(\"${id}\", ${config.Json()});"))
      .ToString();
  }
}