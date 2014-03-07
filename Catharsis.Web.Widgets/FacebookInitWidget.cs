using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of Facebook JavaScript API. Initialization must be performed before rendering Facebook widgets on the page.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Facebook"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/javascript"/>
  public sealed class FacebookInitWidget : HtmlWidgetBase<IFacebookInitWidget>, IFacebookInitWidget
  {
    private string appId;

    /// <summary>
    ///   <para>Identifier of registered Facebook application.</para>
    /// </summary>
    /// <param name="id">Identifier of Facebook application.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IFacebookInitWidget AppId(string id)
    {
      Assertion.NotEmpty(id);

      this.appId = id;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.appId.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "fb-root")));
      writer.Write(resources.facebook_initialize.FormatSelf(this.appId));
    }
  }
}