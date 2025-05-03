namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisTrendingContentWidget"/>
public class AddThisTrendingContentWidget : WebWidget, IAddThisTrendingContentWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new AddThisTrendingContentWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}