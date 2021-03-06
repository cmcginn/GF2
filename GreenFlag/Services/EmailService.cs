﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace GreenFlag.Services
{
    /*
     
      MailMessage message = new MailMessage();
      message.From = new MailAddress( model.EmailAddress );

      message.To.Add( new MailAddress( "greenflagsoftware@gmail.com" ) );
      message.Bcc.Add(new MailAddress("chris.s.mcginn@live.com"));

      message.Subject = "Webform inquiry from Green Flag";
      var body = String.Format( "Name:{0}{1}",model.Name,System.Environment.NewLine );
      body += String.Format( "Email:{0}{1}",model.EmailAddress,System.Environment.NewLine );
      body += String.Format( "Phone:{0}{1}",model.Phone,System.Environment.NewLine );
      body += model.Message;
      message.Body = body;
      SmtpClient client = new SmtpClient();
      client.Send( message );
      return View("Contacted");
     */
    public class EmailService
    {
        public string GetToddress()
        {
            var result = System.Configuration.ConfigurationManager.AppSettings["contactSubmissionRecipient"];
            return result;
        }

        public List<string> GetBccList()
        {
            var result = System.Configuration.ConfigurationManager.AppSettings["contactSubmissionBccList"].Split(',').ToList();
            return result;
        }

        public bool SendContactSubmission(string emailAddress,string name,string comments,string phone)
        {
            var result = false;
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress(emailAddress);
                message.To.Add(new MailAddress(GetToddress()));
                GetBccList().ForEach(x => message.Bcc.Add(new MailAddress(x)));
                message.Subject = "Webform inquiry from Green Flag";
                var body = String.Format("Name:{0}{1}", name, System.Environment.NewLine);
                body += String.Format("Email:{0}{1}", emailAddress, System.Environment.NewLine);
                body += String.Format("Phone:{0}{1}", phone, System.Environment.NewLine);
                body += comments;
                message.Body = body;
                var client = new SmtpClient();
                client.Send(message);
                result = true;
            }
            catch { 
                //swallow
            }
            return result;
        }
    }
}