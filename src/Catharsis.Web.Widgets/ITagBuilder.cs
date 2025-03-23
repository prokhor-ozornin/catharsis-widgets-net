namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface ITagBuilder
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  ITagBuilder Name(string name);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="html"></param>
  /// <returns></returns>
  ITagBuilder Html(string html);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  ITagBuilder Attribute(string name, string value);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IReadOnlyDictionary<string, string> Attributes();
}