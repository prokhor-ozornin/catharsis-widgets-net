namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWebWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreator"/>
public static partial class IWebWidgetsCreatorExtensions
{
  private static IFacebookWidgetsCreator facebook;

  /// <summary>
  ///   <para>Initializes HTML helper object for rendering of Facebook widgets.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <returns>Widgets factory helper.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="creator"/> is a <c>null</c> reference.</exception>
  public static IFacebookWidgetsCreator Facebook(this IWebWidgetsCreator creator) => creator is not null ? facebook ??= new FacebookWidgetsCreator() : throw new ArgumentNullException(nameof(creator));
}