using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISurfingbirdSurfButtonWidget"/>
public class SurfingbirdSurfButtonWidget : WebWidget, ISurfingbirdSurfButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutValue { get; set; } = nameof(SurfingbirdSurfButtonLayout.Common).ToLowerInvariant();

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
  protected virtual bool CounterValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LabelValue { get; set; } = "Surf";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorValue { get; set; }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Color(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorValue = color;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Counter(bool)"/>
  public virtual ISurfingbirdSurfButtonWidget Counter(bool enabled)
  {
    CounterValue = enabled;
    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Height(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Label(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Label(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    LabelValue = label;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Layout(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutValue = layout;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Url(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Width(string)"/>
  public virtual ISurfingbirdSurfButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new SurfingbirdSurfButtonWidget
  {
    UrlValue = UrlValue,
    LayoutValue = LayoutValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue,
    CounterValue = CounterValue,
    LabelValue = LabelValue,
    ColorValue = ColorValue
  };
  
  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "layout", $"{LayoutValue}{(CounterValue ? string.Empty : "-nocount")}{(ColorValue.IsUnset() ? string.Empty : "-" + ColorValue)}"
      }
    };

    if (!UrlValue.IsUnset())
    {
      config["url"] = UrlValue;
    }

    if (!WidthValue.IsUnset())
    {
      config["width"] = WidthValue;
    }
    
    if (!HeightValue.IsUnset())
    {
      config["height"] = HeightValue;
    }

    return new TagBuilder("a")
      .Attribute("target", "_blank")
      .Attribute("href", "http://surfingbird.ru/share")
      .Attribute("data-surf-config", config.Json())
      .CssClass("surfinbird__like_button")
      .Html(LabelValue)
      .ToString();
  }
}