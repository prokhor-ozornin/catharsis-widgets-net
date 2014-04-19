﻿namespace Catharsis.Web.Widgets
{
  internal sealed class MockHtmlWidget : HtmlWidgetBase
  {
    public const string Contents = "Widget text content";

    public override string ToHtmlString()
    {
      return Contents;
    }
  }
}