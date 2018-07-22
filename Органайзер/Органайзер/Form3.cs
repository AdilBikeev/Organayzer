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
    public partial class Form3 : Form
    {

        

        public Form3()
        {
            InitializeComponent();
            

        }


        private void button1_Click(object sender, EventArgs e)
        {      
            DateTime finishDate = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
            TimeSpan left = finishDate.Subtract(DateTime.Now);//сохраняет значение - кол-во времени от данного NOW верменит, до выбранного момента
            label5.Text = left.Days.ToString("0");
            label6.Text = left.Hours.ToString("0");
            label7.Text = left.Minutes.ToString("0");
            label4.Text = left.Seconds.ToString("0");



            if ((label5.Text != "") && (label6.Text != "") && (label7.Text != "") && (label4.Text != ""))
            {
                label9.Text = "Дней     Часов    Минут    Секунд    Миллисекунд";
            }
        }
    }
}
