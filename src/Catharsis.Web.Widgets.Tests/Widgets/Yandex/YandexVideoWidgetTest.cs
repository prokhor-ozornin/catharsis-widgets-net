using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YandexVideoWidget"/>.</para>
/// </summary>
public sealed class YandexVideoWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("IdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<string>("UserProperty").Should().BeNull();
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

      new YandexVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string user, IYandexVideoWidget widget) => widget.User(user).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UserProperty").Should().Be(user);
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

      new YandexVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IYandexVideoWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdProperty").Should().Be(id);
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

      new YandexVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IYandexVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
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

      new YandexVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IYandexVideoWidget widget) => widget.Height(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YandexVideoWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YandexVideoWidget());
      Validate(Attributes.YandexVideoWidget());
    }

    return;

    static void Validate(IYandexVideoWidget original)
    {
      var clone = original.Clone<IYandexVideoWidget>();

      clone.Id.Should().Be(original.Id);
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
      Validate(new YandexVideoWidget());
      Validate(new YandexVideoWidget().Id("id").User("user").Width("width"));
      Validate(new YandexVideoWidget().Id("id").User("user").Height("height"));
      Validate(new YandexVideoWidget().Id("id").Width("width").Height("height"));
      Validate(new YandexVideoWidget().User("user").Width("width").Height("height"));
      Validate(new YandexVideoWidget().Id("id").Height("height").Width("width").User("user"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://video.yandex.ru/iframe/user/id" webkitallowfullscreen="true" width="width"></iframe>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
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