using Catharsis.Extensions;
 
namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IMailRuGroupsWidget"/>.</para>
/// </summary>
/// <seealso cref="IMailRuGroupsWidget"/>
public static class IMailRuGroupsWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IMailRuGroupsWidget widget)
  {
    /// <summary>
    ///   <para>Height of Groups box area.</para>
    /// </summary>
    /// <param name="height">Area height.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuGroupsWidget.Height(string)"/>
    public IMailRuGroupsWidget Height(short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Width of Groups box area.</para>
    /// </summary>
    /// <param name="width">Area width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuGroupsWidget.Width(string)"/>
    public IMailRuGroupsWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}