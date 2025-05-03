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
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? LimitProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual short? MaxProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteRecommendationsPeriod? PeriodProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteRecommendationsSorting? SortingProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TargetProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteRecommendationsVerb? VerbProperty { get; set; }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.ElementId(string)"/>
  public virtual IVkontakteRecommendationsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Limit(byte)"/>
  public virtual IVkontakteRecommendationsWidget Limit(byte limit)
  {
    LimitProperty = limit;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Max(short)"/>
  public virtual IVkontakteRecommendationsWidget Max(short count)
  {
    MaxProperty = count;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Period(VkontakteRecommendationsPeriod)"/>
  public virtual IVkontakteRecommendationsWidget Period(VkontakteRecommendationsPeriod period)
  {
    PeriodProperty = period;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Verb(VkontakteRecommendationsVerb)"/>
  public virtual IVkontakteRecommendationsWidget Verb(VkontakteRecommendationsVerb verb)
  {
    VerbProperty = verb;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Sorting(VkontakteRecommendationsSorting)"/>
  public virtual IVkontakteRecommendationsWidget Sorting(VkontakteRecommendationsSorting sorting)
  {
    SortingProperty = sorting;
    return this;
  }

  /// <inheritdoc cref="IVkontakteRecommendationsWidget.Target(string)"/>
  public virtual IVkontakteRecommendationsWidget Target(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    TargetProperty = target;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteRecommendationsWidget
  {
    ElementIdProperty = ElementIdProperty,
    LimitProperty = LimitProperty,
    MaxProperty = MaxProperty,
    PeriodProperty = PeriodProperty,
    SortingProperty = SortingProperty,
    TargetProperty = TargetProperty,
    VerbProperty = VerbProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>();
    
    if (LimitProperty is not null)
    {
      config["limit"] = LimitProperty.GetValueOrDefault();
    }
    
    if (MaxProperty is not null)
    {
      config["max"] = MaxProperty.GetValueOrDefault();
    }

    if (PeriodProperty is not null)
    {
      config["period"] = PeriodProperty.GetValueOrDefault().ToString().ToLowerInvariant();
    }
    
    if (VerbProperty is not null)
    {
      config["verb"] = (byte) VerbProperty.GetValueOrDefault();
    }
    
    if (SortingProperty is not null)
    {
      config["sort"] = SortingProperty.GetValueOrDefault() switch
      {
        VkontakteRecommendationsSorting.FriendLikes => "friend_likes",
        VkontakteRecommendationsSorting.Likes => "likes",
        _ => config["sort"]
      };
    }

    if (TargetProperty is not null)
    {
      config["target"] = TargetProperty;
    }

    var id = ElementIdProperty ?? "vk_recommendations";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Recommended(\"${id}\", ${config.Json()});"))
      .ToString();
  }
}