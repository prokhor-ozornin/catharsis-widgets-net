using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuHtmlHelper"/>.</para>
  /// </summary>
  public sealed class MailRuHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /*/// <summary>
    ///   <para>Performs testing of <see cref="MailRuHtmlHelper.Faces()"/> method.</para>
    /// </summary>
    [Fact]
    public void Faces_Method()
    {
      Assert.False(ReferenceEquals(this.html.MailRu().Faces(), this.html.MailRu().Faces()));
      Assert.True(this.html.MailRu().Faces() is MailRuFacesWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuHtmlHelper.Groups()"/> method.</para>
    /// </summary>
    [Fact]
    public void Groups_Method()
    {
      Assert.False(ReferenceEquals(this.html.MailRu().Groups(), this.html.MailRu().Groups()));
      Assert.True(this.html.MailRu().Groups() is MailRuGroupsWidget);
    }*/

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuHtmlHelper.Icq()"/> method.</para>
    /// </summary>
    [Fact]
    public void Icq_Method()
    {
      Assert.False(ReferenceEquals(this.html.MailRu().Icq(), this.html.MailRu().Icq()));
      Assert.True(this.html.MailRu().Icq() is MailRuIcqWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuHtmlHelper.Like()"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.False(ReferenceEquals(this.html.MailRu().Like(), this.html.MailRu().Like()));
      Assert.True(this.html.MailRu().Like() is MailRuLikeButtonWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuHtmlHelper.Video()"/> method.</para>
    /// </summary>
    [Fact]
    public void Video_Method()
    {
      Assert.False(ReferenceEquals(this.html.MailRu().Video(), this.html.MailRu().Video()));
      Assert.True(this.html.MailRu().Video() is MailRuVideoWidget);
    }
  }
}