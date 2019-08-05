using System;
using System.Collections.Generic;
using System.Text;
using Orientado_a_Objetos.Exceptions.Exceptions;


namespace Orientado_a_Objetos.Exceptions
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout < checkin)
            {
                throw new DomainException(" To make a reservation the Check-out date must be after Check-in.");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;

        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return ($"Reservation: Room {RoomNumber}, " +
                $"Checkin : {Checkin.ToString("dd/MM/yyyy")}, " +
                $"Checkout : {Checkout.ToString("dd/MM/yyyy")}," +
                $" {Duration()} nights.");
        }


        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin <= now || checkout <= now)
            {
                throw new DomainException("Reservation dates for update must be future dates !");
            }
            if (checkout < checkin)
            {
                throw new DomainException("Check-out date must be after Chek-in ! ");
            }
            Checkin = checkin;
            Checkout = checkout;
        }

        //MAIN

        /*
           try
           {
               Console.Write("Room Number : ");
               int roomNumber = int.Parse(Console.ReadLine());

               Console.Write("Checkin dd/MM/yyyy : ");
               DateTime checkin = DateTime.Parse(Console.ReadLine());

               Console.Write("Checkout dd/MM/yyyy : ");
               DateTime checkout = DateTime.Parse(Console.ReadLine());

               Reservation r1 = new Reservation(roomNumber, checkin, checkout);
               Console.WriteLine(r1);

               Console.WriteLine("\n\n Enter with dates to update :");
               Console.Write("Check-in Date dd/MM/yyyy : ");
               checkin = DateTime.Parse(Console.ReadLine());
               Console.Write("Check-out Date dd/MM/yyyy : ");
               checkout = DateTime.Parse(Console.ReadLine());

               r1.UpdateDates(checkin, checkout);
               Console.WriteLine(r1);
           }
           catch (DomainException e)
           {
               Console.WriteLine( e.Message);
           }
           */


    }
}
