using System;
using System.IO;
using System.Threading;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexAnalyticsWidget"/>.</para>
  /// </summary>
  public sealed class YandexAnalyticsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="YandexAnalyticsWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("account").To<string>() == null);
      Assert.True(widget.Field("webvisor").To<bool>());
      Assert.True(widget.Field("clickmap").To<bool>());
      Assert.True(widget.Field("tracklinks").To<bool>());
      Assert.True(widget.Field("trackhash").To<bool>());
      Assert.True(widget.Field("accurate").To<bool>());
      Assert.False(widget.Field("noindex").To<bool>());
      Assert.True(widget.Field("language").To<string>() == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexAnalyticsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new YandexAnalyticsWidget().Account(string.Empty));

      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("account") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
    }

    [Fact]
    public void WebVisor_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("webvisor").To<bool>());
      Assert.True(ReferenceEquals(widget.WebVisor(false), widget));
      Assert.False(widget.Field("webvisor").To<bool>());
    }

    [Fact]
    public void ClickMap_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("clickmap").To<bool>());
      Assert.True(ReferenceEquals(widget.ClickMap(false), widget));
      Assert.False(widget.Field("clickmap").To<bool>());
    }

    [Fact]
    public void TrackLinks_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("tracklinks").To<bool>());
      Assert.True(ReferenceEquals(widget.TrackLinks(false), widget));
      Assert.False(widget.Field("tracklinks").To<bool>());
    }

    [Fact]
    public void TrackHash_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("trackhash").To<bool>());
      Assert.True(ReferenceEquals(widget.TrackHash(false), widget));
      Assert.False(widget.Field("trackhash").To<bool>());
    }

    [Fact]
    public void Accurate_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("accurate").To<bool>());
      Assert.True(ReferenceEquals(widget.Accurate(false), widget));
      Assert.False(widget.Field("accurate").To<bool>());
    }

    [Fact]
    public void NoIndex_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.False(widget.Field("noindex").To<bool>());
      Assert.True(ReferenceEquals(widget.NoIndex(), widget));
      Assert.True(widget.Field("noindex").To<bool>());
    }

    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexAnalyticsWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new YandexAnalyticsWidget().Language(string.Empty));

      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("language") == null);
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.True(widget.Field("language").To<string>() == "language");
    }

    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexAnalyticsWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YandexAnalyticsWidget().Write(writer)).ToString().IsEmpty());
      new StringWriter().With(writer =>
      {
        new YandexAnalyticsWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains("Ya.Metrika.informer({{i: this, id: account, lang: '{0}'}})".FormatValue(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)));
        Assert.True(html.Contains("yaCounteraccount"));
        Assert.True(html.Contains(@"""webvisor"":true"));
        Assert.True(html.Contains(@"""clickmap"":true"));
        Assert.True(html.Contains(@"""trackLinks"":true"));
        Assert.True(html.Contains(@"""accurateTrackBounce"":true"));
        Assert.True(html.Contains(@"""trackHash"":true"));
        Assert.False(html.Contains(@"""ut"":""noindex"""));
      });
      new StringWriter().With(writer =>
      {
        new YandexAnalyticsWidget().Account("account").Language("language").WebVisor(false).ClickMap(false).TrackLinks(false).Accurate(false).TrackHash(false).NoIndex().Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains("Ya.Metrika.informer({i: this, id: account, lang: 'language'})"));
        Assert.True(html.Contains("yaCounteraccount"));
        Assert.True(html.Contains(@"""webvisor"":false"));
        Assert.True(html.Contains(@"""clickmap"":false"));
        Assert.True(html.Contains(@"""trackLinks"":false"));
        Assert.True(html.Contains(@"""accurateTrackBounce"":false"));
        Assert.True(html.Contains(@"""trackHash"":false"));
        Assert.True(html.Contains(@"""ut"":""noindex"""));
      });
    }
  }
}