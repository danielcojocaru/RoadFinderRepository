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

namespace RoadFinder
{
    public partial class FormRoadFinder : Form
    {
        public EngineNods engineNods { get; set; }

        public FormRoadFinder()
        {
            InitializeComponent();
        }

        #region Private Methods

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string filePath = GetTheFilesPath();
            if (filePath != null)
            {
                CreateEngineCitiesList(filePath);
                DeleteExistingItemsInComboboxes();
                CompleteComboBoxesAndSetSelectedItem();
            }
        }

        private void DeleteExistingItemsInComboboxes()
        {
            cbxFrom.Items.Clear();
            cbxTo.Items.Clear();
        }

        private void CompleteComboBoxesAndSetSelectedItem()
        {
            foreach (City currentCity in engineNods.CitiesList)
            {
                string cityName = GetUpperName(currentCity.Name);
                cbxFrom.Items.Add(cityName);
            }

            cbxFrom.SelectedIndex = 0;
            cbxTo.Text = "";
        }

        private string GetUpperName(string name)
        {
            string[] names = name.Split(' ');
            string city = "";
            foreach (string currentName in names)
            {
                city = city + currentName.First().ToString().ToUpper() + String.Join("", currentName.Skip(1)) + " ";
            }

            city = city.Remove(city.Length - 1);
            return city;
        }

        private void CreateEngineCitiesList(string filePath)
        {
            if (filePath != null)
            {
                this.engineNods = new EngineNods(filePath);
            }
        }

        private string GetTheFilesPath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = @"C:\Users\DanielCo\Documents\Visual Studio 2015\Projects\RoadFinder\Files";
            ofd.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            return null;
        }

        private void cbxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            object lastSelectedItem = cbxTo.SelectedItem;

            RenewCbxToItems();     // delets the currently selected item at cbxFrom and add the missing one from the last search

            SetCbxToSelectedItem(lastSelectedItem);
        }

        private void SetCbxToSelectedItem(object lastSelectedItem)
        {
            if (lastSelectedItem != cbxFrom.SelectedItem)
            {
                cbxTo.SelectedItem = lastSelectedItem;
            }
            else if (cbxFrom.SelectedIndex != 0)
            {
                cbxTo.SelectedIndex = 0;
            }
            else
            {
                cbxTo.SelectedIndex = 1;
            }
        }

        private void RenewCbxToItems()
        {
            cbxTo.Items.Clear();

            foreach (string item in cbxFrom.Items)
            {
                cbxTo.Items.Add(item);
            }

            cbxTo.Items.RemoveAt(cbxFrom.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxFrom.SelectedItem != null && cbxTo.SelectedItem != null)
            {
                this.engineNods.FindTheBestRoad(cbxFrom.SelectedItem.ToString().ToLower(), cbxTo.SelectedItem.ToString().ToLower());
                ChangeListView();
            }
        }

        private void ChangeListView()
        {
            List<ListView> lviewList = new List<ListView>();
            lviewList.Add(lviewFirst);
            lviewList.Add(lviewSecond);
            lviewList.Add(lviewThird);

            ClearOldItems(lviewList);
            int numberOfSolutionsToBePrinted = SetNumberOfSolutionsToBePrinted();
            PrintListViews(lviewList, numberOfSolutionsToBePrinted);
        }

        private void PrintListViews(List<ListView> lviewList, int numberOfSolutionsToBePrinted)
        {
            for (int i = 0; i < numberOfSolutionsToBePrinted; i++)
            {
                foreach (Neighbor currentNeighbor in this.engineNods.Roads[i])
                {
                    string city = GetUpperName(currentNeighbor.Name);
                    ListViewItem lvi = new ListViewItem(city);
                    lviewList[i].Items.Add(lvi);
                }

                ListViewItem lviDistance = new ListViewItem(string.Format("Distance = {0}km", this.engineNods.Roads[i][0].Distance));
                lviewList[i].Items.Add("▃▃▃▃▃▃▃▃▃▃▃▃▃");
                lviewList[i].Items.Add(lviDistance);
            }
        }

        private int SetNumberOfSolutionsToBePrinted()
        {
            int numberOfSolutions = this.engineNods.Roads.Count;
            int numberOfSolutionsToBePrinted = Math.Min(numberOfSolutions, 3);
            return numberOfSolutionsToBePrinted;
        }

        private void ClearOldItems(List<ListView> lviewList)
        {
            for (int i = 0; i < 3; i++)
            {
                lviewList[i].Items.Clear();
            }
        }

        #endregion Private Methods
    }
}
