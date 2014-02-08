using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IInlineImageWidget"/>.</para>
  ///   <seealso cref="IInlineImageWidget"/>
  /// </summary>
  public static class IInlineImageExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IInlineImageWidget Jpg(this IInlineImageWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Format("jpg");
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IInlineImageWidget Png(this IInlineImageWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Format("png");
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IInlineImageWidget Gif(this IInlineImageWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Format("gif");
    }
  }
}