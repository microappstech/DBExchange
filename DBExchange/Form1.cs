using DBE.Services.Services;
using System.Runtime.CompilerServices;

namespace DBExchange
{
    public partial class Form1 : Form
    {
        private LoadStructureDbName LoadStructureService;
        public List<string> DbsName;
        public List<string> TablesName;
        public Form1()
        {
            InitializeComponent();
            DbsName = new List<string>();
            LoadStructureService = new LoadStructureDbName();
            LoadBtn.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var r = LoadStructureService.LoadDatabases();
            DbsName = r.ToList();
            CB_Databases.Items.AddRange(DbsName.ToArray());

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            var selectedDb = CB_Databases.SelectedItem;
            TablesName = LoadStructureService.LoadTableByDbName(selectedDb.ToString());
            CH_tables.Visible = true;
            CH_tables.Items.AddRange(TablesName.ToArray());
        }

        private void CB_Databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBtn.Visible = true;
        }
    }
}
