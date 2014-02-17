using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GoogleAnalyticsWidget"/>.</para>
  /// </summary>
  public sealed class GoogleAnalyticsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="GoogleAnalyticsWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new GoogleAnalyticsWidget();
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("domain"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GoogleAnalyticsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GoogleAnalyticsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new GoogleAnalyticsWidget().Account(string.Empty));

      var widget = new GoogleAnalyticsWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GoogleAnalyticsWidget.Domain(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Domain_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GoogleAnalyticsWidget().Domain(null));
      Assert.Throws<ArgumentException>(() => new GoogleAnalyticsWidget().Domain(string.Empty));

      var widget = new GoogleAnalyticsWidget();
      Assert.Null(widget.Field("domain"));
      Assert.True(ReferenceEquals(widget.Domain("domain"), widget));
      Assert.Equal("domain", widget.Field("domain").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GoogleAnalyticsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GoogleAnalyticsWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new GoogleAnalyticsWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new GoogleAnalyticsWidget().Account("account").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new GoogleAnalyticsWidget().Domain("domain").Write(writer)).ToString().IsEmpty());
      new StringWriter().With(writer =>
      {
        new GoogleAnalyticsWidget().Account("account").Domain("domain").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains("//www.google-analytics.com/analytics.js"));
        Assert.True(html.Contains(@"ga(""create"", ""account"", ""domain"");"));
      });
    }
  }
}