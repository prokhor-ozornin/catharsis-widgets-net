using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISurfingbirdSurfButtonWidget"/>
public class SurfingbirdSurfButtonWidget : WebWidget, ISurfingbirdSurfButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutProperty { get; set; } = SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant();

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
  protected virtual bool CounterProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LabelProperty { get; set; } = "Surf";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorProperty { get; set; }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Color(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Counter(bool)"/>
  public virtual ISurfingbirdSurfButtonWidget Counter(bool enabled)
  {
    CounterProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Height(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Label(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Label(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    LabelProperty = label;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Layout(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Url(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Width(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "layout", $"{LayoutProperty}{(CounterProperty ? string.Empty : "-nocount")}{(ColorProperty.IsUnset() ? string.Empty : "-" + ColorProperty)}"
      }
    };

    if (!UrlProperty.IsUnset())
    {
      config["url"] = UrlProperty;
    }

    if (!WidthProperty.IsUnset())
    {
      config["width"] = WidthProperty;
    }
    
    if (!HeightProperty.IsUnset())
    {
      config["height"] = HeightProperty;
    }

    return new TagBuilder("a")
      .Attribute("target", "_blank")
      .Attribute("href", "http://surfingbird.ru/share")
      .Attribute("data-surf-config", config.Json())
      .CssClass("surfinbird__like_button")
      .Html(LabelProperty)
      .ToString();
  }
}