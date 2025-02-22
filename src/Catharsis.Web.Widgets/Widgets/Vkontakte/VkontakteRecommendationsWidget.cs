using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteRecommendationsWidget"/>
public class VkontakteRecommendationsWidget : WebWidget, IVkontakteRecommendationsWidget
{
  private string ElementIdProperty { get; set; }
  private byte? LimitProperty { get; set; }
  private short? MaxProperty { get; set; }
  private VkontakteRecommendationsPeriod? PeriodProperty { get; set; }
  private VkontakteRecommendationsSorting? SortingProperty { get; set; }
  private string TargetProperty { get; set; }
  private VkontakteRecommendationsVerb? VerbProperty { get; set; }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.ElementId(string)"/>
  public IVkontakteRecommendationsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.ElementId()"/>
  public string ElementId() => ElementIdProperty;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Limit(byte)"/>
  public IVkontakteRecommendationsWidget Limit(byte limit)
  {
    LimitProperty = limit;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Limit()"/>
  public byte? Limit() => LimitProperty;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Max(short)"/>
  public IVkontakteRecommendationsWidget Max(short count)
  {
    MaxProperty = count;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Max()"/>
  public short? Max() => MaxProperty;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/>
  public IVkontakteRecommendationsWidget Period(VkontakteRecommendationsPeriod period)
  {
    PeriodProperty = period;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Period()"/>
  public VkontakteRecommendationsPeriod? Period() => PeriodProperty;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/>
  public IVkontakteRecommendationsWidget Verb(VkontakteRecommendationsVerb verb)
  {
    VerbProperty = verb;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Verb()"/>
  public VkontakteRecommendationsVerb? Verb() => VerbProperty;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/>
  public IVkontakteRecommendationsWidget Sorting(VkontakteRecommendationsSorting sorting)
  {
    SortingProperty = sorting;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Sorting()"/>
  public VkontakteRecommendationsSorting? Sorting() => SortingProperty;

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Target(string)"/>
  public IVkontakteRecommendationsWidget Target(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    TargetProperty = target;

    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Target()"/>
  public string Target() => TargetProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>();
    
    if (Limit() is not null)
    {
      config["limit"] = Limit().GetValueOrDefault();
    }
    
    if (Max() is not null)
    {
      config["max"] = Max().GetValueOrDefault();
    }

    if (Period() is not null)
    {
      config["period"] = Period().GetValueOrDefault().ToString().ToLowerInvariant();
    }
    
    if (Verb() is not null)
    {
      config["verb"] = (byte) Verb().GetValueOrDefault();
    }
    
    if (Sorting() is not null)
    {
      config["sort"] = Sorting().GetValueOrDefault() switch
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

    var id = ElementId() ?? "vk_recommendations";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Recommended(\"${id}\", ${config.Json()});"))
      .ToString();
  }
}