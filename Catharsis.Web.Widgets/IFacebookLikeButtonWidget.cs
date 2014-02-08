using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook "Like"/"Recommend" button.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  ///   <seealso cref="https://developers.facebook.com/docs/plugins/like-button"/>
  /// </summary>
  public interface IFacebookLikeButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies absolute URL of the page that will be liked.</para>
    /// </summary>
    /// <param name="url">URL of the page to "like".</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IFacebookLikeButtonWidget Url(string url);

    /// <summary>
    ///   <para>Selects one of the different layouts that are available for the button. Default is "standard".</para>
    /// </summary>
    /// <param name="layout">Button layout.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeButtonWidget Layout(string layout);

    /// <summary>
    ///   <para>Specifies the width of the button. The layout you choose affects the minimum and default widths you can use.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeButtonWidget Width(string width);

    /// <summary>
    ///   <para>Specifies the verb to display on the button. Default is "like".</para>
    /// </summary>
    /// <param name="verb">Verb on the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="verb"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="verb"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeButtonWidget Verb(string verb);

    /// <summary>
    ///   <para>Specifies color scheme used by the button. Default is "light".</para>
    /// </summary>
    /// <param name="scheme">The color scheme for the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeButtonWidget ColorScheme(string scheme);

    /// <summary>
    ///   <para>Specifies whether to display profile photos below the button (standard layout only). You must not enable this on child-directed sites. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to display profile photos, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookLikeButtonWidget ShowFaces(bool show = true);

    /// <summary>
    ///   <para>Specifies label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <param name="label">Label to track referrals.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeButtonWidget TrackLabel(string label);

    /// <summary>
    ///   <para>Specifies if your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="forKids"><c>true</c> if site is directed to small children, <c>false</c> otherwise.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookLikeButtonWidget ForKids(bool forKids = true);
  }
}