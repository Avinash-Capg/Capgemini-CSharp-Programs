using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinReflectionDemo
{
    public partial class Form1 : Form
    {
        private object fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;

            Assembly assemblyObj = Assembly.LoadFrom(filePath);

            Type[] myType = assemblyObj.GetTypes();
            this.ReflectAll(myType[0]);
            //Form1.ReflectAll(myType[0]);
            //Type typeObj = typeof(Employee);
            //ReflectAll(typeObj);



        }
        public void ReflectAll(Type typeObj)
        {
            // Getting all methods
            MethodInfo[] methodList = typeObj.GetMethods();  

            // Getting all properties
            PropertyInfo[] propList = typeObj.GetProperties();

            // Load all properties
            foreach (var item in propList)
            {
                listBox1.Items.Add(item.Name);  
            }

            // Load all methods
            foreach (var item in methodList)
            {
                listBox2.Items.Add(item.Name);  
            }
        }
    }
}
