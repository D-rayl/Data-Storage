/*
 * Daryl Crosbie
 * ID: P453055
 * This program store a list of games, they can be add, edited, removed, written and read from Xml file
 * */
using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesLibrary
{
    public partial class VideoGamesLibrary : Form
    {
        ///Create a list for storing an manipulating a list of games
        List <MyGames> GameList = new List<MyGames>();


        /// <summary>
        /// When the progam starts it calls the Load method to get game list 
        /// from the saved file
        /// </summary>
        public VideoGamesLibrary() 
        {
            InitializeComponent();

            LoadFromFile();
        }

        /// <summary>
        ///  //Button that stores the user input as an object in a list
        ///Creates a new game object each time
        ///Checks to see if input boxes are empty before storing the data
        ///Checks if price is a double before converting and storing it
        ///Uses a foreach loop to check which radio button has been selected
        ///Checks if the game is a duplicate before adding to the list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool hasData = true;

            
            MyGames Game = new MyGames();

            double gamePrice;

            
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please enter the name of the Game");
                hasData = false;
                return;
            }
            Game.name = textBoxName.Text;

            if (String.IsNullOrEmpty(comboBoxPlatform.Text))
            {
                MessageBox.Show("Please select the Platform");
                hasData = false;
                return;
            }
            Game.platform = comboBoxPlatform.Text;

            if (String.IsNullOrEmpty(comboBoxGenre.Text))
            {
                MessageBox.Show("Please select the Genre");
                hasData = false;
                return;
            }
            Game.genre = comboBoxGenre.Text;

            if (String.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Please enter the Price");
                hasData = false;
                return;
            }
            if (!(double.TryParse(textBoxPrice.Text, out gamePrice))||(double.Parse(textBoxPrice.Text)<=0))
            {
                MessageBox.Show("Enter a valid price");
                return;
            }
            Game.price = gamePrice;

            if (String.IsNullOrEmpty(textBoxDeveloper.Text))
            {
                MessageBox.Show("Please enter the Developer");
                hasData = false;
                return;
            }
            Game.developer = textBoxDeveloper.Text;

            bool notChecked = true;
            foreach(RadioButton r in groupBoxRating.Controls)
            {
                if (r.Checked)
                {
                    Game.rating = r.Text;
                    notChecked = false;
                }
            }
            if (notChecked)
            {
                MessageBox.Show("Please select a rating");
                hasData = false;
                return;
            }

            bool duplicateFound = GameList.Exists(x => x.name == textBoxName.Text);

            if(hasData && !duplicateFound)
            {
                GameList.Add(Game);
                ResetDetails();
                DisplayRecords();
            }
        }
   
        /// <summary>
        /// Button that updates the details for a game in the list
        /// Calls the edit method, then the reset method to clear the input fields
        /// And then the display method, to show the updated list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            ResetDetails();
            DisplayRecords();
        }

        /// <summary>
        /// Button for deleting an entry
        /// Calls the delete method, followed by reset and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            ResetDetails();
            DisplayRecords();
        }

        /// <summary>
        /// Button for displaying, call the show details method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            GameList.Sort();
            ShowDetails();
        }

        /// <summary>
        /// Button for clearing the input fields
        /// Calls the reset method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetDetails();
        }

        /// <summary>
        /// Method for displaying the list of games
        /// Uses a foreach loop to iterate through the list
        /// </summary>
        public void DisplayRecords()
        {
            listGames.Items.Clear();

            foreach(var game in GameList)
            {
                listGames.Items.Add(game.name + " : " + game.platform +" : "+game.genre+" : "+game.price+" : "+game.developer+" : "+game.rating);
            }
        }

        /// <summary>
        /// Method for clearing the input fields
        /// </summary>
        private void ResetDetails()
        {
            textBoxName.Text = "";
            comboBoxPlatform.Text = "";
            comboBoxGenre.Text = "";
            textBoxPrice.Text = "";
            textBoxDeveloper.Text = "";
            foreach(RadioButton r in groupBoxRating.Controls)
            {
                if (r.Checked)
                {
                    r.Checked = false;
                }
            }
        }

        /// <summary>
        ///Button for saving the game entries
        ///Sorts the list first, the calls the save method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            GameList.Sort();
            Save();
        }

        /// <summary>
        /// Button for loading the game entries
        /// Calls the load method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        /// <summary>
        /// On closing the form, the user will be prompted to save 
        /// if user says yes, the list will be sorted first, then saved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoGamesLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to save the list?", "Video Games Library", MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes)
            {
                GameList.Sort();
                Save();
            }
            else if (dialog == DialogResult.Cancel) e.Cancel = true;
        }

        /// <summary>
        /// Method for writing the object list data to xml file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="objectToWrite"></param>
        /// <param name="append"></param>
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// Method for reading the object list data from xml file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);  
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        /// <summary>
        /// Method that loads the information from the specified path
        ///if path does not exist, create it
        ///Calls the read from file method and stores the data in the list
        ///Finally it calls display method
        /// </summary>
        public void LoadFromFile()
        {
            Boolean exists = true;
           // string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists("C:\\Temp"))
                Directory.CreateDirectory("C:\\Temp");
            if (!File.Exists("C:\\Temp\\MyGames.xml"))
            {
                File.Create("C:\\Temp\\MyGames.xml").Close();
                exists = false;
            }
            if (exists)
            {
                GameList = ReadFromXmlFile<List<MyGames>>("C:\\Temp\\MyGames.xml");
                DisplayRecords();
            }  
        }

        /// <summary>
        /// Click an game from the list and the show details method will be called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listGames_MouseClick(object sender, MouseEventArgs e)
        {
            ShowDetails();
        }

        /// <summary>
        /// Method that shows game details in the input fields
        /// Checks for a selcted item
        /// Converts the price to string
        /// Uses a foreach loop to check and mark the right radio button
        /// </summary>
        public void ShowDetails()
        {
            GameList.Sort();
            if (listGames.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a game from the list");
            }
            else
            {
                string curItem = listGames.SelectedItem.ToString();
                int indx = listGames.FindString(curItem);
                textBoxName.Text = GameList[indx].name;
                comboBoxPlatform.Text = GameList[indx].platform;
                comboBoxGenre.Text = GameList[indx].genre;
                textBoxPrice.Text = Convert.ToString(GameList[indx].price);
                textBoxDeveloper.Text = GameList[indx].developer;
                foreach (RadioButton r in groupBoxRating.Controls)
                {
                    if (r.Text == GameList[indx].rating)
                    {
                        r.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// Method for deleting an entry
        /// Checks an items been selected
        /// Uses the list removeAt method with the selected index
        /// </summary>
        public void Delete()
        {
            if (listGames.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the list");
            }
            else
            {
                string curItem = listGames.SelectedItem.ToString();
                int indx = listGames.FindString(curItem);
                GameList.RemoveAt(indx);
            }
        }

        /// <summary>
        /// /Method for editing and updating a games details
        /// Checks a game has been selected
        /// Converts price to double
        /// Uses a for each loop to check the marked radio button
        /// and asigns it the new rating
        /// </summary>
        public void Edit()
        {
            double gamePrice;
            if (listGames.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the list");
            }
            else
            {
                string curItem = listGames.SelectedItem.ToString();
                int indx = listGames.FindString(curItem);
               
                if (!(double.TryParse(textBoxPrice.Text, out gamePrice))||(double.Parse(textBoxPrice.Text)<=0))
                {
                    MessageBox.Show("Invalid price");
                    return;
                }
                else
                {
                    GameList[indx].price = Convert.ToDouble(textBoxPrice.Text);
                }
                GameList[indx].name = textBoxName.Text;
                GameList[indx].platform = comboBoxPlatform.Text;
                GameList[indx].genre = comboBoxGenre.Text;
                GameList[indx].developer = textBoxDeveloper.Text;
                foreach (RadioButton r in groupBoxRating.Controls)
                {
                    if (r.Checked)
                    {
                        GameList[indx].rating = r.Text;
                    }

                }
            }
        }

        /// <summary>
        /// Method to save the data
        /// Calls the Writer method for the list to the specified path
        /// Uses a message box to show user it has saved
        /// </summary>
        public void Save()
        {
            WriteToXmlFile<List<MyGames>>("C:\\Temp\\MyGames.xml", GameList);
            MessageBox.Show("Saved");
        }

    }
    /// <summary>
    /// Class for creating game entry objects with Xml format attributes
    /// </summary>
    public class MyGames : IComparable<MyGames>
    {
        [XmlElement("name")]
        public string name
        {
            get; set;
        }

        [XmlElement("platform")]
        public string platform
        {
            get; set;
        }

        [XmlElement("genre")]
        public string genre
        {
            get; set;
        }

        [XmlElement("price")]
        public double price
        {
            get; set;
        }

        [XmlElement("developer")]
        public string developer
        {
            get; set;
        }

        [XmlElement("rating")]
        public string rating
        {
            get; set;
        }

        public int CompareTo(MyGames other)
        {
            return this.name.CompareTo(other.name);
        }
    } 
}
