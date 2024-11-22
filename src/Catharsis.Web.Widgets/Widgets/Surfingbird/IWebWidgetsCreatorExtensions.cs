namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWebWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreator"/>
public static partial class IWebWidgetsCreatorExtensions
{
  private static ISurfingbirdWidgetsCreator surfingbird;

  /// <summary>
  ///   <para>Initializes HTML helper object for rendering of Surfingbird widgets.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <returns>Widgets factory helper.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="creator"/> is a <c>null</c> reference.</exception>
  public static ISurfingbirdWidgetsCreator Surfingbird(this IWebWidgetsCreator creator) => creator is not null ? surfingbird ??= new SurfingbirdWidgetsCreator() : throw new ArgumentNullException(nameof(creator));
}