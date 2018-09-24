using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using IT15016508.DATA;
using IT15016508.NET;
using System.ComponentModel;
using System.Diagnostics;

namespace IT15016508
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<Post> posts { get; }

        public MainPage()
        {
            InitializeComponent();
            Title = "All Posts";
            posts = new ObservableCollection<Post>();
            GetPosts();
            this.BindingContext = this;
            PostsListView.ItemsSource = this.posts;
            PostsListView.ItemSelected += PostsListView_ItemSelected;
        }

        private void PostsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e) {
            if (e.SelectedItem != null) {
                CommentsPage commentsPage = new CommentsPage(e.SelectedItem as Post);
                Navigation.PushAsync(commentsPage);
            }
            PostsListView.SelectedItem = null;
        }

        private void GetPosts() {
            posts.Clear();
            List<Post> data = APIConnection.GetPosts();
            foreach(Post p in data)
                this.posts.Add(p);
        }
    }
}
