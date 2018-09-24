using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Post post;
        private ObservableCollection<Comment> comments;

        public CommentsPage ()
		{
			InitializeComponent ();
		}

        public CommentsPage(Post post) : this()
        {
            Title = "Comments";
            this.post = post;
            BindingContext = this.post;
            this.comments = new ObservableCollection<Comment>();
            CommentsListView.ItemsSource = comments;
            CommentsListView.ItemSelected += CommentsListView_ItemSelected;
            GetComments();
        }

        private void CommentsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Comment comment = e.SelectedItem as Comment;
            if (string.IsNullOrEmpty(comment.email))
                return;
            Device.OpenUri(new Uri(String.Format("mailto:{0}?subject={1}", comment.email, "Regarding your comment")));

        }

        private void GetComments()
        {
            this.comments.Clear();
            List<Comment> data = APIConnection.GetComments(this.post.id);
            foreach (Comment c in data)
                this.comments.Add(c);
        }

        private void ViewProfile() {
            UserProfilePage page = new UserProfilePage(this.post);
            Navigation.PushAsync(page);
        }
    }
}