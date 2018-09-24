using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT15016508.DATA;
using IT15016508.NET;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IT15016508
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CommentsPage : ContentPage
	{
		public CommentsPage ()
		{
			InitializeComponent ();
		}

        public CommentsPage(Post post)
        {
            InitializeComponent();
        }
    }
}