using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IGravatarProfileUrlWidget"/>.</para>
/// </summary>
public static class IGravatarProfileUrlWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IGravatarProfileUrlWidget widget)
  {
    /// <summary>
    ///   <para>Email address of the user whose profile is requested.</para>
    /// </summary>
    /// <param name="email">User's email address.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="email"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="email"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Hash(string)"/>
    public IGravatarProfileUrlWidget Email(string email)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (email is null) throw new ArgumentNullException(nameof(email));
      if (email.IsEmpty()) throw new ArgumentException(nameof(email));

      return widget.Hash(email.Trim().ToLowerInvariant().ToBytes(Encoding.ASCII).HashMd5().ToHex().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Requests JSON format for user's profile data.</para>
    /// </summary>
    /// <param name="callback">Callback JavaScript function to be wrapped around the resulting JSON object.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public IGravatarProfileUrlWidget Json(string callback = null)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));

      if (!callback.IsUnset())
      {
        widget.Parameter("callback", callback);
      }
      
      return widget.Format("json");
    }

    /// <summary>
    ///   <para>Requests XML format for user's profile data.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public IGravatarProfileUrlWidget Xml() => widget?.Format("xml") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Requests PHP format for user's profile data.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public IGravatarProfileUrlWidget Php() => widget?.Format("php") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Requests VCF/vCard format for user's profile data.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public IGravatarProfileUrlWidget Vcf() => widget?.Format("vcf") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Requests QR code format for user's profile data.</para>
    /// </summary>
    /// <param name="size">Edge length in pixels of the desired QR code image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public IGravatarProfileUrlWidget Qr(short? size = null)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));

      if (size is not null)
      {
        widget.Parameter("size", size);
      }

      return widget.Format("qr");
    }
  }
}