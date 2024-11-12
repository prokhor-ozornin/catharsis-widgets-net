using System.Text;
using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookInitializationWidget"/>
public class FacebookInitializationWidget : WebWidget, IFacebookInitializationWidget
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
    if (appId is null) throw new ArgumentNullException(nameof(appId));
    if (appId.IsEmpty()) throw new ArgumentException(nameof(appId));

    this.appId = appId;
    return this;
  }

  /// <summary>
  ///   <para>Identifier of registered Facebook application.</para>
  /// </summary>
  /// <returns>Identifier of Facebook application.</returns>
  public string AppId() => appId;

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
  public override string ToHtml()
  {
    if (AppId().IsEmpty())
    {
      return string.Empty;
    }

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", "fb-root"))
      .Append(string.Format(resources.facebook_initialize, AppId()))
      .ToString();
  }
}