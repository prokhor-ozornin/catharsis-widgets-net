using Catharsis.Web.Widgets.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ObjectExtensions"/>.</para>
/// </summary>
/// <seealso cref="ObjectExtensions"/>
public sealed class ObjectExtensionsTest : Test
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ObjectExtensions.Json(object)"/> method.</para>
  /// </summary>
  [Fact]
  public void Json_Method()
  {
    AssertionExtensions.Should(() => ((object) null).Json()).ThrowExactly<ArgumentNullException>().WithParameterName("subject");

    throw new NotImplementedException();
  }
}