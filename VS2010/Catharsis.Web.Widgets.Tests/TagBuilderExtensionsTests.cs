using System;
using System.Linq;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TagBuilderExtensions"/>.</para>
  /// </summary>
  public sealed class TagBuilderExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="TagBuilderExtensions.Attribute(TagBuilder, string, object)"/> method.</para>
    /// </summary>
    [Fact]
    public void Attribute_Method()
    {
      Assert.Throws<ArgumentNullException>(() => TagBuilderExtensions.Attribute(null, "name", new object()));
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
    ///   <para>Performs testing of <see cref="TagBuilderExtensions.Attributes(TagBuilder, object)"/> method.</para>
    /// </summary>
    [Fact]
    public void Attributes_Method()
    {
      Assert.Throws<ArgumentNullException>(() => TagBuilderExtensions.Attributes(null, new object()));
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
    ///   <para>Performs testing of <see cref="TagBuilderExtensions.CssClass(TagBuilder, string)"/> method.</para>
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
    ///   <para>Performs testing of <see cref="TagBuilderExtensions.CssStyle(TagBuilder, string)"/> method.</para>
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
    ///   <para>Performs testing of <see cref="TagBuilderExtensions.InnerHtml(TagBuilder, string)"/> method.</para>
    /// </summary>
    [Fact]
    public void InnerHtml_Method()
    {
      Assert.Throws<ArgumentNullException>(() => TagBuilderExtensions.InnerHtml(null, string.Empty));

      var builder = new TagBuilder("tag");
      Assert.True(ReferenceEquals(builder.InnerHtml(string.Empty), builder));
      Assert.Equal(string.Empty, builder.InnerHtml);
      Assert.Equal("html", builder.InnerHtml("html").InnerHtml);
    }
  }
}