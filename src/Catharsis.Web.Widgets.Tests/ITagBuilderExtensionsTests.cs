using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for interface <see cref="ITagBuilderExtensions"/>.</para>
/// </summary>
public sealed class ITagBuilderExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.Attribute(ITagBuilder, string, object)"/> method.</para>
  /// </summary>
  [Fact]
  public void Attribute_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ITagBuilderExtensions.Attribute(null, "name", new object()));
    Assert.Throws<ArgumentNullException>(() => new TagBuilder("tag").Attribute(null, new object()));
    Assert.Throws<ArgumentException>(() => new TagBuilder("tag").Attribute(string.Empty, new object()));

    var builder = new TagBuilder("tag");
    Assert.False(builder.Attributes.Any());
    Assert.True(ReferenceEquals(builder.Attribute("attribute", null), builder));
    Assert.False(builder.Attributes.Any());
      
    var attribute = new object();
    builder.Attribute("attribute", attribute);
    Assert.Equal(1, builder.Attributes.Count);
    Assert.Equal("attribute", builder.Attributes.Single().Key);
    Assert.Equal(attribute.ToString(), builder.Attributes.Single().Value);
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="ITagBuilderExtensions.Attributes(ITagBuilder, IEnumerable{ValueTuple{string, object}})"/></description></item>
  ///     <item><description><see cref="ITagBuilderExtensions.Attributes(ITagBuilder, object)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Attributes_Methods()
  {
    Assert.Throws<ArgumentNullException>(() => ITagBuilderExtensions.Attributes(null, new object()));
    Assert.Throws<ArgumentNullException>(() => new TagBuilder("tag").Attributes(null));

    var builder = new TagBuilder("tag");
    Assert.False(builder.Attributes.Any());
    Assert.True(ReferenceEquals(builder.Attributes(new object()), builder));
    Assert.False(builder.Attributes.Any());
      
    var attributes = new { First = "first", Second = "second" };
    builder.Attributes(attributes);
    Assert.Equal(2, builder.Attributes.Count);
    Assert.Equal("First", builder.Attributes.First().Key);
    Assert.Equal("first", builder.Attributes.First().Value);
    Assert.Equal("Second", builder.Attributes.Last().Key);
    Assert.Equal("second", builder.Attributes.Last().Value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.CssClass(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CssClass_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TagBuilder("tag").CssClass(null));
    Assert.Throws<ArgumentException>(() => new TagBuilder("tag").CssClass(string.Empty));

    var attributes = new TagBuilder("tag").CssClass("cssClass").Attributes;
    Assert.Equal(1, attributes.Count);
    Assert.Equal("class", attributes.Single().Key);
    Assert.Equal("cssClass", attributes.Single().Value);
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="ITagBuilderExtensions.CssClasses(ITagBuilder, IEnumerable{string})"/></description></item>
  ///     <item><description><see cref="ITagBuilderExtensions.CssClasses(ITagBuilder, string[])"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void CssClasses_Methods()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.CssStyle(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CssStyle_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TagBuilder("tag").CssStyle(null));
    Assert.Throws<ArgumentException>(() => new TagBuilder("tag").CssStyle(string.Empty));

    var attributes = new TagBuilder("tag").CssStyle("cssStyle").Attributes;
    Assert.Equal(1, attributes.Count);
    Assert.Equal("style", attributes.Single().Key);
    Assert.Equal("cssStyle", attributes.Single().Value);
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="ITagBuilderExtensions.CssStyles(ITagBuilder, IEnumerable{ValueTuple{string, string}})"/></description></item>
  ///     <item><description><see cref="ITagBuilderExtensions.CssStyles(ITagBuilder, IEnumerable{ValueTuple{string, object}})"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void CssStyles_Methods()
  {
    Assert.Throws<ArgumentNullException>(() => new TagBuilder("tag").CssStyle(null));
    Assert.Throws<ArgumentException>(() => new TagBuilder("tag").CssStyle(string.Empty));

    var attributes = new TagBuilder("tag").CssStyle("cssStyle").Attributes;
    Assert.Equal(1, attributes.Count);
    Assert.Equal("style", attributes.Single().Key);
    Assert.Equal("cssStyle", attributes.Single().Value);
  }
}