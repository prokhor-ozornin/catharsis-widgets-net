using Catharsis.Commons;
using Catharsis.Web.Widgets.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Web.Widgets.Extensions.ObjectExtensions"/>.</para>
/// </summary>
public sealed class ObjectExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="Web.Widgets.Extensions.ObjectExtensions.Json(object)"/> method.</para>
  /// </summary>
  [Fact]
  public void Json_Method()
  {
    AssertionExtensions.Should(() => ((object) null).Json()).ThrowExactly<ArgumentNullException>().WithParameterName("subject");

    throw new NotImplementedException();
  }
}