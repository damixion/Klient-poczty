using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_p_ver2
{
    public partial class Form2 : Form
    {
        //pola przechowujące dane logowania do serwera
        static public String l;
        static public String h;
        static public String s;
        static public int p;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            try// kluazula try aby uniknąć podania nie prawidłowych danych
            {
                //pobranie danych z formularza logowania
                l = textBoxLogin.Text;
                h = maskedTextBoxPass.Text;
                s = comboBox1.Text;
                p = int.Parse(textBox1.Text);
                //przekazanie danych połaczenie z serwerem do obiektu client 
                Form1.login = l;
                Form1.haslo = h;
                Form1.serwer = s;
                Form1.port = p;
                Form1.status = "Zalogowano";

                Close();

            }
            catch(Exception ex) // wyświetlenie informacji o występujących błędach
            {
                MessageBox.Show("Uzupełnij poprawnie wszystkie pola"); 
            }
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //funkcja otwierająca okno pomocy
        {
            Form3 fPomoc = new Form3();
            fPomoc.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
