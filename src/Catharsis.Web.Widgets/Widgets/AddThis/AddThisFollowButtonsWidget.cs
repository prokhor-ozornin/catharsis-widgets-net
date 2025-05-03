namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisFollowButtonsWidget"/>
public class AddThisFollowButtonsWidget : WebWidget, IAddThisFollowButtonsWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new AddThisFollowButtonsWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}