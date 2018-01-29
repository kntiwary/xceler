using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using xceler.customControls;
using xceler.iOS;

[assembly: ExportRenderer(typeof(TransparentViewCell), typeof(TransparentViewCellRenderer))]
namespace xceler.iOS
{
    public class TransparentViewCellRenderer : ViewCellRenderer
    {
        

        public override UIKit.UITableViewCell GetCell(Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            if (cell != null)
            {
                cell.SelectionStyle = UIKit.UITableViewCellSelectionStyle.None;
            }

            return base.GetCell(item, reusableCell, tv);

        }
    }
}
