using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //Przestrzen nazw obsługująca protokoły sieciowe
using System.Net.Mail; //Przestrzeń nazw zawiera klasy, które umożliwiają wysyłanie poczty elektronicznej do serwera Simple Mail Transfer Protocol w celu dostarczenia
using System.Net.Mime; //Przestrzeń nazw używana do reprezentowania nagłówków protokołu dynamicznej konfiguracji hosta

namespace Client_p_ver2
{
    public partial class Form1 : Form
    {   
        //pola przechowujące dane logowania do serwera
        static public String login;
        static public String haslo; 
        static public String serwer;      
        static public int port;
        static int x = 0; //kontrolka wiadomosci z załącznikiem

        static public String status; // pole statyczne informujące o stanie logowania

        public Form1()
        {
            InitializeComponent();
            textBoxZalacznik.Text = ""; //inicjalizazja pola pustym stringiem


        }

        private void Form1_Load(object sender, EventArgs e)
        {}
        
        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            try // kluazula try aby uniknąć błędnych danych wysyłania
            {
               //Sekccja danych połaczenie z serwerem
                SmtpClient client = new SmtpClient(serwer, port); //utworzenie obiektu klienta protokołu smtp,
                //przekazanie adresu serwera oraz portu nasłuchującego
                client.EnableSsl = true; //włącznie szyfrowania połaczenia 
                client.Timeout = 100000; //czas oczekiwanie na odpowiedź serwera
                client.DeliveryMethod = SmtpDeliveryMethod.Network; //określenie sposobu dostarczenia wiadomości email
                client.UseDefaultCredentials = false; //wyłacznie uwierzytelniania
                client.Credentials = new NetworkCredential(login, haslo); //przekazanie loginu i hasła do konta poczty email
               //Sekccja wiadomości email
                MailMessage msg = new MailMessage(); // utworzenie obiektu wiadomości
                msg.To.Add(textBoxDo.Text); //ustawienie adresata
                msg.From = new MailAddress(login); //przypisanie emaila jako nadawcy
                msg.Subject = textBoxTemat.Text;// ustawienie tematu wiadomości
                msg.Body = textBoxMsg.Text;//tresc wiadomosci email
                if (x == 1) // sprawdzenie czy przypisano załącznik
                {
                    Attachment data = new Attachment(textBoxZalacznik.Text);//przypisanie załączników do wiadomości
                    msg.Attachments.Add(data);
                }

                client.Send(msg); //wysłanie poprawnie skonfigurowanej wiadomości 
                MessageBox.Show("Wiadomość wysłano");// informacja o pomyślnym wysłaniu wiadomości
               
            }
            catch(Exception ex)
            {
              MessageBox.Show(ex.Message); // wyświetlenie informacji o występujących błędach
               
            }
        }

        private void zalogujToolStripMenuItem_Click(object sender, EventArgs e) //otwieranie formularza z danymi logowania do serwera
        {
            Form2 fLogowanie = new Form2();
            fLogowanie.Show();

        }

        private void button2_Click(object sender, EventArgs e) //zamykanie aplikacji
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        { 
        }

        private void buttonPrzegladaj_Click(object sender, EventArgs e) //okno otwierające dodawanie załączników do emaila
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                textBoxZalacznik.Text = ofd.FileName.ToString();
            }
            x = 1;//ustawienie wiadomosci z załącznikiem

        }

        private void button_Ks_Click(object sender, EventArgs e) //otwarcie okna kontaktów
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button1_Click(object sender, EventArgs e) //czyszczenie inoformacji w formularzu
        {
            textBoxDo.Text = "";
            textBoxMsg.Text = "";
            textBoxTemat.Text = "";
            textBoxZalacznik.Text = "";
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e) //wyczyszczenie danych do połączenia z serwerem
        {
            login = "";
            haslo = "";
            port = 0;
            serwer = "";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           
            if (status == "Zalogowano") //sprawdzenie statusu logowania
            {
                lstatus.Text = status;
                lstatus.ForeColor = System.Drawing.Color.Green; 
            }
        }
    }
}
