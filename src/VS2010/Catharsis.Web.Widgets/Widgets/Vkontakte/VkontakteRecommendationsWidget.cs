using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte Recommendations widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Recommended"/>
  public class VkontakteRecommendationsWidget : HtmlWidget, IVkontakteRecommendationsWidget
  {
    private string elementId;
    private byte? limit;
    private short? max;
    private VkontakteRecommendationsPeriod? period;
    private VkontakteRecommendationsSorting? sorting;
    private string target;
    private VkontakteRecommendationsVerb? verb;

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteRecommendationsWidget ElementId(string id)
    {
      Assertion.NotEmpty(id);

      this.elementId = id;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    public string ElementId()
    {
      return this.elementId;
    }

    /// <summary>
    ///   <para>Maximum number of pages to display initially. Default is 5.</para>
    /// </summary>
    /// <param name="limit">Maximum number of pages.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteRecommendationsWidget Limit(byte limit)
    {
      this.limit = limit;
      return this;
    }

    /// <summary>
    ///   <para>Maximum number of pages to display initially. Default is 5.</para>
    /// </summary>
    /// <returns>Maximum number of pages.</returns>
    public byte? Limit()
    {
      return this.limit;
    }

    /// <summary>
    ///   <para>Maximum number of pages to display when "Show all recommendations" is being pressed. Default is 4 * limit.</para>
    /// </summary>
    /// <param name="max">Maximum number of pages.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteRecommendationsWidget Max(short max)
    {
      this.max = max;
      return this;
    }

    /// <summary>
    ///   <para>Maximum number of pages to display when "Show all recommendations" is being pressed. Default is 4 * limit.</para>
    /// </summary>
    /// <returns>Maximum number of pages.</returns>
    public short? Max()
    {
      return this.max;
    }

    /// <summary>
    ///   <para>Report statistical period. Default is "week".</para>
    /// </summary>
    /// <param name="period">Statistical period.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="period"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="period"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteRecommendationsWidget Period(VkontakteRecommendationsPeriod period)
    {
      this.period = period;
      return this;
    }

    /// <summary>
    ///   <para>Report statistical period. Default is "week".</para>
    /// </summary>
    /// <returns>Statistical period.</returns>
    public VkontakteRecommendationsPeriod? Period()
    {
      return this.period;
    }

    /// <summary>
    ///   <para>Numeric code of verb to use as a label. Default is 0 ("like").</para>
    /// </summary>
    /// <param name="verb">Type of verb.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteRecommendationsWidget Verb(VkontakteRecommendationsVerb verb)
    {
      this.verb = verb;
      return this;
    }

    /// <summary>
    ///   <para>Numeric code of verb to use as a label. Default is <see cref="VkontakteRecommendationsVerb.Like"/>.</para>
    /// </summary>
    /// <returns>Type of verb.</returns>
    public VkontakteRecommendationsVerb? Verb()
    {
      return this.verb;
    }

    /// <summary>
    ///   <para>Recommended materials sorting mode. Default is <see cref="VkontakteRecommendationsSorting.FriendLikes"/>.</para>
    /// </summary>
    /// <param name="sorting">Sorting mode.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteRecommendationsWidget Sorting(VkontakteRecommendationsSorting sorting)
    {
      this.sorting = sorting;
      return this;
    }

    /// <summary>
    ///   <para>Recommended materials sorting mode. Default is <see cref="VkontakteRecommendationsSorting.FriendLikes"/>.</para>
    /// </summary>
    /// <returns>Sorting mode.</returns>
    public VkontakteRecommendationsSorting? Sorting()
    {
      return this.sorting;
    }

    /// <summary>
    ///   <para>Target attribute for recommendations HTML hyperlinks. Default is "parent".</para>
    /// </summary>
    /// <param name="target">HTML hyperlinks target value.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="target"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="target"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteRecommendationsWidget Target(string target)
    {
      Assertion.NotEmpty(target);

      this.target = target;
      return this;
    }

    /// <summary>
    ///   <para>Target attribute for recommendations HTML hyperlinks. Default is "parent".</para>
    /// </summary>
    /// <returns>HTML hyperlinks target value.</returns>
    public string Target()
    {
      return this.target;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      var config = new Dictionary<string, object>();
      if (this.Limit() != null)
      {
        config["limit"] = this.Limit().Value;
      }
      if (this.Max() != null)
      {
        config["max"] = this.Max().Value;
      }
      if (this.Period() != null)
      {
        config["period"] = this.Period().Value.ToString().ToLowerInvariant();
      }
      if (this.Verb() != null)
      {
        config["verb"] = (byte) this.Verb().Value;
      }
      if (this.Sorting() != null)
      {
        switch (this.Sorting().Value)
        {
          case VkontakteRecommendationsSorting.FriendLikes :
            config["sort"] = "friend_likes";
          break;

          case VkontakteRecommendationsSorting.Likes :
            config["sort"] = "likes";
          break;
        }
      }
      if (this.Target() != null)
      {
        config["target"] = this.Target();
      }

      var elementId = this.ElementId() ?? "vk_recommendations";

      return
        new TagBuilder("div").Attribute("id", elementId).ToString() +
        new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Recommended(""{0}"", {1});".FormatSelf(elementId, config.Json()));
    }
  }
}