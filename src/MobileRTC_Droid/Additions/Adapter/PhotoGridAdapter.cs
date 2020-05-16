using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Zipow.Videobox.Photopicker
{
    public partial class PhotoGridAdapter
    {
		public override unsafe void OnBindViewHolder(global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder holder, int position)
		{
			OnBindViewHolder((Com.Zipow.Videobox.Photopicker.PhotoGridAdapter.PhotoViewHolder)holder, position);
		}		
	}
}