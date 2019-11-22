using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Elements
{
    public class ElementsManager
    {
        private BindingList<Elements> elements;
        private int numberOfElements = 0;
        public BindingList<Elements> ListElements
        {
            get { return elements; }
            set { elements = value; }
        }
        public int Number
        {
            get { return numberOfElements; }
            set { numberOfElements = value; }
        }

        public ElementsManager()
        {
            ListElements = new BindingList<Elements>();
        }

        public void Add(Elements anElement)
        {
            try
            {
                for (int i = 0; i < Number; i++)
                {
                    if (ListElements[i] == anElement)
                    {
                        throw new Exception($"Error: Element {anElement.Name} already exists in elements-list");
                    }
                }
                ListElements.Add(anElement);
                Number++;
            }
            catch { }
        }

        public void Load(string fileName, string delimiter)
        {
            FileStream inFile = null;
            StreamReader reader = null;
            char DELIM = Convert.ToChar(delimiter);
            int atmNum;
            string eleName;
            string eleDesc;
            string eleSym;

            string[] fields;

            try
            {
                inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                string recordIn = reader.ReadLine();
                while (recordIn != null)
                {
                    try
                    {
                        fields = recordIn.Split(DELIM);
                        try
                        {
                            //check for mandatory fields
                            if (fields[0] == "" || (!int.TryParse(fields[0], out int check)))
                            {
                                throw new Exception("Invalid element number: ");
                            }

                            if (fields[1] == "")
                            {
                                throw new Exception("No Element symbol provided: ");
                            }

                            if (fields[2] == "")
                            {
                                throw new Exception("No Element Name provided: ");
                            }

                            if (fields[3] == "")
                            {
                                throw new Exception("No Element Description provided: ");
                            }
                        }
                        catch
                        {
                            throw;
                        }

                        if (int.TryParse(fields[0], out int eleNum))
                        {
                            for (int i = 0; i < Number; i++)
                            {
                                if (eleNum == ListElements[i].AtomicNum)
                                {
                                    throw new Exception("Tried to add an element that already exists: ");
                                }
                            }
                        }
                        //set params for new element
                        atmNum = int.Parse(fields[0]);
                        eleSym = fields[1];
                        eleName = fields[2];
                        eleDesc = fields[3];                        

                        //create new element
                        Elements anElement = new Elements(atmNum, eleSym, eleName, eleDesc);
                        Add(anElement);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message} \n\t{recordIn}");
                    }
                    recordIn = reader.ReadLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (inFile != null)
                {
                    inFile.Close();
                }
            }
        }

        public void Save(string fileName, BindingList<Elements> list)
        {
            try
            {
                //Using JSON.net library to convert list object to JSON
                File.WriteAllText(fileName, JsonConvert.SerializeObject(list));
            }
            catch
            {
                throw new Exception("Error: Unable to Create Out file");
            }
        }        
    }
}
