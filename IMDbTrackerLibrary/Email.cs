using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using IMDbTrackerLibrary.Models;
using System.IO;
using System.Drawing;
using System.Net.Mime;
using IMDbTrackerLibrary.Models.API;

namespace IMDbTrackerLibrary {
    public static class Email {
        private static void SendEmail(string toAddress, string subject, string body, string imageName) {
            SendEmail(new List<string> { toAddress }, new List<string>(), subject, body, imageName);
        }

        private static void SendEmail(List<string> toAddress, List<string> bcc, string subject, string body, string imageName) {
            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.GetEmailResourceString("SenderDisplayName"));

            MailMessage mail = new MailMessage();
            foreach(string email in toAddress) {
                mail.To.Add(email);
            }

            foreach(string email in bcc) {
                mail.To.Add(email);
            }
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            if(imageName == null || imageName.Length > 0) {
                imageName = GlobalConfig.AppKeyLookup("emailLogoImage");
            }

            Image logo = (Image)GlobalConfig.GetEmailResourceImage(imageName);
            AddImageToEmail(mail, logo);

            SmtpClient client = new SmtpClient();
            client.Send(mail);
        }

        private static Stream GetImageStream(Image image) {
            ImageConverter imageConverter = new ImageConverter();
            byte[] imgaBytes = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
            MemoryStream memoryStream = new MemoryStream(imgaBytes);

            return memoryStream;
        }

        private static void AddImageToEmail(MailMessage mail, Image image) {
            Stream imageStream = GetImageStream(image);

            LinkedResource imageResource = new LinkedResource(imageStream, "image/png") { ContentId = "email-logo" };
            AlternateView alternateView = AlternateView.CreateAlternateViewFromString(mail.Body, mail.BodyEncoding, MediaTypeNames.Text.Html);

            alternateView.LinkedResources.Add(imageResource);
            mail.AlternateViews.Add(alternateView);
        }

        public static void SendWelcomeMail(string toAddress, User user, string password, string imageName) {

            string subject = GlobalConfig.GetEmailResourceString("CreatedAccounSubject");

            StringBuilder body = new StringBuilder();

            body.AppendLine("<div style='text-align: center;'>");
            body.AppendLine("<img title='IMDb Tracker logo' alt='IMDb Tracler logo' src='cid:email-logo' />");
            body.AppendLine("<h1>" + GlobalConfig.GetEmailResourceString("CreatedAccounTitle") + " " + user.FirstName + " " + user.LastName + "</h1>");
            body.AppendLine("<p>" + GlobalConfig.GetEmailResourceString("CreatedAccounMessage") + "</p>");
            body.AppendLine("<p><strong>Username: </strong>" + user.Username + "</p>");
            body.AppendLine("<p><strong>Password: </strong>" + password + "</p>");
            body.AppendLine("<br/>");
            body.AppendLine("<strong>" + GlobalConfig.GetEmailResourceString("Signature") + "</strong>");
            body.AppendLine("</div>");

            SendEmail(toAddress, subject, body.ToString(), imageName);
        }

        public static void SendUpdateProfileMail(string toAddress, User user, string password, string imageName) {

            string subject = GlobalConfig.GetEmailResourceString("UpdateProfileSubject");

            StringBuilder body = new StringBuilder();

            body.AppendLine("<div style='text-align: center;'>");
            body.AppendLine("<img title='IMDb Tracker logo' alt='IMDb Tracler logo' src='cid:email-logo' />");
            body.AppendLine("<h1>" + GlobalConfig.GetEmailResourceString("UpdateProfileTitle") + " " + user.FirstName + " " + user.LastName + "</h1>");
            body.AppendLine("<p>" + GlobalConfig.GetEmailResourceString("UpdateProfileMessage") + "</p>");
            body.AppendLine("<p><strong>First name: </strong>" + user.FirstName + "</p>");
            body.AppendLine("<p><strong>Last name: </strong>" + user.LastName + "</p>");
            body.AppendLine("<p><strong>Email: </strong>" + user.Email + "</p>");
            body.AppendLine("<p><strong>Password: </strong>" + password + "</p>");
            body.AppendLine("<p><strong>API key: </strong>" + user.APIKey + "</p>");
            body.AppendLine("<br/>");
            body.AppendLine("<strong>" + GlobalConfig.GetEmailResourceString("Signature") + "</strong>");
            body.AppendLine("</div>");

            SendEmail(toAddress, subject, body.ToString(), imageName);
        }

        public static void SendResetToken(string toAddress, string passwordResetToken, DateTime tokenExpiration, string imageName) {
            string subject = GlobalConfig.GetEmailResourceString("PasswordResetSubject");

            string tokeExpirationDate = DateTime.SpecifyKind(tokenExpiration, DateTimeKind.Local).ToString("HH:mm:ss dd.MM.yyyy");

            StringBuilder body = new StringBuilder();

            body.AppendLine("<div style='text-align: center;'>");
            body.AppendLine("<img title='IMDb Tracker logo' alt='IMDb Tracler logo' src='cid:email-logo' />");
            body.AppendLine("<h1>" + GlobalConfig.GetEmailResourceString("PasswordResetTitle") + "</h1>");
            body.AppendLine("<p>" + GlobalConfig.GetEmailResourceString("PasswordResetMessage") + "</p>");
            body.AppendLine("<p><strong>Reset token: </strong>" + passwordResetToken + "</p>");
            body.AppendLine("<p><strong>Token expires: </strong>" + tokeExpirationDate + "</p>");
            body.AppendLine("<br/>");
            body.AppendLine("<strong>" + GlobalConfig.GetEmailResourceString("Signature") + "</strong>");
            body.AppendLine("</div>");

            SendEmail(toAddress, subject, body.ToString(), imageName);
        }

        public static void SendPasswordResetToken(User user) {
            string passwordResetToken = Helpers.GeneratePasswordResetToken();
            DateTime passwordResetTokenValid = DateTime.UtcNow.AddMinutes(5);

            GlobalConfig.Connection.SetPasswordResetToken(user, passwordResetToken, passwordResetTokenValid);

            SendResetToken(user.Email, passwordResetToken, passwordResetTokenValid, null);
            Helpers.ShowMessageBox("PasswordResetTokenSend");
        }

        public async static Task SendFavoritesToWatchEmail(User user) {

            API api = new API(user);

            List<string> showsWhithNewEpisodes = new List<string>();

            List<FavoriteShow> favoriteShows = GlobalConfig.Connection.FindUserFavoriteShows(user);

            foreach(FavoriteShow favoriteShow in favoriteShows) {

                Show show = GlobalConfig.Connection.FindShowById(favoriteShow.ShowId);

                var seasons = await api.GetShowSeasons(favoriteShow.ShowId);

                bool hasNewEpisode = false;

                foreach(ShowSeason season in seasons.ToList()) {
                    foreach(ShowSeasonEpisode seasonEpisode in season.Episodes) {

                        if(seasonEpisode.Year < ((DateTime)user.LastLogin).Year) {
                            break;
                        }

                        if(seasonEpisode.Year == ((DateTime)user.LastLogin).Year) {

                            Episode episode = GlobalConfig.Connection.FindEpisodeById(seasonEpisode.Id);

                            if(episode == null) {

                                EpisodeDetails episodeDetails = await api.GetEpisodeDetails(seasonEpisode.Id);

                                episode = new Episode() {
                                    EpisodeId = episodeDetails.Id,
                                    ShowId = show.Id,
                                    Show = show,
                                    Title = episodeDetails.Title.Title,
                                    EpisodeNumber = episodeDetails.Title.Episode,
                                    ImageUrl = episodeDetails.Title.Image.Url,
                                    RunningTimeInMinutes = episodeDetails.Title.RunningTimeInMinutes,
                                    Season = episodeDetails.Title.Season,
                                    Rating = episodeDetails.Ratings.Rating,
                                    Genres = string.Join(", ", episodeDetails.Genres),
                                    Year = episodeDetails.Title.Year,
                                    ReleaseDate = DateTime.Parse(episodeDetails.ReleaseDate),
                                    PlotOutline = episodeDetails.PlotOutline.Text,
                                };

                                GlobalConfig.Connection.AddEpisode(episode);
                            }


                            if(episode.ReleaseDate > user.LastLogin && episode.ReleaseDate < DateTime.UtcNow) {

                                showsWhithNewEpisodes.Add(show.Title);
                                hasNewEpisode = true;
                                break;
                            }
                        }
                    }

                    if(hasNewEpisode) {
                        break;
                    }
                }

                if(showsWhithNewEpisodes.Count() == 0) {
                    return;
                }

                string subject = GlobalConfig.GetEmailResourceString("NewFavoriteEpisodesSubject");

                StringBuilder body = new StringBuilder();

                body.AppendLine("<div style='text-align: center;'>");
                body.AppendLine("<img title='IMDb Tracker logo' alt='IMDb Tracler logo' src='cid:email-logo' />");
                body.AppendLine("<h1>" + GlobalConfig.GetEmailResourceString("NewFavoriteEpisodesTitle") + "</h1>");
                body.AppendLine("<p>" + GlobalConfig.GetEmailResourceString("NewFavoriteEpisodesMessage") + "</p>");

                body.AppendLine("<ul>");
                foreach(string episodeTitle in showsWhithNewEpisodes) {
                    body.AppendLine("<li><strong>" + episodeTitle + "</strong></li>");
                }

                body.AppendLine("</ul>");
                body.AppendLine("<br/>");
                body.AppendLine("<strong>" + GlobalConfig.GetEmailResourceString("Signature") + "</strong>");
                body.AppendLine("</div>");

                SendEmail(user.Email, subject, body.ToString(), null);
            }
        }
    }
}
