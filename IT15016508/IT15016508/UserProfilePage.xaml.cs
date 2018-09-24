using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IT15016508.DATA;
using IT15016508.NET;

namespace IT15016508
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfilePage : ContentPage
	{
        private Post post;
        private User user;

		public UserProfilePage ()
		{
			InitializeComponent ();
		}

        public UserProfilePage(Post post): this()
        {
            this.post = post;
            GetUser();
            Title = this.user.id + "'s Profile";
            BindingContext = this.user;
        }

        private void GetUser() {
            this.user = APIConnection.GetUser(this.post.userid);
        }
    }
}