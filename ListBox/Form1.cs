using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> cars = new List<string>
            //{
            //    "Audi",
            //    "Ferrari",
            //    "Chevrolet",
            //    "Maserati"
            //};

            //listBox1.DataSource = cars;

            //listBox1.Items.Add("Audi");
            //listBox1.Items.Add("Mercedes");

           // listBox1.SelectionMode = SelectionMode.MultiExtended;
            //List<Car> cars = new List<Car>
            //{
            //    new Car
            //    {
            //        Id=1,
            //        Name="Mercedes"
            //    },
            //    new Car
            //    {
            //        Id=2,
            //        Name="Hyundai"
            //    },
            //    new Car
            //    {
            //        Id=3,
            //        Name="Chevrolet"
            //    },
            //};
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";
            //listBox1.DataSource = cars;
            listBox1.Items.Add(new Car
            {
                Name = "Chevrolet"
            });
            listBox1.Items.Add(new Car
            {
                Name = "Ferrari"
            });
            listBox1.Items.Add(new Car
            {
                Name = "Hyundai"
            });
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //List<string> fruits = new List<string>
            //{
            //    "Apple",
            //    "Mango",
            //    "Banana",
            //    "Magnolia"
            //};

            //listBox1.DataSource = fruits;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = listBox1.SelectedItem as Car;
            label1.Text = obj?.Name;

            try
            {
            listBox2.Items.Add(obj);
            listBox1.Items.Remove(obj);
            }
            catch (Exception)
            {
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var objects = listBox1.SelectedItems;
            StringBuilder stringBuilder = new StringBuilder();       
            foreach (var item in objects)
            {
                if(item is Car c)
                {
                    stringBuilder.Append($"{c.Name} \n");
                }
            }
            label1.Text = stringBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Car
            {
                Name = nameTxtb.Text
            });
        }
    }
}
