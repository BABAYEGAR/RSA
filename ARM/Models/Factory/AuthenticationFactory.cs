using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using ARM.Models.Authentication;
using ARM.Models.XmlConverter;

namespace ARM.Models
{
    public class AuthenticationFactory
    {

        public RegisterUserResult RegisterUser(RegisterUser registerUser,string path)
        {
            var response = new RegisterUserResult();

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            doc.GetElementsByTagName("RsaId").Item(0).InnerText = registerUser.RsaId;
            doc.GetElementsByTagName("UserName").Item(0).InnerText = registerUser.UserName;
            doc.GetElementsByTagName("Password").Item(0).InnerText = registerUser.Password;
            doc.GetElementsByTagName("emailaddress").Item(0).InnerText = registerUser.Email;
            doc.GetElementsByTagName("dob").Item(0).InnerText = registerUser.DateOfBirth;
            doc.GetElementsByTagName("mobile").Item(0).InnerText = registerUser.Mobile;

            //payload of xml document(Conversion to xml document)
            var stringPayload = new XmlConverter.XmlConverter().ToXml(doc);
            //econding of xml document to UTF-8
            var encodedString = new UTF8Encoding().GetString(stringPayload);

            //replaces xml document footers
            var httpContent = new StringContent(encodedString, Encoding.UTF8, "text/xml");

            using (var httpClient = new HttpClient())
            {
                // Do the actual request and await the response
                var httpResponse =
                     httpClient.PostAsync("http://41.216.173.228/RoboService/UserServicing.asmx?op=RegisterUser", httpContent);

                // If the response contains content we want to read it!
                if (httpResponse.Result.Content != null)
                    if (httpResponse.Result.IsSuccessStatusCode)
                    {
                        //convert back to xml string
                        var stringData = httpResponse.Result.Content.ReadAsStringAsync().Result;
                        XmlDocument resultDoc = new XmlDocument();
                        resultDoc.LoadXml(stringData);

                        response.responsecode = resultDoc.GetElementsByTagName("responsecode").Item(0).InnerText;
                        response.responsemessage = resultDoc.GetElementsByTagName("responsemessage").Item(0).InnerText;
                        response.comment = resultDoc.GetElementsByTagName("comment").Item(0).InnerText;
                    }
            }

            return response;
        }

        public UserAuthenticationResult LoginUser(UserAuthentication userAuthentication, string path)
        {
            var response = new UserAuthenticationResult();

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            doc.GetElementsByTagName("UserName").Item(0).InnerText = userAuthentication.UserName;
            doc.GetElementsByTagName("Password").Item(0).InnerText = userAuthentication.Password;

            //payload of xml document(Conversion to xml document)
            var stringPayload = new XmlConverter.XmlConverter().ToXml(doc);
            //econding of xml document to UTF-8
            var encodedString = new UTF8Encoding().GetString(stringPayload);

            //replaces xml document footers
            var httpContent = new StringContent(encodedString, Encoding.UTF8, "text/xml");

            using (var httpClient = new HttpClient())
            {
                // Do the actual request and await the response
                var httpResponse =
                     httpClient.PostAsync("http://41.216.173.228/RoboService/UserServicing.asmx?op=RegisterUser", httpContent);

                // If the response contains content we want to read it!
                if (httpResponse.Result.Content != null)
                    if (httpResponse.Result.IsSuccessStatusCode)
                    {
                        //convert back to xml string
                        var stringData = httpResponse.Result.Content.ReadAsStringAsync().Result;
                        XmlDocument resultDoc = new XmlDocument();
                        resultDoc.LoadXml(stringData);

                        response.responsecode = resultDoc.GetElementsByTagName("responsecode").Item(0).InnerText;
                        response.responsemessage = resultDoc.GetElementsByTagName("responsemessage").Item(0).InnerText;
                        response.comment = resultDoc.GetElementsByTagName("comment").Item(0).InnerText;
                    }
            }

            return response;
        }
        public RegisterUserResult UpdateUserProfile(RegisterUser registerUser, string path)
        {
            var response = new RegisterUserResult();

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            doc.GetElementsByTagName("RsaId").Item(0).InnerText = registerUser.RsaId;
            doc.GetElementsByTagName("UserName").Item(0).InnerText = registerUser.UserName;
            doc.GetElementsByTagName("Password").Item(0).InnerText = registerUser.Password;
            doc.GetElementsByTagName("emailaddress").Item(0).InnerText = registerUser.Email;
            doc.GetElementsByTagName("dob").Item(0).InnerText = registerUser.DateOfBirth;
            doc.GetElementsByTagName("mobile").Item(0).InnerText = registerUser.Mobile;

            //payload of xml document(Conversion to xml document)
            var stringPayload = new XmlConverter.XmlConverter().ToXml(doc);
            //econding of xml document to UTF-8
            var encodedString = new UTF8Encoding().GetString(stringPayload);

            //replaces xml document footers
            var httpContent = new StringContent(encodedString, Encoding.UTF8, "text/xml");

            using (var httpClient = new HttpClient())
            {
                // Do the actual request and await the response
                var httpResponse =
                     httpClient.PostAsync("http://41.216.173.228/RoboService/UserServicing.asmx?op=RegisterUser", httpContent);

                // If the response contains content we want to read it!
                if (httpResponse.Result.Content != null)
                    if (httpResponse.Result.IsSuccessStatusCode)
                    {
                        //convert back to xml string
                        var stringData = httpResponse.Result.Content.ReadAsStringAsync().Result;
                        XmlDocument resultDoc = new XmlDocument();
                        resultDoc.LoadXml(stringData);

                        response.responsecode = resultDoc.GetElementsByTagName("responsecode").Item(0).InnerText;
                        response.responsemessage = resultDoc.GetElementsByTagName("responsemessage").Item(0).InnerText;
                        response.comment = resultDoc.GetElementsByTagName("comment").Item(0).InnerText;
                    }
            }

            return response;
        }
        public ActivateRegisteredUserResult ActivateRegisteredUser(ActivateRegisteredUser activateRegisteredUser, string path)
        {
            var response = new ActivateRegisteredUserResult();

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            doc.GetElementsByTagName("authenticationCode").Item(0).InnerText = activateRegisteredUser.authenticationCode;
            doc.GetElementsByTagName("pin").Item(0).InnerText = activateRegisteredUser.pin;

            //payload of xml document(Conversion to xml document)
            var stringPayload = new XmlConverter.XmlConverter().ToXml(doc);
            //econding of xml document to UTF-8
            var encodedString = new UTF8Encoding().GetString(stringPayload);

            //replaces xml document footers
            var httpContent = new StringContent(encodedString, Encoding.UTF8, "text/xml");

            using (var httpClient = new HttpClient())
            {
                // Do the actual request and await the response
                var httpResponse =
                     httpClient.PostAsync("http://41.216.173.228/RoboService/UserServicing.asmx?op=RegisterUser", httpContent);

                // If the response contains content we want to read it!
                if (httpResponse.Result.Content != null)
                    if (httpResponse.Result.IsSuccessStatusCode)
                    {
                        //convert back to xml string
                        var stringData = httpResponse.Result.Content.ReadAsStringAsync().Result;
                        XmlDocument resultDoc = new XmlDocument();
                        resultDoc.LoadXml(stringData);

                        response.responsecode = resultDoc.GetElementsByTagName("responsecode").Item(0).InnerText;
                        response.responsemessage = resultDoc.GetElementsByTagName("responsemessage").Item(0).InnerText;
                        response.comment = resultDoc.GetElementsByTagName("comment").Item(0).InnerText;
                    }
            }

            return response;
        }


    }
}
