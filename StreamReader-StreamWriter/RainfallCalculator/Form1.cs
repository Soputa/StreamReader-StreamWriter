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


namespace RainfallCalculator
{
   
    public partial class Rainfall_Calculator : Form
    {
        
        protected int TextBoxCount { get; set; } = 5;

            public enum TextBoxIndices { Valid,TotalRows,Highest,Lowest,Average}
        const string folderPath = @"C:\test\rainfall.txt";
        string rainNew = @"C:\Users\SirOp\Desktop\test\rainfall2.txt";
        //Querry files in the given directory
        //string[] listOfFiles = Directory.GetFiles(folderPath);

        //reads data from our rainfall txt file
       
        private const string RainFallSenValue = "0.474452";

        private List<double> RainfallData { get; set; }
        public Rainfall_Calculator()
        {
            InitializeComponent();

            //Clear textboxes
            textBoxHighestValue.Text = "";
            textBoxLowestValue.Text = ""; 
            textBoxAverageRainfall.Text ="";
            textBoxValidRows.Text = "";
            textBoxTotalRows.Text = "";
            buttonSaveFile.Enabled = false;
            //Craeate RainfallData list
            RainfallData = new List<double>();
            
        }

        public void ClearTextBoxes()
        {
            //iterate through every Control on form and clears it
            foreach(Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
                
        }

        /* public void SetTextBoxValues(string[] values)
         {
             if(values.Length !=TextBoxCount)
             {
                 throw (new ArgumentException($"There must be {TextBoxCount} strings in the array", nameof(values)));
             }
             else //array values at 5 
             {
                 //set the array values
                 textBoxValidRows.Text = values[(int) TextBoxIndices.Valid];
                 textBoxTotalRows.Text = values[(int)TextBoxIndices.TotalRows];
                 textBoxHighestValue.Text = values[(int)TextBoxIndices.Highest];
                 textBoxLowestValue.Text = values[(int)TextBoxIndices.Lowest];
                 textBoxAverageRainfall.Text = values[(int)TextBoxIndices.Average];

             }

         }

         //return TextBox values as string array
         public string[] GetTextBoxValues()
         {
             return new string[] {

                 textBoxValidRows.Text,textBoxTotalRows.Text,textBoxHighestValue.Text,textBoxLowestValue.Text,textBoxAverageRainfall.Text}; 

         }
        */
        //public long CountLinesLINQ(FileInfo )
        
       
        private void buttonImport_Click(object sender, EventArgs e)
        {
            //Create & show a dialog box enabling user to import their file
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // get the file name(rainfall.txt)
               
            }

            //IF yes
            if(result == DialogResult.OK)
            {
                ClearTextBoxes();

                //error if file selected is invalid
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Please Select rainfall.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   

                    try
                    {
                        FileStream inputfile = File.Open(fileName, FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(inputfile);
                        string latestLine = "";
                        RainfallData.Clear();
                        int totalLinesProcessed = 0;

                        //Keep looping until we reach the sentinel
                        while ((!reader.EndOfStream) && (latestLine != RainFallSenValue))
                        {
                            //Read next line of file
                            latestLine = reader.ReadLine();
                            //Count it if it's not sentinel value
                            if (latestLine != RainFallSenValue)
                            {
                                totalLinesProcessed++;
                            }

                            if (IsGoodRainfall(latestLine, out double rainfallValue))
                                RainfallData.Add(rainfallValue);
                        }
                            //Close up the streams
                            reader.Close();
                            inputfile.Close();

                            
                            

                            //Largest number
                            textBoxHighestValue.Text = $"{RainfallData.Max():n0}";
                            //smallest number
                            textBoxLowestValue.Text = $"{RainfallData.Min():n0}";
                            //Avarage of all rows
                            textBoxAverageRainfall.Text = $"{RainfallData.Average():n0}";
                            //Count of all rows
                            textBoxValidRows.Text = $"{RainfallData.Count():n0}";
                            //Valid Rows
                            textBoxTotalRows.Text = $"{totalLinesProcessed:n0}";

                            buttonSaveFile.Enabled = true;

                        
                    }
                    catch (IOException)
                        {
                        MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }


        }
        
        private bool IsGoodRainfall(string inputLine, out double numericValue)
        {
            bool retValue;
        double numericCandidate =-1;

        if (inputLine == RainFallSenValue)
            retValue = false;
        else if (!double.TryParse(inputLine, out numericCandidate))
            retValue = false;
        else if (numericCandidate < 0.1)
            retValue = false;
        else
            retValue = true; //All good pass

        numericValue = numericCandidate;
        return retValue;

        }

        private void Rainfall_Calculator_Load(object sender, EventArgs e)
        {
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Exit the application", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {   
            
            bool moveAhead = true;
          //CHeck to see if the output file exist 
          //see if the user is ok to overwrite it
            if(File.Exists(rainNew))
            {
                moveAhead = (MessageBox.Show("The outputFile exist. Overwrite it?", "Are you sure you want to Overwrite the FIle?", MessageBoxButtons.YesNo) == DialogResult.Yes);
            }

            if(moveAhead)
            {
                
                //DialogResult result1;
                //fileName = fileChooser.FileName;

               
                try
                {

                    //Save the good rows to the file 
                    //I tried a few ways but, unable to save the file 
                    FileStream outFile = File.Open(rainNew, FileMode. Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(outFile);
                   
                    
                        //Loop through all of the good rows in the list
                        foreach (double rainfallValue in RainfallData)
                            writer.WriteLine($"{rainfallValue:n8}");

                        //Tiddy up close streams
                        writer.Close();
                        outFile.Close();
                    
                }

                catch(IOException)
                {

                    MessageBox.Show("Error saving the file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            MessageBox.Show("Nice!: The valid rows have been written to the output file.");

        }

    }    
    }

                                                                                                                                                                                                              