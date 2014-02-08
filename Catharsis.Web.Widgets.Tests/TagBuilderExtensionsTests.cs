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
      Assert.True(builder.Attributes.Count == 1);
      Assert.True(builder.Attributes.Single().Key == "attribute");
      Assert.True(builder.Attributes.Single().Value == attribute.ToString());
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
      Assert.True(builder.Attributes.Count == 2);
      Assert.True(builder.Attributes.First().Key == "First");
      Assert.True(builder.Attributes.First().Value == "first");
      Assert.True(builder.Attributes.Last().Key == "Second");
      Assert.True(builder.Attributes.Last().Value == "second");
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
      Assert.True(builder.InnerHtml == string.Empty);
      Assert.True(builder.InnerHtml("html").InnerHtml == "html");
    }
  }
}