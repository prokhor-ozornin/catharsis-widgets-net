using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte comments widget.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  ///   <seealso cref="http://vk.com/dev/Comments"/>
  /// </summary>
  public sealed class VkontakteCommentsWidget : HtmlWidgetBase, IVkontakteCommentsWidget
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      var config = new Dictionary<string, object> { { "limit", this.limit }};
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

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "vk_comments")));
      writer.Write(this.JavaScript(@"VK.Widgets.Comments(""vk_comments"", {0});".FormatSelf(config.Json())));
    }
  }
}