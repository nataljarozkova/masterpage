using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace masterpage
{
    public partial class MainPage : ContentPage
    {
        public ListView listView;

        public MainPage()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPage
            {
                Title = "Contacts",
                TargetType = typeof(ContactsPageCS)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                TargetType = typeof(TodoListPageCS)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                TargetType = typeof(ReminderPageCS)
            });

            ListView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() => {
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });


                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(label, 1, 0);

                    return new ViewCell { View = grid };
                }),
                SeparatorVisibility = SeparatorVisibility.None
            };


            Title = "Personal Organiser";
            Content = new StackLayout
            {
                Children = { ListView }
            };
        }

        public ListView ListView { get; }
    }
}