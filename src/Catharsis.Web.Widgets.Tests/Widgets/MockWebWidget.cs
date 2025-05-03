namespace Catharsis.Web.Widgets.Tests;

internal sealed class MockWebWidget : WebWidget
{
  public override string ToHtml() => "Widget text content";

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MockWebWidget();
}