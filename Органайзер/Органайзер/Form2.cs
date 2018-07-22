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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            System.Net.ServicePointManager.Expect100Continue = false;
        }

        private void button1_Click(object sender, EventArgs e)//получаем информацию о валютах
        {
            RBKServise.DailyInfo di = new RBKServise.DailyInfo();

            System.DateTime DateFrom, DateTo;
            DateFrom = dateTimePicker1.Value;
            DateTo = dateTimePicker2.Value;

            DataSet ds = (System.Data.DataSet)di.GetCursDynamic(DateFrom, DateTo, "R01235");

            ds.Tables[0].Columns[0].ColumnName = "Дата";
            ds.Tables[0].Columns[1].ColumnName = "Вн.код валюты";
            ds.Tables[0].Columns[2].ColumnName = "Номинал";
            ds.Tables[0].Columns[3].ColumnName = "Курс";




            dataGridView1.DataSource = ds.Tables[0];


            
            DataSet DSC = (System.Data.DataSet)di.EnumValutes(false);
            System.Data.DataTable tb1 = DSC.Tables["EnumValutes"];

            dataGridView2.DataSource = tb1;
            
            label4.Text = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[3].Value.ToString();

        }
    }
}
