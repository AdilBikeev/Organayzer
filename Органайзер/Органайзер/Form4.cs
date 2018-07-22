using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_Кирилла
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            DateTime start = new DateTime();
            // string week = start.Now.DayOfWeek.ToString();//узнаем день недели
            string week = DateTime.Now.DayOfWeek.ToString();
            switch(week)
            {
                case "Sunday": { label2.Text = "0";break; }//воскресенье
                case "Monday": { label2.Text = "5"; break; }//понедельник
                case "Tuesday": { label2.Text = "4"; break; }
                case "Wednesday": { label2.Text = "3"; break; }
                case "Thursday": { label2.Text = "2"; break; }
                case "Fridayy": { label2.Text = "1"; break; }
                case "Saturday": { label2.Text = "0"; break; }
            }
        }
        
    }
}
