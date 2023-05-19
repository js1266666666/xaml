﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MySql.Data.MySqlClient;

namespace _011_EIS
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string dept = ""; //부서
        string pos = ""; //직급
        string gender = ""; //성별
        string dateEnter = ""; //입사일
        string dateExit = ""; //퇴사일

        string connStr = "server=localhost; user id=root; password=0000; database=eis2_db";
        MySqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (rbMale.IsChecked == true) gender = "남성";
            else if (rbFemale.IsChecked == true) gender = "여성";

            if (dpEnter.SelectedDate != null) dateEnter = dpEnter.SelectedDate.Value.Date.ToShortDateString();
            if (dpExit.SelectedDate != null) dateExit = dpExit.SelectedDate.Value.Date.ToShortDateString();
            else dateExit = DateTime.MaxValue.ToShortDateString(); // 9999년 12월 31일

            dept = cbDept.Text;
            pos = cbPos.Text;

            //입력할 데이터 다 만듦
            conn.Open();

            string sql = string.Format("INSERT INTO eis_table (name, department, position, gender, date_enter, date_exit, contact, comment"
                + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", txtName.Text, dept, pos, gender, dateEnter, dateExit, txtContact.Text, txtCommnet.Text);

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("성공적으로 추가되었습니다.");
            }

            conn.Close();//Open, close 사이에 작업
        }
    }
}
