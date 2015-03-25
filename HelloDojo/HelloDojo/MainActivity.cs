using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloDojo
{
    [Activity(Label = "HelloDojo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.myButton);
            var userNameField = FindViewById<TextView>(Resource.Id.userName);
            var passwordField = FindViewById<TextView>(Resource.Id.password);
            var welcome = FindViewById<TextView>(Resource.Id.welcome);

            var userLogin = new UserLogin();


            button.Click += delegate
            {
                welcome.Text = userLogin.Login(userNameField.Text, passwordField.Text);
            };
        }
    }
    class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
            return string.Format("Welcome, {0}. Your Password is {1}.", UserName, Password);
        }
    }
}


