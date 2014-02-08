using System;
using System.IO;
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
    ///   <seealso cref="DisqusCommentsWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new DisqusCommentsWidget();
      Assert.True(widget.Field("account") == null);
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
      Assert.True(widget.Field("account") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="DisqusCommentsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new DisqusCommentsWidget().Write(null));

      Assert.True(new StringWriter().With(new DisqusCommentsWidget().Write).ToString().IsEmpty());
      new StringWriter().With(writer =>
      {
        new DisqusCommentsWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""disqus_thread""></div>"));
        Assert.True(html.Contains(@"var disqus_shortname = ""account"""));
      });
    }
  }
}