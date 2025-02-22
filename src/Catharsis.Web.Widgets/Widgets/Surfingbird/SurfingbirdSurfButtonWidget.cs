using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISurfingbirdSurfButtonWidget"/>
public class SurfingbirdSurfButtonWidget : WebWidget, ISurfingbirdSurfButtonWidget
{
  private string UrlProperty { get; set; }
  private string LayoutProperty { get; set; } = SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant();
  private string WidthProperty { get; set; }
  private string HeightProperty { get; set; }
  private bool CounterProperty { get; set; }
  private string LabelProperty { get; set; } = "Surf";
  private string ColorProperty { get; set; }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Color(string)"/>
  public ISurfingbirdSurfButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Color()"/>
  public string Color() => ColorProperty;

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Counter(bool)"/>
  public ISurfingbirdSurfButtonWidget Counter(bool enabled)
  {
    CounterProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Counter()"/>
  public bool Counter() => CounterProperty;

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Height(string)"/>
  public ISurfingbirdSurfButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Label(string)"/>
  public ISurfingbirdSurfButtonWidget Label(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    LabelProperty = label;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Label()"/>
  public string Label() => LabelProperty;

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Layout(string)"/>
  public ISurfingbirdSurfButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Layout()"/>
  public string Layout() => LayoutProperty;

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Url(string)"/>
  public ISurfingbirdSurfButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Width(string)"/>
  public ISurfingbirdSurfButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="ISurfingbirdSurfButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "layout", $"{Layout()}{(Counter() ? string.Empty : "-nocount")}{(Color().IsEmpty() ? string.Empty : "-" + Color())}"
      }
    };

    if (!Url().IsEmpty())
    {
      config["url"] = Url();
    }

    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }
    
    if (!Height().IsEmpty())
    {
      config["height"] = Height();
    }

    return new TagBuilder("a")
      .Attribute("target", "_blank")
      .Attribute("href", "http://surfingbird.ru/share")
      .Attribute("data-surf-config", config.Json())
      .CssClass("surfinbird__like_button")
      .Html(Label())
      .ToString();
  }
}