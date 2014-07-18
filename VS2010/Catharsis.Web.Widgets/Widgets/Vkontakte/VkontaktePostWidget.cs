using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Post"/>
  public class VkontaktePostWidget : HtmlWidget, IVkontaktePostWidget
  {
    private string elementId;
    private string hash;
    private string id;
    private string owner;
    private string width;

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontaktePostWidget ElementId(string id)
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
    ///   <para>Unique identifier of wall's post.</para>
    /// </summary>
    /// <param name="id">Identifier of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontaktePostWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Unique identifier of wall's post.</para>
    /// </summary>
    /// <returns>Identifier of post.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Unique identifier of Vkontakte wall's owner.</para>
    /// </summary>
    /// <param name="id">Identifier of wall's owner.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontaktePostWidget Owner(string id)
    {
      Assertion.NotEmpty(id);

      this.owner = id;
      return this;
    }

    /// <summary>
    ///   <para>Unique identifier of Vkontakte wall's owner.</para>
    /// </summary>
    /// <returns>Identifier of wall's owner.</returns>
    public string Owner()
    {
      return this.owner;
    }

    /// <summary>
    ///   <para>Unique hash code of wall's post.</para>
    /// </summary>
    /// <param name="hash">Hash code of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontaktePostWidget Hash(string hash)
    {
      Assertion.NotEmpty(hash);

      this.hash = hash;
      return this;
    }

    /// <summary>
    ///   <para>Unique hash code of wall's post.</para>
    /// </summary>
    /// <returns>Hash code of post.</returns>
    public string Hash()
    {
      return this.hash;
    }

    /// <summary>
    ///   <para>Width of wall's post. Default is the width of entire screen.</para>
    /// </summary>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontaktePostWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Width of wall's post.</para>
    /// </summary>
    /// <returns>Width of post.</returns>
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
      if (this.Id().IsEmpty() || this.Owner().IsEmpty() || this.Hash().IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object>();
      if (!this.Width().IsEmpty())
      {
        config["width"] = this.Width();
      }

      var elementId = this.ElementId() ?? "vk_post_{0}_{1}".FormatSelf(this.Owner(), this.Id());

      return
        new TagBuilder("div").Attribute("id", elementId).ToString() +
        new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"(function() {{ window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(""{0}"", {1}, {2}, ""{3}"", {4}) || setTimeout(arguments.callee, 50); }}());".FormatSelf(elementId, this.Owner(), this.Id(), this.Hash(), config.Json()));
    }
  }
}