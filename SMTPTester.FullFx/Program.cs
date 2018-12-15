using System;
using System.Net.Mail;

namespace SMTPTester.FullFx
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Tuple<bool, MailAddress> validation;

            do
            {
                Console.Write("To: ");
                var input = Console.ReadLine();
                validation = IsValidEmail(input);
            } while (!validation.Item1);

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Send(new MailMessage
                {
                    To = { validation.Item2 },
                    Subject = "SMTP Tester",
                    Body = "SMTP well configured"
                });
            }
        }

        private static Tuple<bool, MailAddress> IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return new Tuple<bool, MailAddress>(address.Address == email, address);
            }
            catch
            {
                return new Tuple<bool, MailAddress>(false, null);
            }
        }
    }
}
