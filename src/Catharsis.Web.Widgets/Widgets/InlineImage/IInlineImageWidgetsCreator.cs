namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Helper factory class for managing inlime image widgets.</para>
/// </summary>
public interface IInlineImageWidgetsCreator
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IInlineImageWidget InlineImage();
}