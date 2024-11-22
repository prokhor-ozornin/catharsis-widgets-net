namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWebWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreator"/>
public static partial class IWebWidgetsCreatorExtensions
{
  private static IYandexWidgetsCreator yandex;

  /// <summary>
  ///   <para>Initializes HTML helper object for rendering of Yandex widgets.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <returns>Widgets factory helper.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="creator"/> is a <c>null</c> reference.</exception>
  public static IYandexWidgetsCreator Yandex(this IWebWidgetsCreator creator) => creator is not null ? yandex ??= new YandexWidgetsCreator() : throw new ArgumentNullException(nameof(creator));
}