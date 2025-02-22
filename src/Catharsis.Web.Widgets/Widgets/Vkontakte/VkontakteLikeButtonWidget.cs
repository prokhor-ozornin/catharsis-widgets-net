using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteLikeButtonWidget"/>
public class VkontakteLikeButtonWidget : WebWidget, IVkontakteLikeButtonWidget
{
  private string ElementIdProperty { get; set; }
  private string TextProperty { get; set; }
  private byte? VerbProperty { get; set; }
  private string LayoutProperty { get; set; }
  private string WidthProperty { get; set; }
  private string HeightProperty { get; set; }
  private string TitleProperty { get; set; }
  private string UrlProperty { get; set; }
  private string DescriptionProperty { get; set; }
  private string ImageProperty { get; set; }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.ElementId(string)"/>
  public IVkontakteLikeButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.ElementId()"/>
  public string ElementId() => ElementIdProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Height(string)"/>
  public IVkontakteLikeButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Layout(string)"/>
  public IVkontakteLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Layout()"/>
  public string Layout() => LayoutProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Description(string)"/>
  public IVkontakteLikeButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionProperty = description;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Description()"/>
  public string Description() => DescriptionProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Image(string)"/>
  public IVkontakteLikeButtonWidget Image(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    ImageProperty = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Image()"/>
  public string Image() => ImageProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Title(string)"/>
  public IVkontakteLikeButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleProperty = title;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Title()"/>
  public string Title() => TitleProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Url(string)"/>
  public IVkontakteLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Text(string)"/>
  public IVkontakteLikeButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextProperty = text;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Text()"/>
  public string Text() => TextProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Verb(byte)"/>
  public IVkontakteLikeButtonWidget Verb(byte verb)
  {
    VerbProperty = verb;
    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Verb()"/>
  public byte? Verb() => VerbProperty;

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Width(string)"/>
  public IVkontakteLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteLikeButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>();
      
    if (!Layout().IsEmpty())
    {
      config["type"] = Layout();
    }

    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }

    if (!Title().IsEmpty())
    {
      config["pageTitle"] = Title();
    }

    if (!Description().IsEmpty())
    {
      config["pageDescription"] = Description();
    }

    if (!Url().IsEmpty())
    {
      config["pageUrl"] = Url();
    }

    if (!Image().IsEmpty())
    {
      config["pageImage"] = Image();
    }

    if (!Text().IsEmpty())
    {
      config["text"] = Text();
    }
    
    if (!Height().IsEmpty())
    {
      config["height"] = Height();
    }
    
    if (Verb() is not null)
    {
      config["verb"] = Verb();
    }

    var id = ElementId() ?? "vk_like";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Like(\"${id}\", ${config.Json()});"))
      .ToString();
  }
}