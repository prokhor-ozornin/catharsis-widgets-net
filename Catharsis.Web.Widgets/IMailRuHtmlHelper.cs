namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Mail.ru widgets.</para>
  /// </summary>
  public interface IMailRuHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Mail.ru ICQ On-Site widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IMailRuIcqWidget Icq();

    /// <summary>
    ///   <para>Creates new Mail.ru "Like" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IMailRuLikeButtonWidget Like();

    /// <summary>
    ///   <para>Creates new Mail.ru embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IMailRuVideoWidget Video();

    /// <summary>
    ///   <para>Creates new Mail.ru video hyperlink widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IMailRuVideoLinkWidget VideoLink();
  }
}