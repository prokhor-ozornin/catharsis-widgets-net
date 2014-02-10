using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class DisqusCommentsWidget : HtmlWidgetBase<IDisqusCommentsWidget>, IDisqusCommentsWidget
  {
    private string account;

    public IDisqusCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      writer.Write(resources.disqus_comments.FormatValue(this.account));
    }
  }
}