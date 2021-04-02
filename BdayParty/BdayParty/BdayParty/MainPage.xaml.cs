using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BdayParty
{
    public partial class MainPage : ContentPage
    {
        List<Friend> FriendList = new List<Friend>();
        public MainPage()
        {
            InitializeComponent();
        // if(DesignMode.IsDesignModeEnabled) return;
            LoadFriends();
        }


        /// <summary>
        /// 
        /// </summary>
        private void LoadFriends()
        {
            //
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BdayParty.friends.txt");

            using (StreamReader sr = new StreamReader(stream))
            {
                while (!sr.EndOfStream)
                {
                    string[] tempFriend = sr.ReadLine().Split('\t');
                    PckFriend.Items.Add(tempFriend[0]);
                    Friend friend = new Friend();
                    {

                    friend.Name = tempFriend[0];
                    friend.Age = int.Parse(tempFriend[1]);
                    friend.PhoneNumber = tempFriend[2];
                    friend.Personality = tempFriend[3];
                    friend.Rating = int.Parse(tempFriend[4]);
                    };
                    FriendList.Add(friend);

                }

            }
        }

        private void BtnDetails_Clicked(object sender, EventArgs e)
        {
            if (PckFriend.SelectedIndex > -1)
            {
                Friend selectedFriend = FriendList[PckFriend.SelectedIndex];
                Friend friend = FriendList.Where(x => x.Name == PckFriend.SelectedIndex.ToString()).FirstOrDefault();
                DisplayAlert(friend.Name, $"Age: {friend.Age}\n\n" + $"PhoneNumber: {friend.PhoneNumber}\n\n" + $"Personality: {friend.Personality}\n\n" + $"Rating: {friend.Rating}", "Close");
            }
            else
            {
                DisplayAlert("Invalid Input", "Please select a friend", "Close");
            }
        }

        private void PckFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PckFriend.SelectedIndex > -1)
            {
                Friend selectedFriend = FriendList[PckFriend.SelectedIndex];
                DisplayAlert(selectedFriend.Name, $"Age: {selectedFriend.Age}\n\n" + $"PhoneNumber: {selectedFriend.PhoneNumber}\n\n" + $"Personality: {selectedFriend.Personality}\n\n" + $"Rating: {selectedFriend.Rating}", "Close");
            }
        }
    }
}
