using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteVideoWidget"/>.</para>
/// </summary>
public sealed class VkontakteVideoWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("IdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<bool>("HdProperty").Should().BeFalse();
      widget.GetPropertyValue<string>("UserProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HashProperty").Should().BeNull();
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

      new VkontakteVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IVkontakteVideoWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdProperty").Should().Be(id);
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

      new VkontakteVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IVkontakteVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
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

      new VkontakteVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IVkontakteVideoWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Hd(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hd_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteVideoWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool hd, IVkontakteVideoWidget widget) => widget.Hd(hd).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("HdProperty").Should().Be(hd);
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

      new VkontakteVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string user, IVkontakteVideoWidget widget) => widget.User(user).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UserProperty").Should().Be(user);
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

      new VkontakteVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string hash, IVkontakteVideoWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashProperty").Should().Be(hash);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteVideoWidget());
      Validate(new VkontakteVideoWidget().User("oid").Hash("hash").Width("width").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").Hash("hash").Width("width").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Width("width").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=0" webkitallowfullscreen="true" width="width"></iframe>""");
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height").Hd(true), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=1" webkitallowfullscreen="true" width="width"></iframe>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
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