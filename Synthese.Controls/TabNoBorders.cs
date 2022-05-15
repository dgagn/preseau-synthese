using System.Runtime.InteropServices;

namespace Synthese.Controls;

public class TabNoBorders : TabControl
{
  protected override void WndProc(ref Message m)
  {
    if (m.Msg == 0x1328 && !DesignMode)
    {
      var rect = (Rect) m.GetLParam(typeof(Rect))!;
      rect.Left = Left - Margin.Left;
      rect.Right = Right + Margin.Right;

      rect.Top = Top - Margin.Top;
      rect.Bottom = Bottom + Margin.Bottom;
      Marshal.StructureToPtr(rect, m.LParam, true);
    }

    base.WndProc(ref m);
  }

  private struct Rect
  {
    public int Left, Top, Right, Bottom;
  }
}