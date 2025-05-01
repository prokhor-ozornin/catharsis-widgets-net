namespace Catharsis.Web.Widgets.Tests;

internal sealed class MockVideoWidget : WebWidget, IVideoWidget<MockVideoWidget>
{
  public MockVideoWidget Id(string id) => this;

  public string Id() => string.Empty;

  public MockVideoWidget Width(string width) => this;

  public string Width() => string.Empty;

  public MockVideoWidget Height(string height) => this;

  public string Height() => string.Empty;

  public override string ToHtml() => string.Empty;

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MockVideoWidget();
}