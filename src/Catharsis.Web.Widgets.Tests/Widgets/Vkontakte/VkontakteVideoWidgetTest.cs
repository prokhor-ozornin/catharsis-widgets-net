using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteVideoWidget"/>.</para>
/// </summary>
/// <seealso cref="VkontakteVideoWidget"/>
public sealed class VkontakteVideoWidgetTest : Test
{
  private IVkontakteVideoWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteVideoWidgetTest() => Widget = Fixture<IVkontakteVideoWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteVideoWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteVideoWidget();
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<bool>("HdValue").Should().BeFalse();
      widget.GetPropertyValue<string>("UserValue").Should().BeNull();
      widget.GetPropertyValue<string>("HashValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IVkontakteVideoWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(string width, IVkontakteVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(height => Test(height, Widget));
    }

    return;

    static void Test(string height, IVkontakteVideoWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Hd(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hd_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(hd => Test(hd, Widget));
    }

    return;

    static void Test(bool hd, IVkontakteVideoWidget widget) => widget.Hd(hd).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("HdValue").Should().Be(hd);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.User(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void User_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteVideoWidget().User(null)).ThrowExactly<ArgumentNullException>().WithParameterName("user");
      AssertionExtensions.Should(() => new VkontakteVideoWidget().User(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("user");

      new[] { Fixture<string>.Create() }.ForEach(user => Test(user, Widget));
    }

    return;

    static void Test(string user, IVkontakteVideoWidget widget) => widget.User(user).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UserValue").Should().Be(user);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Hash(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hash_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Hash(null)).ThrowExactly<ArgumentNullException>().WithParameterName("hash");
      AssertionExtensions.Should(() => new VkontakteVideoWidget().Hash(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("hash");

      new[] { Fixture<string>.Create() }.ForEach(hash => Test(hash, Widget));
    }

    return;

    static void Test(string hash, IVkontakteVideoWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashValue").Should().Be(hash);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteVideoWidget());
      Test(Fixture<VkontakteVideoWidget>.Create());
    }

    return;

    static void Test(IVkontakteVideoWidget original)
    {
      var clone = original.Clone<IVkontakteVideoWidget>();

      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<bool>("HdValue").Should().Be(original.GetPropertyValue<bool>("HdValue"));
      clone.GetPropertyValue<string>("UserValue").Should().Be(original.GetPropertyValue<string>("UserValue"));
      clone.GetPropertyValue<string>("HashValue").Should().Be(original.GetPropertyValue<string>("HashValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteVideoWidget());
      Test(new VkontakteVideoWidget().User("oid").Hash("hash").Width("width").Height("height"));
      Test(new VkontakteVideoWidget().Id("id").Hash("hash").Width("width").Height("height"));
      Test(new VkontakteVideoWidget().Id("id").User("user").Width("width").Height("height"));
      Test(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Height("height"));
      Test(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width"));
      Test(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=0" webkitallowfullscreen="true" width="width"></iframe>""");
      Test(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height").Hd(true), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=1" webkitallowfullscreen="true" width="width"></iframe>""");
      Test(Fixture<VkontakteVideoWidget>.Create());
    }

    return;

    static void Test(IVkontakteVideoWidget widget, params string[] html)
    {
      if (html.IsUnset())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}