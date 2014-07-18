using System;
using System.Text;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IGravatarProfileUrlWidget"/>.</para>
  /// </summary>
  public static class IGravatarProfileUrlWidgetExtensions
  {
    /// <summary>
    ///   <para>Email address of the user whose profile is requested.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="email">User's email address.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="email"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="email"/> is <see cref="string.Empty"/> string.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Hash(string)"/>
    public static IGravatarProfileUrlWidget Email(this IGravatarProfileUrlWidget widget, string email)
    {
      Assertion.NotNull(widget);
      Assertion.NotEmpty(email);

      return widget.Hash(email.Trim().ToLowerInvariant().Bytes(Encoding.ASCII, false).MD5().Hex().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Requests JSON format for user's profile data.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="callback">Callback JavaScript function to be wrapped around the resulting JSON object.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public static IGravatarProfileUrlWidget Json(this IGravatarProfileUrlWidget widget, string callback = null)
    {
      Assertion.NotNull(widget);

      if (!callback.IsEmpty())
      {
        widget.Parameter("callback", callback);
      }
      
      return widget.Format("json");
    }

    /// <summary>
    ///   <para>Requests XML format for user's profile data.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public static IGravatarProfileUrlWidget Xml(this IGravatarProfileUrlWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Format("xml");
    }

    /// <summary>
    ///   <para>Requests PHP format for user's profile data.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public static IGravatarProfileUrlWidget Php(this IGravatarProfileUrlWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Format("php");
    }

    /// <summary>
    ///   <para>Requests VCF/vCard format for user's profile data.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public static IGravatarProfileUrlWidget Vcf(this IGravatarProfileUrlWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Format("vcf");
    }

    /// <summary>
    ///   <para>Requests QR code format for user's profile data.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Edge length in pixels of the desired QR code image.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGravatarProfileUrlWidget.Format(string)"/>
    public static IGravatarProfileUrlWidget Qr(this IGravatarProfileUrlWidget widget, short? size = null)
    {
      Assertion.NotNull(widget);

      if (size != null)
      {
        widget.Parameter("size", size);
      }

      return widget.Format("qr");
    }
  }
}