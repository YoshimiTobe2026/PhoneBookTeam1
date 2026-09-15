using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneBookTeam1
{
    public partial class Form1 : Form
    {
        List<PhoneData> phoneBook;
        public Form1()
        {
            InitializeComponent();
            phoneBook = new List<PhoneData>();
            ReadFromFile();
            foreach (PhoneData data in phoneBook)
            {
                nameList.Items.Add(data.Name);
            }
        }

        private void ReadFromFile()
        {
            string filePath = Path.Combine(Application.StartupPath, "data.txt");
            using (StreamReader file = new StreamReader(filePath))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    string[] data = line.Split(',');
                    PhoneData phone = new PhoneData();
                    phone.Name = data[0];
                    phone.PhoneNumber = data[1];
                    phoneBook.Add(phone);
                }
            }
        }

        private void nameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = nameList.Text;
            foreach (PhoneData data in phoneBook)
            {
                if (data.Name == name)
                {
                    phoneNumber.Text = data.PhoneNumber;
                    break;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyword = searchBox.Text.Trim();
            nameList.Items.Clear();
            foreach (PhoneData data in phoneBook)
            {
                if (data.Name.Contains(keyword))
                {
                    nameList.Items.Add(data.Name);
                }
            }
        }


        private void labelTel_DoubleClick(object sender, EventArgs e)
        {
            var num = 99999999999;
            labelTel.Text = num.ToString();
        }
    }
}