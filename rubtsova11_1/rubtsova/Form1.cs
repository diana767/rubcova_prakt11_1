using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rubtsova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Treygolinic
        {
            public double a;
            public double b;
            public double c;
            public double h;
            
           
            public double S()
            {
                //Используем формулу Герона
                double p = (a + b + c) / 2;
                double S=Math.Round( Math.Sqrt(p * (p - a) * (p - b) * (p - c)),1);
                return S;
            }
            public double P()
            {
                double P = a + b + c;
                    return P;
            }
            public double M()
            {
                double M = Math.Round((a + b + c) / 3 ,1); 
                return M;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Treygolinic tg = new Treygolinic();
           tg.a = (double)(numericUpDown1.Value);
            tg.b = (double)(numericUpDown2.Value);
            tg.c = (double)(numericUpDown3.Value);
            if (tg.a + tg.b < tg.c) MessageBox.Show(string.Format("треугольник не может существовать, введите правильные данныe"));
            else
                MessageBox.Show(string.Format("Треугольник:\nсторона а: {0}\nсторона b: {1}\nсторона c: {2}\n Площадь треугольника {3}\nПериметр реугольника {4}\nточка пересечения медиан : {5} ", tg.a, tg.b, tg.c, tg.S(), tg.P(), tg.M()));
        }
    }
}
