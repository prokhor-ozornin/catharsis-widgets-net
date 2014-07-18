using System;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of Facebook JavaScript API. Initialization must be performed before rendering Facebook widgets on the page.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/javascript"/>
  public class FacebookInitializationWidget : HtmlWidget, IFacebookInitializationWidget
  {
    private string appId;

    /// <summary>
    ///   <para>Identifier of registered Facebook application.</para>
    /// </summary>
    /// <param name="appId">Identifier of Facebook application.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="appId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="appId"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IFacebookInitializationWidget AppId(string appId)
    {
      Assertion.NotEmpty(appId);

      this.appId = appId;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of registered Facebook application.</para>
    /// </summary>
    /// <returns>Identifier of Facebook application.</returns>
    public string AppId()
    {
      return this.appId;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.AppId().IsEmpty())
      {
        return string.Empty;
      }

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", "fb-root"))
        .Append(resources.facebook_initialize.FormatSelf(this.AppId()))
        .ToString();
    }
  }
}