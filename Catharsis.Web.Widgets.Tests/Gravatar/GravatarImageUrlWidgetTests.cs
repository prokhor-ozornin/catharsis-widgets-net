using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GravatarImageUrlWidget"/>.</para>
  /// </summary>
  public sealed class GravatarImageUrlWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="GravatarImageUrlWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new GravatarImageUrlWidget();
      Assert.Null(widget.Field("extension"));
      Assert.Null(widget.Field("hash"));
      Assert.False(widget.Field("parameters").To<IDictionary<string, object>>().Any());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Extension(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Extension_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Extension(null));
      Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Extension(string.Empty));

      var widget = new GravatarImageUrlWidget();
      Assert.Null(widget.Field("extension"));
      Assert.True(ReferenceEquals(widget.Extension("extension"), widget));
      Assert.Equal("extension", widget.Field("extension").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Hash(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Hash_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Hash(null));
      Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Hash(string.Empty));

      var widget = new GravatarImageUrlWidget();
      Assert.Null(widget.Field("hash"));
      Assert.True(ReferenceEquals(widget.Hash("hash"), widget));
      Assert.Equal("hash", widget.Field("hash").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Parameter(string, object)"/> method.</para>
    /// </summary>
    [Fact]
    public void Parameter_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Parameter(null, new object()));
      Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Parameter("name", null));
      Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Parameter(string.Empty, new object()));

      var widget = new GravatarImageUrlWidget();
      Assert.False(widget.Field("parameters").To<IDictionary<string, object>>().Any());
      Assert.True(ReferenceEquals(widget.Parameter("name", "value"), widget));
      var parameters = widget.Field("parameters").To<IDictionary<string, object>>();
      Assert.Equal(1, parameters.Count);
      Assert.Equal("value", parameters["name"]);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new GravatarImageUrlWidget().ToString());
      Assert.Equal("http://www.gravatar.com/avatar/hash", new GravatarImageUrlWidget().Hash("hash").ToString());
      Assert.Equal("http://www.gravatar.com/avatar/hash?name=value", new GravatarImageUrlWidget().Hash("hash").Parameter("name", "value").ToString());
      Assert.Equal("http://www.gravatar.com/avatar/hash.extension?first=1&second=2", new GravatarImageUrlWidget().Hash("hash").Extension("extension").Parameter("first", 1).Parameter("second", 2).ToString());
    }
  }
}