using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace DataBaseMySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd;
        MySqlDataAdapter dataAdapter;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            ToolTip tool1 = new ToolTip();
            ToolTip tool2 = new ToolTip();
            ToolTip tool3 = new ToolTip();
            ToolTip tool4 = new ToolTip();
            ToolTip tool5 = new ToolTip();
            ToolTip tool6 = new ToolTip();
            ToolTip tool7 = new ToolTip();
            ToolTip tool8 = new ToolTip();
            ToolTip tool9 = new ToolTip();
            ToolTip tool10 = new ToolTip();
            ToolTip tool11 = new ToolTip();
            ToolTip tool12 = new ToolTip();
            ToolTip tool13 = new ToolTip();
            ToolTip tool14 = new ToolTip();
            ToolTip tool15 = new ToolTip();

            tool1.SetToolTip(radioButton1, "select * from team");
            tool2.SetToolTip(radioButton2, "select * from statistics");
            tool3.SetToolTip(radioButton3, "select * from players");
            tool4.SetToolTip(titlesbutton, "select Name, Amount_of_Titles from Team where Amount_of_Titles > 0");
            tool5.SetToolTip(avgtitlesbutton, "select Name from Team where Amount_of_Titles > (select avg(Amount_of_Titles) as average from team)");
            tool6.SetToolTip(join1, "select team.Name as Name_of_Team, Head_Coach, PPG, players.Name as Name_of_Player, players.Position as Position from team join players on team.Name = players.Team where Position like '%Forward'");
            tool7.SetToolTip(joinorder, "select distinct team.PPG, players.Name from players join team on players.Team = team.Name group by PPG order by PPG desc");
            tool8.SetToolTip(countbutton, "select Team, count(Name) as Amount_of_Players, sum(Experience) as Sum_of_Experience from players group by Team");
            tool9.SetToolTip(experience, "select Name, Team, Experience from players where Experience > 8");
            tool10.SetToolTip(updatebutton, "update team set PPG = PPG + PPG/10 where State = 'California'");
            tool11.SetToolTip(alteradd, "alter table statistics add column Extra varchar(20) default 'Something'");
            tool12.SetToolTip(dropcolumn, "alter table statistics drop column Extra");
            tool13.SetToolTip(view, "create or replace view myview as select team.Name, PPG, Wins, Loss from team join statistics on team.Name = statistics.Name");
            tool14.SetToolTip(delete, "delete from players order by Experience limit 1");
            tool15.SetToolTip(dump, "make a dump of current dbase");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.team". При необходимости она может быть перемещена или удалена. 
            this.teamTableAdapter.Fill(this.testDataSet.team);
            dataGridView1.ReadOnly = true;

            try
            {
                conn.ConnectionString = "server=localhost;user id=root;database=test;persistsecurityinfo=True";
                conn.Open();
                MessageBox.Show("Connected to MySQL database.");
            }
            catch (Exception e1)
            {
                MessageBox.Show("Connection Failed due to " + e1.ToString());
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select * from team");
        }

        private void radioButton1_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void GetData(string selectCommand)
        {
            try
            {
                String Connection = "server=localhost;user id=root;database=test;persistsecurityinfo=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new MySqlDataAdapter(selectCommand, Connection);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                teamBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (MySqlException)
            {
                //MessageBox.Show("Error");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select * from statistics");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select * from players");
        }

        private void titlesbutton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select Name, Amount_of_Titles from Team where Amount_of_Titles > 0");
        }

        private void avgtitlesbutton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select Name from Team where Amount_of_Titles > (select avg(Amount_of_Titles) as average from team)");
        }

        private void join1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select team.Name as Name_of_Team, Head_Coach, PPG, players.Name as Name_of_Player, players.Position as Position from team join players on team.Name = players.Team where Position like '%Forward'");
        }

        private void joinorder_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select distinct team.PPG, players.Name from players join team on players.Team = team.Name group by PPG order by PPG desc");
        }

        private void countbutton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select Team, count(Name) as Amount_of_Players, sum(Experience) as Sum_of_Experience from players group by Team");
        }

        private void experience_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("select Name, Team, Experience from players where Experience > 8");
        }

        private void updatebutton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("update team set PPG = PPG + PPG/10 where State = 'California'");
        }

        private void alteradd_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("alter table statistics add column Extra varchar(20) default 'Something'");
        }

        private void dropcolumn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("alter table statistics drop column Extra");
        }

        private void view_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("create or replace view myview as select team.Name, PPG, Wins, Loss from team join statistics on team.Name = statistics.Name; select * from myview");
        }

        private void delete_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamBindingSource;
            GetData("delete from players order by Experience limit 1");
        }

        private void dump_CheckedChanged(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=test;persistsecurityinfo=True";
            string file = "D:\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                        MessageBox.Show("BackUp successfully created.");
                    }
                }
            }
        }

    }
}
