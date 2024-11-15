namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWebWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreator"/>
public static partial class IWebWidgetsCreatorExtensions
{
  private static IShare42WidgetCreator share42;

  /// <summary>
  ///   <para>Initializes HTML helper object for rendering of Share42 widgets.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <returns>Widgets factory helper.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="creator"/> is a <c>null</c> reference.</exception>
  public static IShare42WidgetCreator Share42(this IWebWidgetsCreator creator) => creator is not null ? share42 ??= new Share42WidgetCreator() : throw new ArgumentNullException(nameof(creator));
}