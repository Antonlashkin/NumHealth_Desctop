using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NH
{
    internal class Medicament
    {
        private string Name;
        //private int Number_Of_Pills_Per_Day;
        private int Number_Of_Pills_In_A_Pack;
        private int Number_Of_Pills_In_A_Pack_Now;
        private int Number_Of_Pills_In_A_Breakfast;
        private int Number_Of_Pills_In_A_Lunch;
        private int Number_Of_Pills_In_A_Dinner;
        private DateTime Breakfast;
        private DateTime Lunch;
        private DateTime Dinner;
        private DateTime Reminder_Time;

        public Medicament(string Name, int Number_Of_Pills_In_A_Pack, int Number_Of_Pills_In_A_Pack_Now, int Number_Of_Pills_In_A_Breakfast, int Number_Of_Pills_In_A_Lunch, int Number_Of_Pills_In_A_Dinner)
        {
            this.Name = Name;
            this.Number_Of_Pills_In_A_Pack = Number_Of_Pills_In_A_Pack;
            this.Number_Of_Pills_In_A_Pack_Now = Number_Of_Pills_In_A_Pack_Now;
            this.Number_Of_Pills_In_A_Breakfast = Number_Of_Pills_In_A_Breakfast;
            this.Number_Of_Pills_In_A_Lunch = Number_Of_Pills_In_A_Lunch;
            this.Number_Of_Pills_In_A_Dinner = Number_Of_Pills_In_A_Dinner;
        }

        public Medicament(string Name, int Number_Of_Pills_In_A_Pack, int Number_Of_Pills_In_A_Pack_Now, int Number_Of_Pills_In_A_Breakfast, int Number_Of_Pills_In_A_Lunch, int Number_Of_Pills_In_A_Dinner, DateTime Breakfast, DateTime Lunch, DateTime Dinner)
        {
            this.Name = Name;
            this.Number_Of_Pills_In_A_Pack = Number_Of_Pills_In_A_Pack;
            this.Number_Of_Pills_In_A_Pack_Now = Number_Of_Pills_In_A_Pack_Now;
            this.Number_Of_Pills_In_A_Breakfast = Number_Of_Pills_In_A_Breakfast;
            this.Number_Of_Pills_In_A_Lunch = Number_Of_Pills_In_A_Lunch;
            this.Number_Of_Pills_In_A_Dinner = Number_Of_Pills_In_A_Dinner;
            this.Breakfast = Breakfast;
            this.Lunch = Lunch;
            this.Dinner = Dinner;
        }

        public Medicament()
        {
            Name = "";
            Number_Of_Pills_In_A_Pack = 0;
            Number_Of_Pills_In_A_Pack_Now = 0;
            Number_Of_Pills_In_A_Breakfast = 0;
            Number_Of_Pills_In_A_Lunch = 0;
            Number_Of_Pills_In_A_Dinner = 0;
            Breakfast = new DateTime(2000, 1, 1);
            Lunch = new DateTime(2000, 1, 1);
            Dinner = new DateTime(2000, 1, 1);
        }

        public int Get_Number_Of_Pills_In_A_Pack()
        {
            return Number_Of_Pills_In_A_Pack;
        }

        public void Set_Number_Of_Pills_In_A_Pack(int New_Value)
        {
            Number_Of_Pills_In_A_Pack = New_Value;
        }

        public int Get_Number_Of_Pills_In_A_Pack_Now()
        {
            return Number_Of_Pills_In_A_Pack_Now;
        }

        public void Set_Number_Of_Pills_In_A_Pack_Now(int New_Value)
        {
            Number_Of_Pills_In_A_Pack_Now = New_Value;
        }
        public int Get_Number_Of_Pills_In_A_Breakfast()
        {
            return Number_Of_Pills_In_A_Breakfast;
        }

        public void Set_Number_Of_Pills_In_A_Breakfast(int New_Value)
        {
            Number_Of_Pills_In_A_Breakfast = New_Value;
        }

        public int Get_Number_Of_Pills_In_A_Lunch()
        {
            return Number_Of_Pills_In_A_Lunch;
        }

        public void Set_Number_Of_Pills_In_A_Lunch(int New_Value)
        {
            Number_Of_Pills_In_A_Lunch = New_Value;
        }

        public int Get_Number_Of_Pills_In_A_Dinner()
        {
            return Number_Of_Pills_In_A_Dinner;
        }

        public void Set_Number_Of_Pills_In_A_Dinner(int New_Value)
        {
            Number_Of_Pills_In_A_Dinner = New_Value;
        }

        public string Get_Name()
        {
            return Name;
        }

        public void Set_Name(string New_Value)
        {
            Name = New_Value;
        }

        public DateTime Get_Breakfast(DateTime Breakfast)
        {
            return Breakfast;
        }

        public void Set_Breakfast(DateTime New_Value)
        {
            Breakfast = New_Value;
        }

        public DateTime Get_Lunch()
        {
            return Lunch;
        }

        public void Set_Lunch(DateTime New_Value)
        {
            Lunch = New_Value;
        }

        public DateTime Get_Dinner()
        {
            return Dinner;
        }

        public void Set_Dinner(DateTime New_Value)
        {
            Dinner = New_Value;
        }

        public DateTime Get_Reminder_Time()
        {
            return Reminder_Time;
        }

        public void Set_Reminder_Time(DateTime New_Value)
        {
            Reminder_Time = New_Value;
        }
    }
}
