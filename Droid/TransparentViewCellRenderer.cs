using System;
using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using xceler.customControls;
using xceler.Droid;

[assembly: ExportRenderer(typeof(TransparentViewCell), typeof(TransparentViewCellRenderer))]
namespace xceler.Droid
{
    public class TransparentViewCellRenderer : ViewCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context);

            var listView = parent as Android.Widget.ListView;

            if (listView != null)
            {
                cell.SetBackgroundColor(Android.Graphics.Color.ParseColor("#f2eaea"));
                // Disable native cell selection color style - set as *Transparent*
                listView.SetSelector(Android.Resource.Color.White);


                listView.CacheColorHint = Android.Graphics.Color.Transparent;
            }

            return cell;
        }







    }
}
