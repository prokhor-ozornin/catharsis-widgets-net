using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public class IntenseDebateLinkWidget : HtmlWidget, IIntenseDebateLinkWidget
  {
    private string account;
    private string postId;
    private string postUrl;
    private string postTitle;

    public IIntenseDebateLinkWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IIntenseDebateLinkWidget PostId(string postId)
    {
      Assertion.NotEmpty(postId);

      this.postId = postId;
      return this;
    }

    public IIntenseDebateLinkWidget PostUrl(string postUrl)
    {
      Assertion.NotEmpty(postUrl);

      this.postUrl = postUrl;
      return this;
    }

    public IIntenseDebateLinkWidget PostTitle(string postTitle)
    {
      Assertion.NotEmpty(postTitle);

      this.postTitle = postTitle;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.account.IsEmpty())
      {
        return string.Empty;
      }

      return resources.intensedebate_link.FormatSelf(this.account, this.postId, this.postUrl, this.postTitle);
    }
  }
}