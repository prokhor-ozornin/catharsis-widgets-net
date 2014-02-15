using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CackleCommentsCountWidget"/>.</para>
  /// </summary>
  public sealed class CackleCommentsCountWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="CackleCommentsCountWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new CackleCommentsCountWidget();
      Assert.Null(widget.Field("account"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleCommentsCountWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new CackleCommentsCountWidget().Account(string.Empty));

      var widget = new CackleCommentsCountWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new CackleCommentsCountWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new CackleCommentsCountWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new CackleCommentsCountWidget().Account("account").Write(writer)).ToString().Contains(@"{""widget"":""CommentCount"",""id"":""account""}"));
    }
  }
}