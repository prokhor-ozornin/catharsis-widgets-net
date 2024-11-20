using Catharsis.Commons;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="GravatarImageUrlWidget"/>.</para>
/// </summary>
public sealed class GravatarImageUrlWidgetTests : ClassTest<GravatarImageUrlWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GravatarImageUrlWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GravatarImageUrlWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGravatarImageUrlWidget>();
  
    var widget = new GravatarImageUrlWidget();
    Assert.Null(widget.Extension().Should().BeNull());
    Assert.Null(widget.Hash().Should().BeNull());
    widget.GetFieldValue<IDictionary<string, object>>("parameters").Should().BeEmpty();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Extension(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Extension_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Extension(null));
    Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Extension(string.Empty));

    using (new AssertionScope())
    {
      var widget = new GravatarImageUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string extension, IGravatarImageUrlWidget widget)
    {
      widget.Extension(extension).Should().BeSameAs(widget);
      widget.Extension().Should().Be(extension);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Hash(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hash_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Hash(null));
    Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Hash(string.Empty));

    using (new AssertionScope())
    {
      var widget = new GravatarImageUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string hash, IGravatarImageUrlWidget widget)
    {
      widget.Hash(hash).Should().BeSameAs(widget);
      widget.Hash().Should().Be(hash);
    }
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
    Assert.False(widget.GetFieldValue<IDictionary<string, object>>("parameters").Any());
    Assert.True(ReferenceEquals(widget.Parameter("name", "value"), widget));
    var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
    Assert.Equal(1, parameters.Count);
    Assert.Equal("value", parameters["name"]);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new GravatarImageUrlWidget().ToString());
    Assert.Equal("http://www.gravatar.com/avatar/hash", new GravatarImageUrlWidget().Hash("hash").ToString());
    Assert.Equal("http://www.gravatar.com/avatar/hash?name=value", new GravatarImageUrlWidget().Hash("hash").Parameter("name", "value").ToString());
    Assert.Equal("http://www.gravatar.com/avatar/hash.extension?first=1&second=2", new GravatarImageUrlWidget().Hash("hash").Extension("extension").Parameter("first", 1).Parameter("second", 2).ToString());
  }
}