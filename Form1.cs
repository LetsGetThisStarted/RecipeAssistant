using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;


namespace RecipeAssistant
{
    public partial class Form1 : Form
    {

        public string recipeFilePath;
        public string recipeListFilePath;
        public string folderFilePath;

        public Form1()
        {
            InitializeComponent();
            FormSetup();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Pull information from outside resources to fill fields in the form.
        private void FormSetup()
        {
            GetRecipeFilePath();
            updateRecipeList(recipeListFilePath);
        }

        private void updateRecipeList(string fileName)
        {
            StreamReader reading = File.OpenText(fileName);
            string str;
            while ((str = reading.ReadLine())!=null)
            {
                if (1==1)
                {
                    // comboBox1.Items.Add(str);
                }
            }
        }

        string[] ReadAllResourceLines(string resourceText)
        {
            using (StringReader reader = new StringReader(resourceText))
            {
                List<string> lines = new List<string>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                return lines.ToArray();
            }
        }

        public string GetRecipeFilePath()
        {
            // TODO - Find a way to automatically get the file path for RecipeList.txt
            //      - OR allow the user to provide the file/filepath
            folderFilePath = @"C:\Users\Franklin_PC\Documents\Recipe List\";
            recipeListFilePath = Path.Combine(folderFilePath, "RecipeList.txt");
            return folderFilePath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Qty.Text))
            {
                listBox_Recipe.Items.Add(textBox_Qty.Text + " - " +textBox_Ingredient.Text);

            }
            else
            {
                listBox_Recipe.Items.Add("     " + textBox_Ingredient.Text);
            }
        }

        private void button_RemoveIngredient_Click(object sender, EventArgs e)
        {
            if (listBox_Recipe.SelectedItems.Count > 0)
            {
                listBox_Recipe.Items.RemoveAt(this.listBox_Recipe.SelectedIndex);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            // TODO - Make sure textboxes have correct values

            recipeFilePath = folderFilePath + textBox_Recipe.Text + ".txt";

            File.WriteAllText(recipeFilePath, String.Empty);
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(recipeFilePath);
      
            foreach (var item in listBox_Recipe.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
        }

        private void button_LoadRecipe_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = folderFilePath;
            openFileDialog1.Filter = "Text|*.txt|All|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                recipeFilePath = openFileDialog1.FileName;
                LoadRecipe(recipeFilePath);
            }
        }

        private void LoadRecipe(string filePath)
        {
            // TODO - Extract recipe name from file path
            int pFrom = filePath.LastIndexOf(@"\") + 1;
            int pTo = filePath.LastIndexOf(".txt");
            String recipe = filePath.Substring(pFrom, pTo - pFrom);

            // Clear previous recipe info
            listBox_Recipe.Items.Clear();
            textBox_Recipe.Clear();
            textBox_Qty.Clear();
            textBox_Ingredient.Clear();
            
            // Read .txt file, loading each line into the list box
            string[] lines = System.IO.File.ReadAllLines(filePath);
            listBox_Recipe.Items.AddRange(lines);
            // MessageBox.Show("Mission Success: " + filePath);
            textBox_Recipe.Text = recipe;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
