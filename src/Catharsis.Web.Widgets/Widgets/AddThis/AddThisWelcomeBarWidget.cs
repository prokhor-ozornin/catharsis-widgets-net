namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisWelcomeBarWidget"/>
public class AddThisWelcomeBarWidget : WebWidget, IAddThisWelcomeBarWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new AddThisWelcomeBarWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}