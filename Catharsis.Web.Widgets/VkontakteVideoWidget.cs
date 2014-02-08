using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class VkontakteVideoWidget : HtmlWidgetBase<IVkontakteVideoWidget>, IVkontakteVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private bool hd;
    private string user;
    private string hash;

    public IVkontakteVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IVkontakteVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IVkontakteVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IVkontakteVideoWidget HdQuality(bool hd = true)
    {
      this.hd = hd;
      return this;
    }

    public IVkontakteVideoWidget User(string user)
    {
      Assertion.NotEmpty(user);

      this.user = user;
      return this;
    }

    public IVkontakteVideoWidget Hash(string hash)
    {
      Assertion.NotEmpty(hash);

      this.hash = hash;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.user.IsEmpty() || this.hash.IsEmpty() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .Attribute("width", this.width)
        .Attribute("height", this.height)
        .Attribute("src", "http://vk.com/video_ext.php?oid={1}&id={0}&hash={2}&hd={3}".FormatValue(this.id, this.user, this.hash, this.hd ? 1 : 0))));
    }
  }
}