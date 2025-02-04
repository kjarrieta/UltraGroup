using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using BackBooking.Domain.BusisnesDTOs;
using MimeKit.Text;

namespace BackBooking.Application.Services
{
    public class EmailService
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUser;
        private readonly string _smtpPass;

        public EmailService(string smtpServer, int smtpPort, string smtpUser, string smtpPass)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUser = smtpUser;
            _smtpPass = smtpPass;
        }

        public async Task SendEmailAsync(BookingGuest bookingGuest)
        {
            string from = "youremail@example.com";
            string to = bookingGuest.Guest.GuestMail;
            string subject = $"Reservation Confirmation: {bookingGuest.Booking.IdBooking}";
            

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(from, from));
            message.To.Add(new MailboxAddress(to, to));
            message.Subject = subject;
            
            string body = $"Estimad@ señor@{bookingGuest.Guest.GuestName}\n\n" +
                $"According to your kind request, we send you the information corresponding to your reservation \n" +
                $"Reserve Holder {bookingGuest.Guest.GuestName}\n" +
                $"Reservation code {bookingGuest.Booking.IdBooking} \n" +
                $"Reservation Duration {bookingGuest.Booking.StartDate} or {bookingGuest.Booking.EndDate} \n\n" +
                $"We are attentive to any questions";

            // Crear el cuerpo del mensaje con saltos de línea
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = body;

            message.Body = bodyBuilder.ToMessageBody();

         

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_smtpServer, _smtpPort, true);
                await client.AuthenticateAsync(_smtpUser, _smtpPass);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }

        }
    }
