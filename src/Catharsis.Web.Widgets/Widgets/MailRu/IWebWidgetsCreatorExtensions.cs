namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWebWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreator"/>
public static partial class IWebWidgetsCreatorExtensions
{
  private static IMailRuWidgetsCreator mailru;

  /// <summary>
  ///   <para>Initializes HTML helper object for rendering of Mail.ru widgets.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <returns>Widgets factory helper.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
  public static IMailRuWidgetsCreator MailRu(this IWebWidgetsCreator html) => html is not null ? mailru ??= new MailRuWidgetsCreator() : throw new ArgumentNullException(nameof(html));
}