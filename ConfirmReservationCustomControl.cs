﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;


namespace HospitalMangementSystem
{
    public partial class ConfirmReservationCustomControl : UserControl
    {
        HospitalEntities hospital;
        public ConfirmReservationCustomControl()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
        }

        //Search button
        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {

            #region SQL command
            //foreach (Panel panel in Controls.OfType<Panel>())
            //{
            //    string Name = panel.Name;
            //    string Status = panel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Name.Substring(2);

            //    SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM dbo.Department WHERE Name = '{Name}'");
            //    int count = (int)command.ExecuteScalar();
            //    if (count == 0)
            //    {
            //        command = new SqlCommand($"INSERT INTO Department (Name, Status) VALUES ('{Name}', '{Status}')");
            //        command.ExecuteNonQuery();
            //    }
            //    else
            //    {
            //        command = new SqlCommand($"SELECT Status FROM dbo.Department WHERE Name = '{Name}'");
            //        string currentStatus = (string)command.ExecuteScalar();
            //        if (currentStatus != Status)
            //        {
            //            command = new SqlCommand($"UPDATE dbo.Department SET Status = '{Status}' WHERE Name = '{Name}'");
            //            command.ExecuteNonQuery();
            //        }
            //    }
            //}
            #endregion
            #region MyRegion

            //var panels = Controls.OfType<Panel>();

            //foreach (var panel in panels)
            //{
            //    string name = panel.Name;
            //    string status = panel.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked)?.Name.Substring(2);
            //    //var checkedRadioButtons = panel.Controls.OfType<RadioButton>().Where(rb => rb.Checked);


            //    //foreach (var radioButton in checkedRadioButtons)
            //    //{
            //    //    string status = radioButton.Name;
            //    //}

            //    var department = hospital.Departments.FirstOrDefault(d => d.Name == name);
            //        if (department == null)
            //        {
            //            hospital.Departments.Add(department);
            //        }
            //        else if (department.Status != status)
            //        {
            //            department.Status = status;
            //        }
            //        hospital.SaveChanges();

            //} 
            //foreach (var panel in Controls.OfType<Panel>())
            //{
            //    string name = panel.Name;
            //    RadioButton checkedRadioButton = panel.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked);
            //    string status = checkedRadioButton != null ? checkedRadioButton.Name.Substring(2) : null;

            //    var department = hospital.Departments.FirstOrDefault(d => d.Name == name);
            //    if (department == null)
            //    {
            //        department = new Department { Name = name, Status = status };
            //        hospital.Departments.Add(department);
            //    }
            //    else if (status != null && department.Status != status)
            //    {
            //        department.Status = status;
            //    }
            //    hospital.SaveChanges();
            //}
            #endregion

            #region Confirm Rservation
            int id = int.Parse(PatientIDTxt.Text);
            var Paient = hospital.Patiens.FirstOrDefault(z => z.ID == id);
            string PaientFName = Paient.FirstName;
            string PaientLName = Paient.LastName;
            var Reservation = hospital.Reservations.FirstOrDefault(z => z.PatientID == id);
            DateTime Date = Reservation.MeetTime;
            string ReservationDate = Date.ToString("dd/MM/yyyy");
            ReservationDateTxt.Text = ReservationDate.ToString();
            PatientNameTxt.Text = $"{PaientFName} {PaientLName}";

            #endregion

        }




        #region Handling Hours Buttons <3

        private void Btn1_Click(object sender, EventArgs e)
        {
            SendEmail(Btn1.Text);
            SendWhatssAppMsg(Btn1.Text);
            Clear();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            SendEmail(Btn2.Text);
            SendWhatssAppMsg(Btn2.Text);
            Clear();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            SendEmail(Btn3.Text);
            SendWhatssAppMsg(Btn3.Text);
            Clear();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            SendEmail(Btn4.Text);
            SendWhatssAppMsg(Btn4.Text);
            Clear();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            SendEmail(Btn5.Text);
            SendWhatssAppMsg(Btn5.Text);
            Clear();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            SendEmail(Btn6.Text);
            SendWhatssAppMsg(Btn6.Text);
            Clear();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            SendEmail(Btn7.Text);
            SendWhatssAppMsg(Btn7.Text);
            Clear();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            SendEmail(Btn8.Text);
            SendWhatssAppMsg(Btn8.Text);
            Clear();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            SendEmail(Btn9.Text);
            SendWhatssAppMsg(Btn9.Text);
            Clear();
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            SendEmail(Btn10.Text);
            SendWhatssAppMsg(Btn10.Text);
            Clear();
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            SendEmail(Btn11.Text);
            SendWhatssAppMsg(Btn11.Text);
            Clear();
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            SendEmail(Btn12.Text);
            SendWhatssAppMsg(Btn12.Text);
            Clear();
        }

        #endregion

        //To Clear the text Boxes
        public void Clear()
        {
            MessageBox.Show("The Reservation Hour And Date has Sent to Patient's \n-Email  \n-WhattsApp",
                "Confirmation Message",MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
            PatientIDTxt.Text = string.Empty;
            ReservationDateTxt.Text = string.Empty;
            PatientNameTxt.Text = string.Empty;

        }
        //Send Emails 
        public void SendEmail(string Hour)
        {
            int id = int.Parse(PatientIDTxt.Text);
            var Paient = hospital.Patiens.FirstOrDefault(z => z.ID == id);
            var Reservation = hospital.Reservations.FirstOrDefault(z => z.PatientID == id);
            DateTime Date = Reservation.MeetTime;
            string ReservationDate = Date.ToString("dd/MM/yyyy");
            string PaientFName = Paient.FirstName;
            string PaientLName = Paient.LastName;
            string Email = Paient.email;
            string Title = (Paient.Gender == "m" ? "Mr:" : "Ms:");
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("zeyadmohsen1999@gmail.com", "zbhgnoxnjzleevfu\r\n"),
                    EnableSsl = true
                };
                client.Send("zeyadmohsen1999@gmail.com", Email, "Reservation Time And Date.", $"Hello {Title} {PaientFName} {PaientLName} \n \n Your Resrvation Date and time is: {ReservationDate} in {Hour} \n \nThank You for dealing with our great Hospital <3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Send WhattsApp Message
        public async void SendWhatssAppMsg(string Hour)
        {
            int id = int.Parse(PatientIDTxt.Text);
            var Paient = hospital.Patiens.FirstOrDefault(z => z.ID == id);
            var Reservation = hospital.Reservations.FirstOrDefault(z => z.PatientID == id);
            DateTime Date = Reservation.MeetTime;
            string ReservationDate = Date.ToString("dd/MM/yyyy");
            string PaientFName = Paient.FirstName;
            string PaientLName = Paient.LastName;
            string Email = Paient.email;
            string PatientPhone = Paient.phone;
            string Title = (Paient.Gender == "m" ? "Mr:" : "Ms:");

            string phone = "+2"+ PatientPhone;
            var url = "https://api.ultramsg.com/instance49044/messages/chat";
            var client = new RestClient(url);

            var request = new RestRequest(url, Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("token", "glamz1fu79hu4dn0");
            request.AddParameter("to", phone);
            request.AddParameter("body", $"Hello {Title} {PaientFName} {PaientLName} \n \n Your Resrvation Date and time is: {ReservationDate} in {Hour} \n \nThank You for dealing with our great Hospital <3");


            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;
        }
    }
}
