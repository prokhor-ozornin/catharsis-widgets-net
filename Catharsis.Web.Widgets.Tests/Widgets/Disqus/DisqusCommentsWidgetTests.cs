using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="DisqusCommentsWidget"/>.</para>
  /// </summary>
  public sealed class DisqusCommentsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="DisqusCommentsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new DisqusCommentsWidget();
      Assert.Null(widget.Field("account"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="DisqusCommentsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new DisqusCommentsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new DisqusCommentsWidget().Account(string.Empty));

      var widget = new DisqusCommentsWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="DisqusCommentsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new DisqusCommentsWidget().ToString());

      var html = new DisqusCommentsWidget().Account("account").ToString();
      Assert.True(html.Contains(@"<div id=""disqus_thread""></div>"));
      Assert.True(html.Contains(@"var disqus_shortname = ""account"""));
    }
  }
}