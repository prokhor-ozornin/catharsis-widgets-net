using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteRecommendationsWidget"/>
public class VkontakteRecommendationsWidget : WebWidget, IVkontakteRecommendationsWidget
{
  private string elementId;
  private byte? limit;
  private short? max;
  private VkontakteRecommendationsPeriod? period;
  private VkontakteRecommendationsSorting? sorting;
  private string target;
  private VkontakteRecommendationsVerb? verb;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.ElementId(string)"/>
  public IVkontakteRecommendationsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.ElementId()"/>
  public string ElementId() => elementId;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Limit(byte)"/>
  public IVkontakteRecommendationsWidget Limit(byte limit)
  {
    this.limit = limit;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Limit()"/>
  public byte? Limit() => limit;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Max(short)"/>
  public IVkontakteRecommendationsWidget Max(short max)
  {
    this.max = max;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Max()"/>
  public short? Max() => max;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/>
  public IVkontakteRecommendationsWidget Period(VkontakteRecommendationsPeriod period)
  {
    this.period = period;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Period()"/>
  public VkontakteRecommendationsPeriod? Period() => period;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/>
  public IVkontakteRecommendationsWidget Verb(VkontakteRecommendationsVerb verb)
  {
    this.verb = verb;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Verb()"/>
  public VkontakteRecommendationsVerb? Verb() => verb;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/>
  public IVkontakteRecommendationsWidget Sorting(VkontakteRecommendationsSorting sorting)
  {
    this.sorting = sorting;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Sorting()"/>
  public VkontakteRecommendationsSorting? Sorting() => sorting;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Target(string)"/>
  public IVkontakteRecommendationsWidget Target(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    this.target = target;

    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Target()"/>
  public string Target() => target;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>();
    
    if (Limit() is not null)
    {
      config["limit"] = Limit().Value;
    }
    
    if (Max() is not null)
    {
      config["max"] = Max().Value;
    }

    if (Period() is not null)
    {
      config["period"] = Period().Value.ToString().ToLowerInvariant();
    }
    
    if (Verb() is not null)
    {
      config["verb"] = (byte) Verb().Value;
    }
    
    if (Sorting() is not null)
    {
      config["sort"] = Sorting().Value switch
      {
        VkontakteRecommendationsSorting.FriendLikes => "friend_likes",
        VkontakteRecommendationsSorting.Likes => "likes",
        _ => config["sort"]
      };
    }

    if (Target() is not null)
    {
      config["target"] = Target();
    }

    var elementId = ElementId() ?? "vk_recommendations";

    return
      new TagBuilder("div").Attribute("id", elementId).ToString() +
      new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($@"VK.Widgets.Recommended(""${elementId}"", ${config.Json()});");
  }
}