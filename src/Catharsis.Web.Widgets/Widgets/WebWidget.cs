namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public abstract class WebWidget : IWebWidget
{
  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public abstract string ToHtml();

  /// <inheritdoc cref="object.ToString()"/>
  public override string ToString() => ToHtml();
}