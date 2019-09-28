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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization; 

namespace Client_p_ver2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        [Serializable] //Obiekt jest serializowany do strumienia, niesie ze sobą nie tylko dane, 
                       //ale informacje o typie obiektu, takie jak jego nazwa wersji, kultury i zestawu.

        public class data //klasa przechowująca informacje zapisanie w tabeli 
        {
            public string imie;
            public string nazwisko;
            public string email;
        }
    

    private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GRID.EndEdit();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); //utworznie obiektu do zapisywania pliku
            saveFileDialog1.RestoreDirectory = true;//Okno dialogowe spowoduje przywrócenie bieżącego katalogu do poprzednio wybranego katalogu po zmianie 
            //katalogu podczas wyszukiwania plików. 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //jeśli okno wyświetli się poprawnie
            {
                BinaryFormatter formatter = new BinaryFormatter(); //obiekt formatowania do zapisu binarnego
                //Udostępnia strumień dla pliku, obsługuje synchroniczne i asynchroniczne operacje odczytu i zapisu.
                FileStream output = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                int n = GRID.RowCount; //odczytanie liczby wierszy
                data[] Osoba = new data[n - 1]; //utowrzenie tablicy klasy osoba

                //pętla odczytująca wartości pól w tabeli i przekazujaca je do tablicy 
                for (int i = 0; i < n - 1; i++)
                {
                    Osoba[i] = new data();
                    
                    Osoba[i].imie = GRID[0, i].Value.ToString();
                    Osoba[i].nazwisko = GRID[1, i].Value.ToString();
                    Osoba[i].email = GRID[2, i].Value.ToString();
                   
                }
                formatter.Serialize(output, Osoba); //serializajca wyjścia
                output.Close();//zamknięcie wyścia danych

            }
        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();//utworznie obiektu do otwierania pliku
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //jeśli okno wyświetli się poprawnie
            {
                BinaryFormatter reader = new BinaryFormatter(); //obiekt formatowania do odczytu binarnego
                //Udostępnia strumień dla pliku, obsługuje synchroniczne i asynchroniczne operacje odczytu i zapisu.
                FileStream input = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                data[] Osoba = (data[])reader.Deserialize(input);////utowrzenie tablicy klasy osoba
                GRID.Rows.Clear(); //czyszczenie dotychczasowych wpisów  w tabeli
                //pętla odczytująca wartości pól w pliku i przekazujaca je do tabeli
                for (int i = 0; i < Osoba.Length; i++)
                {
                    GRID.Rows.Add();
                    GRID[0, i].Value = Osoba[i].imie;
                    GRID[1, i].Value = Osoba[i].nazwisko;
                    GRID[2, i].Value = Osoba[i].email; 
                }
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();//zamknięcie okna
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
