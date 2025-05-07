using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteRecommendationsWidget"/>
public class VkontakteRecommendationsWidget : WebWidget, IVkontakteRecommendationsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? LimitValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual short? MaxValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteRecommendationsPeriod? PeriodValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteRecommendationsSorting? SortingValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TargetValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteRecommendationsVerb? VerbValue { get; set; }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.ElementId(string)"/>
  public virtual IVkontakteRecommendationsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Limit(byte)"/>
  public virtual IVkontakteRecommendationsWidget Limit(byte limit)
  {
    LimitValue = limit;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Max(short)"/>
  public virtual IVkontakteRecommendationsWidget Max(short count)
  {
    MaxValue = count;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/>
  public virtual IVkontakteRecommendationsWidget Period(VkontakteRecommendationsPeriod period)
  {
    PeriodValue = period;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/>
  public virtual IVkontakteRecommendationsWidget Verb(VkontakteRecommendationsVerb verb)
  {
    VerbValue = verb;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/>
  public virtual IVkontakteRecommendationsWidget Sorting(VkontakteRecommendationsSorting sorting)
  {
    SortingValue = sorting;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Target(string)"/>
  public virtual IVkontakteRecommendationsWidget Target(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    TargetValue = target;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteRecommendationsWidget
  {
    ElementIdValue = ElementIdValue,
    LimitValue = LimitValue,
    MaxValue = MaxValue,
    PeriodValue = PeriodValue,
    SortingValue = SortingValue,
    TargetValue = TargetValue,
    VerbValue = VerbValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>();
    
    if (LimitValue is not null)
    {
      config["limit"] = LimitValue.GetValueOrDefault();
    }
    
    if (MaxValue is not null)
    {
      config["max"] = MaxValue.GetValueOrDefault();
    }

    if (PeriodValue is not null)
    {
      config["period"] = PeriodValue.GetValueOrDefault().ToString().ToLowerInvariant();
    }
    
    if (VerbValue is not null)
    {
      config["verb"] = (byte) VerbValue.GetValueOrDefault();
    }
    
    if (SortingValue is not null)
    {
      config["sort"] = SortingValue.GetValueOrDefault() switch
      {
        VkontakteRecommendationsSorting.FriendLikes => "friend_likes",
        VkontakteRecommendationsSorting.Likes => "likes",
        _ => config["sort"]
      };
    }

    if (TargetValue is not null)
    {
      config["target"] = TargetValue;
    }

    var id = ElementIdValue ?? "vk_recommendations";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Recommended(\"${id}\", ${config.Json()});"))
      .ToString();
  }
}