namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IInlineImageWidgetsCreator"/>
public class InlineImageWidgetsCreator : IInlineImageWidgetsCreator
{
  /// <inheritdoc cref="IInlineImageWidgetsCreator.InlineImage()"/>
  public virtual IInlineImageWidget InlineImage() => new InlineImageWidget();
}