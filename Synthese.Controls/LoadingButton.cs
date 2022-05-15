using Synthese.Controls.Properties;

namespace Synthese.Controls;

public sealed class LoadingButton : Button
{
  private string _text = "";

  public LoadingButton()
  {
    Cursor = Cursors.Hand;
    FlatStyle = FlatStyle.Flat;
    ImageAlign = ContentAlignment.MiddleRight;
    TextAlign = ContentAlignment.MiddleLeft;
    UseVisualStyleBackColor = true;
    FlatAppearance.BorderColor = Color.FromArgb(244, 114, 182);
    ForeColor = Color.FromArgb(131, 24, 67);
    BackColor = Color.FromArgb(252, 231, 243);
  }

  public void Loading()
  {
    Invoke(() =>
    {
      _text = Text;
      Text = "En cours";
      Image = Resources.progress_icon_gif_8_16x16;
    });
  }

  public void Reset()
  {
    Invoke(() =>
    {
      Text = _text;
      Image = null;
      Enabled = true;
    });
  }
}