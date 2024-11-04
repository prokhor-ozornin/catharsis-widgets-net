using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte comments widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Comments"/>
  public class VkontakteCommentsWidget : HtmlWidget, IVkontakteCommentsWidget
  {
    private IEnumerable<string> attach = Enumerable.Empty<string>();
    private bool? autoPublish;
    private bool? autoUpdate;
    private string elementId;
    private byte limit = (byte)VkontakteCommentsLimit.Limit5;
    private bool? mini;
    private string width;

    /// <summary>
    ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <param name="types">Allowed types of post attachments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="types"/> is a <c>null</c> reference.</exception>
    public IVkontakteCommentsWidget Attach(params string[] types)
    {
      Assertion.NotNull(attach);

      this.attach = types;
      return this;
    }

    /// <summary>
    ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <returns>Allowed types of post attachments.</returns>
    public IEnumerable<string> Attach()
    {
      return this.attach;
    }

    /// <summary>
    ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteCommentsWidget AutoPublish(bool enabled)
    {
      this.autoPublish = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</returns>
    public bool? AutoPublish()
    {
      return this.autoPublish;
    }

    /// <summary>
    ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteCommentsWidget AutoUpdate(bool enabled)
    {
      this.autoUpdate = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</returns>
    public bool? AutoUpdate()
    {
      return this.autoUpdate;
    }

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommentsWidget ElementId(string id)
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
    ///   <para>Whether to use minimalistic mode of widget (small fonts, images, etc.). Default is to use auto mode (determine automatically).</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable minimalistic mode, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteCommentsWidget Mini(bool? enabled)
    {
      this.mini = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to use minimalistic mode of widget (small fonts, images, etc.). Default is to use auto mode (determine automatically).</para>
    /// </summary>
    /// <returns><c>true</c> to enable minimalistic mode, <c>false</c> to disable it.</returns>
    public bool? Mini()
    {
      return this.mini;
    }

    /// <summary>
    ///   <para>Maximum number of comments to display.</para>
    /// </summary>
    /// <param name="limit">Maximum number of comments.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteCommentsWidget Limit(byte limit)
    {
      this.limit = limit;
      return this;
    }

    /// <summary>
    ///   <para>Maximum number of comments to display.</para>
    /// </summary>
    /// <returns>Maximum number of comments.</returns>
    public byte Limit()
    {
      return this.limit;
    }

    /// <summary>
    ///   <para>Horizontal width of comment area.</para>
    /// </summary>
    /// <param name="width">Width of comments widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommentsWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Horizontal width of comment area.</para>
    /// </summary>
    /// <returns>Width of comments widget.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      var config = new Dictionary<string, object>
      {
        { "limit", this.Limit() }
      };
      
      if (this.Attach().Any())
      {
        config["attach"] = this.Attach().Join(",");
      }
      else
      {
        config["attach"] = false;
      }
      if (!this.Width().IsEmpty())
      {
        config["width"] = this.Width();
      }
      if (this.AutoPublish() != null)
      {
        config["autoPublish"] = this.AutoPublish().Value ? 1 : 0;
      }
      if (this.AutoUpdate() != null)
      {
        config["norealtime"] = this.AutoUpdate().Value ? 0 : 1;
      }
      if (this.Mini() != null)
      {
        config["mini"] = this.Mini().Value ? 1 : 0;
      }

      var elementId = this.ElementId() ?? "vk_comments";

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", elementId))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Comments(""{0}"", {1});".FormatSelf(elementId, config.Json())))
        .ToString();
    }
  }
}