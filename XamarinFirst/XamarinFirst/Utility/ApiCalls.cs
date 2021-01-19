using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinFirst.Model;

namespace XamarinFirst.Utility
{
    public class ApiCalls
    {
        #region Properties & Variables
        INavigation navigation;

        bool _IsBusy;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set
            {
                //if ((!_IsBusy) && value)
                //    navigation.PushPopupAsync(new PopupLoading());
                //else if (_IsBusy && (!value))
                //    navigation.PopPopupAsync();
                _IsBusy = value;
            }
        }
        #endregion

        #region Constructors
        public ApiCalls(INavigation navigation)
        {
            this.navigation = navigation;
        }
        #endregion

        #region Api Calling

        #region Login
        public async System.Threading.Tasks.Task<DashboardModel> Login(string Email, string Password, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "", [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "", [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            bool res = false;
            //HttpStatusCode responseStatusCode = 0;
            //DashboardModel dashboard = new DashboardModel();

            //if (await IsInternetConnected())
            //{
            //    try
            //    {
            //        IsBusy = true;

            //        request = new RestRequest("/Login", Method.GET);
            //        request.AddParameter("Email", Email);
            //        request.AddParameter("Password", Password);
            //        request.Timeout = 10000;

            //        restResponse = await client.ExecuteAsync(request);

            //        responseStatusCode = restResponse.StatusCode;

            //        if (restResponse.StatusCode == HttpStatusCode.OK)
            //        {
            //            var jObject = JObject.Parse(restResponse.Content);
            //            bool status = (bool)jObject.GetValue("Status");

            //            if (!status)
            //            {
            //                IsBusy = false;
            //                //await navigation.PushPopupAsync(new AlertPopup("E", jObject.GetValue("Message").ToString()));
            //            }
            //            else
            //            {
            //                dashboard = JsonConvert.DeserializeObject<DashboardModel>(restResponse.Content);

            //                //App.Current.Properties["StudentIdNumber"] = student.StudentIdNumber;
            //                //App.Current.Properties["Password"] = student.Password;
            //                //App.Current.Properties["Usertype"] = "Student";
            //                //await App.Current.SavePropertiesAsync();

            //                //try
            //                //{
            //                //    //await SecureStorage.SetAsync("oauth_token", "secret-oauth-token-value-from-api");
            //                //    await SecureStorage.SetAsync(keyStudentIdNumber, student.StudentIdNumber);
            //                //    await SecureStorage.SetAsync(keyStudentPassword, student.Password);
            //                //}
            //                //catch (Exception ex)
            //                //{
            //                //    App.Current.Properties[keyStudentIdNumber] = student.StudentIdNumber;
            //                //    App.Current.Properties[keyStudentPassword] = student.Password;
            //                //    await App.Current.SavePropertiesAsync();
            //                //    //await SendEmail(responseStatusCode, memberName, sourceFilePath, sourceLineNumber, ex.Message, "Exception From Pantex Health");
            //                //    //await navigation.PushPopupAsync(new AlertPopup("E", "Problem with secure storage."));
            //                //    //Application.Current.MainPage = new StudentLoginPage();
            //                //}
            //                IsBusy = false;
            //            }

            //            res = status;
            //        }
            //        else
            //        {
            //            IsBusy = false;
            //            await SendEmail(responseStatusCode, memberName, sourceFilePath, sourceLineNumber, "", "Exception From Mehdi App");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        IsBusy = false;
            //        res = false;
            //        await SendEmail(responseStatusCode, memberName, sourceFilePath, sourceLineNumber, ex.StackTrace, "Exception From Mehdi App");
            //    }
            //}

            IsBusy = false;
            //if (res)
            //    return dashboard;
            //else
                return null;

        }
        #endregion

        #endregion


        #region Check Permissions
        private bool IsInternetConnected()
        {
            var profiles = Connectivity.ConnectionProfiles;
            if (profiles.Contains(ConnectionProfile.WiFi) || profiles.Contains(ConnectionProfile.Cellular))
            {
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    return true;
                }
                else
                {
                    //await navigation.PushPopupAsync(new AlertPopup("W", "Network is Unavailable"));
                    return false;
                }
            }
            else
            {
                //await navigation.PushPopupAsync(new AlertPopup("E", "No Internet connection."));
                return false;
            }
        }
        #endregion


        #region SendEmail
        public async Task SendEmail(HttpStatusCode responseCode, string callerName, string sourceFilePath, int sourceLineNumber, string stackTrace, string subject)
        {
            //switch (responseCode)
            //{
            //    case HttpStatusCode.InternalServerError: //500
            //        {
            //            await navigation.PushPopupAsync(new AlertPopup("E", "Internal server error."));
            //            break;
            //        }
            //    case HttpStatusCode.NotFound: //404
            //        {
            //            await navigation.PushPopupAsync(new AlertPopup("E", "Link not found."));
            //            break;
            //        }
            //    case HttpStatusCode.Forbidden: //403
            //        {
            //            await navigation.PushPopupAsync(new AlertPopup("E", "The requested resource does not exist on the server."));
            //            break;
            //        }
            //    case 0:
            //        {
            //            await navigation.PushPopupAsync(new AlertPopup("E", "No response from server."));
            //            return;
            //        }
            //    default:
            //        {
            //            await navigation.PushPopupAsync(new AlertPopup("E", "An error occured while processing your request. Please try again later."));
            //            break;
            //        }
            //}

            if (IsInternetConnected())
            {
                try
                {
                    //IsBusy = true;

                    var senderEmail = new MailAddress("pantexhealth1@gmail.com", subject);
                    var receiverEmail = new MailAddress("internussoft@gmail.com", "Receiver");
                    var password = "Pantex123";
                    var sub = subject;
                    //var sub = "DEVELOPMENT : " + subject;
                    var body = "<p><b>CallerName:</b> " + callerName + "</p><br><p><b>SourceFilePath:</b> " + sourceFilePath + "</p><br><p><b>CallerLineNumber:</b> " + sourceLineNumber + "</p><br><p><b>StackTrace:</b> " + stackTrace + "</p>";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    })
                    {
                        await smtp.SendMailAsync(mess);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            //IsBusy = false;
        }
        #endregion
    }
}
