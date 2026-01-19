using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormsApp1;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearAllTextBoxes()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            Employeecs emp1 = new Employeecs();
            emp1.ID = Convert.ToInt32(txtID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary= Convert.ToInt32(txtSalary.Text);

            //Binary Serialization Code Below
            FileStream fs = new FileStream(@"C:\Desktop\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, emp1);
            ClearAllTextBoxes();
            fs.Close();
            MessageBox.Show("Record Added");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employeecs emp1 = new Employeecs();
            emp1.ID = Convert.ToInt32(txtID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            FileStream fs = new FileStream(@"C:\Desktop\SOAPSerialize.soap",
                FileMode.OpenOrCreate, FileAccess.Write);

            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, emp1);

            fs.Close();
            ClearAllTextBoxes();
            MessageBox.Show("SOAP Serialization Done");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Desktop\XMLSerialize.xml",
                FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(Employeecs));
            Employeecs emp1 = (Employeecs)xs.Deserialize(fs);

            txtID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();

            fs.Close();
            MessageBox.Show("XML Deserialization Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employeecs emp1 = new Employeecs();
            emp1.ID = Convert.ToInt32(txtID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            FileStream fs = new FileStream(@"C:\Desktop\XMLSerialize.xml",
                FileMode.OpenOrCreate, FileAccess.Write);

            XmlSerializer xs = new XmlSerializer(typeof(Employeecs));
            xs.Serialize(fs, emp1);

            fs.Close();
            ClearAllTextBoxes();
            MessageBox.Show("XML Serialization Done");
        }


        private void btnDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Desktop\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf=new BinaryFormatter();
            Employeecs emp1 =(Employeecs)bf.Deserialize(fs);
            txtID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Desktop\SOAPSerialize.soap",
                FileMode.Open, FileAccess.Read);

            SoapFormatter sf = new SoapFormatter();
            Employeecs emp1 = (Employeecs)sf.Deserialize(fs);

            txtID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();

            fs.Close();
            MessageBox.Show("SOAP Deserialization Done");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
