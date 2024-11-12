using System.Web;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IDictionary{TKey, TValue}"/>.</para>
/// </summary>
/// <seealso cref="IDictionary{TKey, TValue}"/>
public static class IDictionaryExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="dictionary"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="dictionary"/> is a <c>null</c> reference.</exception>
  public static string ToUrlQuery(this IDictionary<string, object> dictionary) => dictionary is not null ? dictionary.Select(pair => "{0}={1}".FormatSelf(HttpUtility.UrlEncode(pair.Key), HttpUtility.UrlEncode(pair.Value is bool ? pair.Value.ToString().ToLowerInvariant() : pair.Value.ToString()))).Join("&") : throw new ArgumentNullException(nameof(dictionary));
}