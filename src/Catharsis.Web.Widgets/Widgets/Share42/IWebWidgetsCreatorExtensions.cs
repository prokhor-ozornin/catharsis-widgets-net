namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWebWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreator"/>
public static partial class IWebWidgetsCreatorExtensions
{
  private static IShare42WidgetsCreator Share42Property { get; set; }

  /// <summary>
  ///   <para>Initializes HTML helper object for rendering of Share42 widgets.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <returns>Widgets factory helper.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="creator"/> is a <c>null</c> reference.</exception>
  public static IShare42WidgetsCreator Share42(this IWebWidgetsCreator creator) => creator is not null ? Share42Property ??= new Share42WidgetsCreator() : throw new ArgumentNullException(nameof(creator));
}