using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;

namespace XamarinFirst.ViewModel
{
    public class AccountSettingsViewModel : BaseViewModel
    {
        #region Properties & Variables
        INavigation navigation;

        public UserModel User { get; set; }
        #endregion

        #region Constructors
        public AccountSettingsViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            User = new UserModel() { DPSrc= "dp.png", Username = "Nadeem Ahmad", Contact = "03123456789" };
        }
        #endregion

        #region Functions
        private async void Browse()
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                return;
            }
            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = PhotoSize.Small,
                CompressionQuality = 25,
                MaxWidthHeight = 100,
            });
            //if(file.)

            if (file == null)
                return;

            var stream = file.GetStream();
            if (stream != null)
            {
                User.DPSrc = ImageSource.FromStream(() => stream);
            }
        }
        private async void Capture()
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Property App",
                SaveToAlbum = true,
                CompressionQuality = 25,
                PhotoSize = PhotoSize.Small,
                MaxWidthHeight = 100,
                DefaultCamera = CameraDevice.Front
            });

            if (file == null)
                return;

            var stream = file.GetStream();
            if (stream != null)
            {
                User.DPSrc = ImageSource.FromStream(() => stream);
            }
        }
        //public byte[] ReadAllBytes(Stream instream)
        //{
        //    if (instream is MemoryStream)
        //        return ((MemoryStream)instream).ToArray();

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        instream.CopyTo(memoryStream);
        //        return memoryStream.ToArray();
        //    }
        //}
        #endregion

        #region Commands
        public Command BrowseOrCaptureCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var res = await Application.Current.MainPage.DisplayActionSheet("Select Action", "Cancel", null, "Browse", "Take Picture");

                    if (res.Equals("Browse"))
                        Browse();
                    else if (res.Contains("Take"))
                        Capture();
                });
            }
        }
        
        public Command UpdateUserCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.DisplayAlert("Notification", "Name = " + User.Username + "\nContact = " + User.Contact + "\nPassword = " + User.Password, "OK");
                });
            }
        }
        #endregion
    }
}
