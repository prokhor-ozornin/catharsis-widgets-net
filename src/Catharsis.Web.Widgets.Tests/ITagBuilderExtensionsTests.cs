using System.Globalization;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for interface <see cref="ITagBuilderExtensions"/>.</para>
/// </summary>
public sealed class ITagBuilderExtensionsTests
{
  private readonly ITagBuilder builder = new TagBuilder("tag");

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

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.AccessKey(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AccessKey_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.AccessKey(null, "key")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, "key" }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(string key, ITagBuilder builder)
    {
      builder.AccessKey(key).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("accesskey", key);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.ContentEditable(ITagBuilder, bool?)"/> method.</para>
  /// </summary>
  [Fact]
  public void ContentEditable_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.ContentEditable(null, true)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new bool?[] { null, false, true }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(bool? enabled, ITagBuilder builder)
    {
      builder.ContentEditable(enabled).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("contenteditable", enabled.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.ContextMenu(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ContextMenu_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.ContextMenu(null, "id")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, "id" }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(string id, ITagBuilder builder)
    {
      builder.ContextMenu(id).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("contextmenu", id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="ITagBuilderExtensions.TextDirection(ITagBuilder, string)"/></description></item>
  ///     <item><description><see cref="ITagBuilderExtensions.TextDirection(ITagBuilder, TextDirection)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void TextDirection_Methods()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.Hidden(ITagBuilder, bool?)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hidden_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.Hidden(null, true)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new bool?[] { null, false, true }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(bool? enabled, ITagBuilder builder)
    {
      builder.Hidden(enabled).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("hidden", enabled.GetValueOrDefault() ? "hidden" : null);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.Id(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.Id(null, "id")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, "id" }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(string id, ITagBuilder builder)
    {
      builder.Id(id).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("id", id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="ITagBuilderExtensions.Language(ITagBuilder, string)"/></description></item>
  ///     <item><description><see cref="ITagBuilderExtensions.Language(ITagBuilder, CultureInfo)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Language_Methods()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.Spellcheck(ITagBuilder, bool?)"/> method.</para>
  /// </summary>
  [Fact]
  public void Spellcheck_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.Spellcheck(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new bool?[] { null, false, true }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(bool? enabled, ITagBuilder builder)
    {
      builder.Spellcheck(enabled).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("spellcheck", enabled?.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.TabIndex(ITagBuilder, uint?)"/> method.</para>
  /// </summary>
  [Fact]
  public void TabIndex_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.TabIndex(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new uint?[] { null, uint.MinValue, uint.MaxValue }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(uint? index, ITagBuilder builder)
    {
      builder.TabIndex(index).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("tabindex", index?.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.Title(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.Title(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, "title" }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(string title, ITagBuilder builder)
    {
      builder.Title(title).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("title", title);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnBlur(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnBlur_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnBlur(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, "title" }.ForEach(value => Validate(value, builder));
    }

    return;

    static void Validate(string script, ITagBuilder builder)
    {
      builder.OnBlur(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onblur", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnChange(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnChange_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnClick(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnClick_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnDoubleClick(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnDoubleClick_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnFocus(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnFocus_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnKeyDown(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnKeyDown_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnKeyPress(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnKeyPress_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnKeyUp(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnKeyUp_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnLoad(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnLoad_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseDown(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseDown_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseMove(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseMove_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseOut(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseOut_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseOver(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseOver_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseUp(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseUp_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnReset(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnReset_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnSelect(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnSelect_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnSubmit(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnSubmit_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnUnload(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnUnload_Method()
  {
    throw new NotImplementedException();
  }
}