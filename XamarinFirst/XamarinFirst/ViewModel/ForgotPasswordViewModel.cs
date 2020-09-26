using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFirst.Model;
using XamarinFirst.View;
using XamarinFirst.ViewModel;

namespace XamarinFirst.ViewModels
{
    public class ForgotPasswordViewModel : BaseViewModel
    {
        #region Properties
        INavigation navigation;
        public UserModel User { get; set; }
        public string Code { get; set; }
        public string SecurityCode { get; set; }
        #endregion

        #region Contructors
        public ForgotPasswordViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            User = new UserModel();
        }
        #endregion

        #region Functions
        private async System.Threading.Tasks.Task<bool> ValidateStudentForSubmitEmail()
        {
            //bool isValid = false;

            //// email
            //if ((!string.IsNullOrEmpty(Student.Email)) && (!string.IsNullOrWhiteSpace(Student.Email)))
            //{
            //    isValid = true;
            //}
            //else
            //{
            //    await navigation.PushPopupAsync(new AlertPopup("E", "Email cannot be empty."));
            //}

            //return isValid;
            return true;
        }

        private async System.Threading.Tasks.Task<bool> ValidateCode()
        {
            //bool isValid = false;

            //// SecurityCode
            //if ((!string.IsNullOrEmpty(SecurityCode)) && (!string.IsNullOrWhiteSpace(SecurityCode)))
            //{
            //    isValid = true;
            //}
            //else
            //{
            //    await navigation.PushPopupAsync(new AlertPopup("E", "Security Code cannot be empty."));
            //}

            //return isValid;
            return true;
        }

        private async System.Threading.Tasks.Task<bool> ValidateStudentForUpdatePassword()
        {
            //bool isValid = false;

            //// email
            //if ((!string.IsNullOrEmpty(Student.Password)) && (!string.IsNullOrWhiteSpace(Student.Password)))
            //{
            //    if ((!string.IsNullOrEmpty(Student.ConfirmPassword)) && (!string.IsNullOrWhiteSpace(Student.ConfirmPassword)))
            //    {
            //        if (Student.Password.Equals(Student.ConfirmPassword))
            //        {
            //            isValid = true;
            //        }
            //        else
            //        {
            //            await navigation.PushPopupAsync(new AlertPopup("E", "Password & Confirm Password must be same."));
            //        }
            //    }
            //    else
            //    {
            //        await navigation.PushPopupAsync(new AlertPopup("E", "Confirm Password cannot be empty."));
            //    }
            //}
            //else
            //{
            //    await navigation.PushPopupAsync(new AlertPopup("E", "Password cannot be empty."));
            //}

            //return isValid;

            return true;
        }
        #endregion

        #region Commands
        public Command SubmitEmailCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //if (await ValidateStudentForSubmitEmail())
                    //{
                    //    ApiCalls api = new ApiCalls(navigation);
                    //    Code = await api.GetVerificationCode(Student.Email);

                    //    if ((!string.IsNullOrEmpty(Code)) && (!string.IsNullOrWhiteSpace(Code)))
                    //    {
                    //        await navigation.PushAsync(new VerifyCodePage(this));
                    //    }
                    //}
                    await Application.Current.MainPage.DisplayAlert("Notification", "Code Sent To: " + User.Username, "Ok");
                    await navigation.PushAsync(new Verification(this));
                });
            }
        }

        public Command VerifyCodeCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //if (await ValidateCode())
                    //{
                    //    if (SecurityCode.Equals(Code))
                    //    {
                    //        await navigation.PushAsync(new ResetPasswordPage(this));
                    //    }
                    //    else
                    //    {
                    //        await navigation.PushPopupAsync(new AlertPopup("E", "Invalid code."));
                    //        SecurityCode = "";
                    //    }
                    //}

                    await navigation.PushAsync(new ResetPasswordPage(this));
                });
            }
        }

        public Command UpdatePasswordCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //if (await ValidateStudentForUpdatePassword())
                    //{
                    //    ApiCalls api = new ApiCalls(navigation);
                    //    bool res = await api.UpdatePassword(Student.Email, Student.Password);

                    //    if (res)
                    //    {
                    //        await navigation.PushPopupAsync(new AlertPopup("S", "Password updated successfully."));
                    //        Application.Current.MainPage = new StudentLoginPage();
                    //    }
                    //}

                    await Application.Current.MainPage.DisplayAlert("Notification", "Password Updated Successfully", "OK");
                    await navigation.PopToRootAsync();
                });
            }
        }
        #endregion
    }
}
