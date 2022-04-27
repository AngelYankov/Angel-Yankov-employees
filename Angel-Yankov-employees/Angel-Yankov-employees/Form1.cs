using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Angel_Yankov_employees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.Title = "Select file";

            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                LoadData(loadFile);
            }
        }

        private void LoadData(OpenFileDialog file)
        {
            List<WorkLog> records = new List<WorkLog>();

            using var streamReader = File.OpenText(file.FileName);

            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = true
            };

            try
            {
                using var csvReader = new CsvReader(streamReader, csvConfig);
                records = csvReader.GetRecords<WorkLog>().ToList();

                var projectGroups = records.GroupBy(r => r.ProjectID).Select(grp => grp.ToList()).ToList();

                foreach (var group in projectGroups)
                {
                    var maxTime = new TimeSpan();
                    var employee1 = 0;
                    var employee2 = 0;

                    for (int j = 0; j < group.Count; j++)
                    {
                        for (int i = j; i < group.Count - 1; i++)
                        {
                            var startDate = group[j].DateFrom <= group[i + 1].DateFrom ? group[i + 1].DateFrom : group[j].DateFrom;
                            var endDate = group[j].DateTo <= group[i + 1].DateTo ? group[j].DateTo : group[i + 1].DateTo;

                            if (endDate - startDate > maxTime)
                            {
                                maxTime = (TimeSpan)(endDate - startDate);
                                employee1 = group[j].EmpID;
                                employee2 = group[i + 1].EmpID;
                            }
                        }
                    }

                    var project = group[0].ProjectID;

                    if (employee1 != 0 && employee2 != 0)
                    {
                        var index = this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[index].Cells["Employee1"].Value = employee1;
                        this.dataGridView1.Rows[index].Cells["Employee2"].Value = employee2;
                        this.dataGridView1.Rows[index].Cells["ProjectID"].Value = project;
                        this.dataGridView1.Rows[index].Cells["DaysWorked"].Value = maxTime.Days;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File not in correct format or data missing!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }
    }
}
