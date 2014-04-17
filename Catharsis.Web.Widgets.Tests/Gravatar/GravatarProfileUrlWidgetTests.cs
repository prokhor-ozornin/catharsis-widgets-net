using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GravatarProfileUrlWidget"/>.</para>
  /// </summary>
  public sealed class GravatarProfileUrlWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="GravatarProfileUrlWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new GravatarProfileUrlWidget();
      Assert.Null(widget.Field("hash"));
      Assert.Null(widget.Field("format"));
      Assert.False(widget.Field("parameters").To<IDictionary<string, object>>().Any());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Hash(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Hash_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GravatarProfileUrlWidget().Hash(null));
      Assert.Throws<ArgumentException>(() => new GravatarProfileUrlWidget().Hash(string.Empty));

      var widget = new GravatarProfileUrlWidget();
      Assert.Null(widget.Field("hash"));
      Assert.True(ReferenceEquals(widget.Hash("hash"), widget));
      Assert.Equal("hash", widget.Field("hash").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Format(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Format_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GravatarProfileUrlWidget().Format(null));
      Assert.Throws<ArgumentException>(() => new GravatarProfileUrlWidget().Format(string.Empty));

      var widget = new GravatarProfileUrlWidget();
      Assert.Null(widget.Field("format"));
      Assert.True(ReferenceEquals(widget.Format("format"), widget));
      Assert.Equal("format", widget.Field("format").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Parameter(string, object)"/> method.</para>
    /// </summary>
    [Fact]
    public void Parameter_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GravatarProfileUrlWidget().Parameter(null, new object()));
      Assert.Throws<ArgumentNullException>(() => new GravatarProfileUrlWidget().Parameter("name", null));
      Assert.Throws<ArgumentException>(() => new GravatarProfileUrlWidget().Parameter(string.Empty, new object()));

      var widget = new GravatarProfileUrlWidget();
      Assert.False(widget.Field("parameters").To<IDictionary<string, object>>().Any());
      Assert.True(ReferenceEquals(widget.Parameter("name", "value"), widget));
      var parameters = widget.Field("parameters").To<IDictionary<string, object>>();
      Assert.Equal(1, parameters.Count);
      Assert.Equal("value", parameters["name"]);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new GravatarProfileUrlWidget().ToString());
      Assert.Equal("http://www.gravatar.com/hash", new GravatarProfileUrlWidget().Hash("hash").ToString());
      Assert.Equal("http://www.gravatar.com/hash?name=value", new GravatarProfileUrlWidget().Hash("hash").Parameter("name", "value").ToString());
      Assert.Equal("http://www.gravatar.com/hash.format?first=1&second=2", new GravatarProfileUrlWidget().Hash("hash").Format("format").Parameter("first", 1).Parameter("second", 2).ToString());
    }
  }
}