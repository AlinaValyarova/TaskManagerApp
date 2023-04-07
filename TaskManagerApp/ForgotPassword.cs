using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace TaskManagerApp
{
    public partial class ForgotPassword : Form
    {
        static void SendMessage(string adressTo, string messageSubject, string messageText)
        {
            string from = @"honkapp@yandex.ru"; // адреса отправителя
            string pass = "fkbyf2004!"; // пароль отправителя
            MailMessage mess = new MailMessage();
            mess.To.Add(adressTo); // адрес получателя
            mess.From = new MailAddress(from);
            mess.Subject = messageSubject; // тема
            mess.Body = messageText; // текст сообщения
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.yandex.ru"; //smtp-сервер отправителя
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(mess); // отправка пользователю
            mess.To.Remove(mess.To[0]);
            mess.To.Add(from); //для сообщения на свой адрес
            mess.Subject = "Отправлено сообщение";
            mess.Body = "Пользователю " + " отправлено сообщение";
            client.Send(mess); // отправка себе
            mess.Dispose();
        }
        public ForgotPassword()
        {
            InitializeComponent();
            UserEmailTB.KeyPress += UserEmailTB_KeyPress;
            LoginBTN.Click += LoginBTN_Click;
        }

        private void ForgotPassword_Load_1(object sender, EventArgs e)
        {

        }

        private void UserEmailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source = HonkAppDataBase.mssql.somee.com;" + "Initial Catalog=HonkAppDataBase;" + "User id=cargoesbrr_SQLLogin_1;" + "Password=nchbzqmryy;";
                    conn.Open();

                    using (SqlCommand myQuery = new SqlCommand("SELECT * FROM Users;", conn))
                    using (SqlDataReader myReader = myQuery.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            var usr = new MainForm.User();

                            usr.User_ID = (int)myReader["User_Id"];
                            usr.Email = (string)myReader["Email"];
                            if (usr.Email == UserEmailTB.Text)
                            {
                                int pas = (int)myReader["Password"];
                                label2.Text = pas.ToString();
                            }
                        }
                    }

                }

            }
        }



        private void LoginBTN_Click(object sender, EventArgs e)
        {

            string adressTo = UserEmailTB.Text; //адрес пользователя
            string messageSubject = "Восстановление пароля в HonkApp";
            string messageText = $"Здравствуйте! Ваш пароль: {label2.Text}";
            try
            {
                if (label2.Text != "label2")
                {
                    SendMessage(adressTo, messageSubject, messageText);
                    MessageBox.Show("Письмо отправлено!", "Успех!");
                    this.Hide();
                    Login lg = new Login();
                    lg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Проверьте корректность написания почты!", "Ошибка!");
                }

            }
            catch
            {
                MessageBox.Show("Проверьте корректность написания почты!", "Ошибка!");
            }






        }

        private void UserEmailTB_MouseDown(object sender, MouseEventArgs e)
        {
            UserEmailTB.Clear();
        }
    }
}
