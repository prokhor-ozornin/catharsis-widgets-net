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
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  ///   <seealso cref="http://vk.com/dev/Comments"/>
  /// </summary>
  public class VkontakteCommentsWidget : HtmlWidgetBase, IVkontakteCommentsWidget
  {
    private byte limit = (byte) VkontakteCommentsLimit.Limit5;
    private IEnumerable<string> attach = Enumerable.Empty<string>();
    private string width;

    /// <summary>
    ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <param name="attach">Allowed types of post attachments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="attach"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="attach"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommentsWidget Attach(params string[] attach)
    {
      Assertion.NotNull(attach);

      this.attach = attach;
      return this;
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
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      var config = new Dictionary<string, object> { { "limit", this.limit } };
      
      if (this.attach.Any())
      {
        config["attach"] = this.attach.Join(",");
      }
      else
      {
        config["attach"] = false;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", "vk_comments"))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Comments(""vk_comments"", {0});".FormatSelf(config.Json())))
        .ToString();
    }
  }
}