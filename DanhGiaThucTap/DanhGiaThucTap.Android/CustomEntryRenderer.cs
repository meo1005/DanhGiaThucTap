using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DanhGiaThucTap.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DanhGiaThucTap.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace DanhGiaThucTap.Droid
{
    [Obsolete]
    class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawable);
            }
        }
    }
}