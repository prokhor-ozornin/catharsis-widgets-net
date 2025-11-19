using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IMailRuFacesWidget"/>.</para>
/// </summary>
/// <seealso cref="IMailRuFacesWidget"/>
public static class IMailRuFacesWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IMailRuFacesWidget widget)
  {
    /// <summary>
    ///   <para>Type of font, used for text labels.</para>
    /// </summary>
    /// <param name="font">Font type.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuFacesWidget.Font(string)"/>
    public IMailRuFacesWidget Font(MailRuFacesFont font)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));

      return font switch
      {
        MailRuFacesFont.Arial => widget.Font("Arial"),
        MailRuFacesFont.Georgia => widget.Font("Georgia"),
        MailRuFacesFont.Tahoma => widget.Font("Tahoma"),
        _ => widget
      };
    }

    /// <summary>
    ///   <para>Height of Faces box area.</para>
    /// </summary>
    /// <param name="height">Area height.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuFacesWidget.Height(string)"/>
    public IMailRuFacesWidget Height(short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Width of Faces box area.</para>
    /// </summary>
    /// <param name="width">>Area width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuFacesWidget.Width(string)"/>
    public IMailRuFacesWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}