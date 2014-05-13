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
    private byte limit = (byte) VkontakteCommentsLimit.Limit5;
    private IEnumerable<string> attach = Enumerable.Empty<string>();
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

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", "vk_comments"))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Comments(""vk_comments"", {0});".FormatSelf(config.Json())))
        .ToString();
    }
  }
}