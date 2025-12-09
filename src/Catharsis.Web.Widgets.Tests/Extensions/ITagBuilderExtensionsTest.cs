using System.Globalization;
using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for interface <see cref="ITagBuilderExtensions"/>.</para>
/// </summary>
/// <seealso cref="ITagBuilderExtensions"/>
public sealed class ITagBuilderExtensionsTest : Test
{
  private ITagBuilder Builder { get; } = new TagBuilder("tag");

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.Attribute(ITagBuilder, string, object)"/> method.</para>
  /// </summary>
  [Fact]
  public void Attribute_Method()
  {
    throw new NotImplementedException();
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
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.CssClass(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CssClass_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.CssClass(null, "class")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(cssClass => Test(cssClass, Builder));
    }

    return;

    static void Test(string cssClass, ITagBuilder builder)
    {
      builder.CssClass(cssClass).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("class", cssClass);
    }
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.CssStyle(null, "style")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(style => Test(style, Builder));
    }

    return;

    static void Test(string style, ITagBuilder builder)
    {
      builder.CssStyle(style).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("style", style);
    }
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.CssStyles(null, Enumerable.Empty<(string, string)>())).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      static void Test(IEnumerable<(string Name, string Value)> styles, ITagBuilder builder)
      {
        throw new NotImplementedException();
      }
    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.CssStyles(null, Enumerable.Empty<(string, object)>())).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      static void Test(IEnumerable<(string Name, object Value)> styles, ITagBuilder builder)
      {
        throw new NotImplementedException();
      }
    }
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

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(key => Test(key, Builder));
    }

    return;

    static void Test(string key, ITagBuilder builder)
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

      new bool?[] { null, false, true }.ForEach(enabled => Test(enabled, Builder));
    }

    return;

    static void Test(bool? enabled, ITagBuilder builder)
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

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(id => Test(id, Builder));
    }

    return;

    static void Test(string id, ITagBuilder builder)
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

      new bool?[] { null, false, true }.ForEach(enabled => Test(enabled, Builder));
    }

    return;

    static void Test(bool? enabled, ITagBuilder builder)
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

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(id => Test(id, Builder));
    }

    return;

    static void Test(string id, ITagBuilder builder)
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
      AssertionExtensions.Should(() => ITagBuilderExtensions.Spellcheck(null, true)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new bool?[] { null, false, true }.ForEach(enabled => Test(enabled, Builder));
    }

    return;

    static void Test(bool? enabled, ITagBuilder builder)
    {
      builder.Spellcheck(enabled).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("spellcheck", enabled?.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.TabIndex(ITagBuilder, int?)"/> method.</para>
  /// </summary>
  [Fact]
  public void TabIndex_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.TabIndex(null, int.MaxValue)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new int?[] { null, int.MinValue, int.MaxValue, Fixture<int>.Create() }.ForEach(index => Test(index, Builder));
    }

    return;

    static void Test(int? index, ITagBuilder builder)
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
      AssertionExtensions.Should(() => ITagBuilderExtensions.Title(null, "title")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(title => Test(title, Builder));
    }

    return;

    static void Test(string title, ITagBuilder builder)
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
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnBlur(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnChange(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnChange(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onchange", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnClick(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnClick_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnClick(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnClick(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onclick", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnDoubleClick(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnDoubleClick_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnDoubleClick(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnDoubleClick(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("ondblclick", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnFocus(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnFocus_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnFocus(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnFocus(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onfocus", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnKeyDown(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnKeyDown_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnKeyDown(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnKeyDown(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onkeydown", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnKeyPress(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnKeyPress_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnKeyPress(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnKeyPress(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onkeypress", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnKeyUp(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnKeyUp_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnKeyUp(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnKeyUp(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onkeyup", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnLoad(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnLoad_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnLoad(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnLoad(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onload", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseDown(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseDown_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnMouseDown(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnMouseDown(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onmousedown", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseMove(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseMove_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnMouseMove(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnMouseMove(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onmousemove", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseOut(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseOut_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnMouseOut(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnMouseOut(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onmouseout", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseOver(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseOver_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnMouseOver(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnMouseOver(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onmouseover", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnMouseUp(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnMouseUp_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnMouseUp(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnMouseUp(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onmouseup", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnReset(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnReset_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnReset(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnReset(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onreset", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnSelect(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnSelect_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnSelect(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnSelect(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onselect", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnSubmit(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnSubmit_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnSubmit(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnSubmit(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onsubmit", script);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITagBuilderExtensions.OnUnload(ITagBuilder, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnUnload_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITagBuilderExtensions.OnUnload(null, "script")).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

      new[] { null, string.Empty, Fixture<string>.Create() }.ForEach(script => Test(script, Builder));
    }

    return;

    static void Test(string script, ITagBuilder builder)
    {
      builder.OnUnload(script).Should().BeSameAs(builder);
      builder.Attributes().Should().Contain("onunload", script);
    }
  }
}