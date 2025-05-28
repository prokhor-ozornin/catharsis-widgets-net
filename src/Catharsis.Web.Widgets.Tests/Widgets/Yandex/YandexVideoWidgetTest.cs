using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexVideoWidget"/>.</para>
/// </summary>
public sealed class YandexVideoWidgetTest : Test
{
  private IYandexVideoWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YandexVideoWidgetTest() => Widget = Fixture<IYandexVideoWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YandexVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YandexVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYandexVideoWidget>();

    using (new AssertionScope())
    {
      var widget = new YandexVideoWidget();
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<string>("UserValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexVideoWidget.User(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void User_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexVideoWidget().User(null)).ThrowExactly<ArgumentNullException>().WithParameterName("user");
      AssertionExtensions.Should(() => new YandexVideoWidget().User(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("user");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string user, IYandexVideoWidget widget) => widget.User(user).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UserValue").Should().Be(user);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexVideoWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new YandexVideoWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IYandexVideoWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexVideoWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new YandexVideoWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IYandexVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YandexVideoWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new YandexVideoWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IYandexVideoWidget widget) => widget.Height(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexVideoWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new YandexVideoWidget());
      Test(Fixture<YandexVideoWidget>.Create());
    }

    return;

    static void Test(IYandexVideoWidget original)
    {
      var clone = original.Clone<IYandexVideoWidget>();

      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("UserValue").Should().Be(original.GetPropertyValue<string>("UserValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new YandexVideoWidget());
      Test(new YandexVideoWidget().Id("id").User("user").Width("width"));
      Test(new YandexVideoWidget().Id("id").User("user").Height("height"));
      Test(new YandexVideoWidget().Id("id").Width("width").Height("height"));
      Test(new YandexVideoWidget().User("user").Width("width").Height("height"));
      Test(new YandexVideoWidget().Id("id").Height("height").Width("width").User("user"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://video.yandex.ru/iframe/user/id" webkitallowfullscreen="true" width="width"></iframe>""");
      Test(Fixture<YandexVideoWidget>.Create());
    }

    return;

    static void Test(IYandexVideoWidget widget, params string[] html)
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