using DBE.Services.Services;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DBExchange
{
    public partial class Form1 : Form
    {
        private LoadStructureDbName LoadStructureService;
        public List<string> DbsName;
        public List<string> TablesName;
        public List<string> SelectedTablesName;

        public Dictionary<string, int> MappedColumns;
        public Dictionary<string, int> CheckedColumnsSrc;
        public Dictionary<string, int> CheckedColumnsDest;
        private string DatabaseName { get; set; }
        private string DatabaseNameDest { get; set; }
        public Form1()
        {
            InitializeComponent();
            DbsName = new List<string>();
            LoadStructureService = new LoadStructureDbName();
            lbCollumnsSrc.Visible = false;
            lbTablesSrc.Visible = false;
            MappedColumns = new Dictionary<string, int>();
            CheckedColumnsSrc = new Dictionary<string, int>();
            CheckedColumnsDest = new Dictionary<string, int>();
            ClearColumn_Btn.Visible = false;
            Clearn_Cb_Tables_Btn.Visible = false;

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
            foreach (var r in lbTablesSrc.SelectedItems)
            {
                SelectedTablesName.Add(r.ToString());
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

        }

        private void CB_Databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDb = CB_Databases.SelectedItem;
            DatabaseName = selectedDb.ToString();
            TablesName = LoadStructureService.LoadTableByDbName(DatabaseName);
            lbTablesSrc.Visible = true;
            lbTablesSrc.Items.AddRange(TablesName.ToArray());
            Clearn_Cb_Tables_Btn.Visible = true;
        }

        private void CH_tables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_ListColumns_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void ClearColumn_Btn_Click(object sender, EventArgs e)
        {
            lbCollumnsSrc.Items.Clear();
            lbCollumnsSrc.Visible = false;
            lbTablesSrc.Enabled = true;
            lbTablesSrc.SelectedItems.Clear();
            ClearColumn_Btn.Visible = false;

        }

        private void CB_Database_Dest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedDbDest = CB_Database_Dest.SelectedItem;
            var Tables = LoadStructureService.LoadTableByDbName(SelectedDbDest.ToString());
            List_Tables_dest.Items.Clear();
            List_Tables_dest.Items.AddRange(Tables.ToArray());
            List_Tables_dest.Visible = true;
            DatabaseNameDest = SelectedDbDest.ToString();
            btnClearTableDest.Visible = true;
        }


        private void List_Tables_dest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Columns = LoadStructureService.LoadColumnsByTable(DatabaseNameDest, List_Tables_dest.SelectedItem.ToString());
            List_Columns_dest.Visible = true;
            List_Columns_dest.Items.AddRange(Columns.ToArray());
            btnClearColumnsDest.Visible = true;
            CB_Database_Dest.Enabled = false;
        }

        private void Clearn_Cb_Tables_Btn_Click(object sender, EventArgs e)
        {
            lbTablesSrc.Items.Clear();
            lbTablesSrc.Visible = false;
            Clearn_Cb_Tables_Btn.Visible = false;
            CB_Databases.Enabled = true;
            CB_Database_Dest.Enabled = true;
        }

        private void lbTablesSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Databases.Enabled = false;
            if (lbTablesSrc.SelectedItems.Count > 0)
            {
                lbCollumnsSrc.Visible = true;
                string SlectedTable = lbTablesSrc.SelectedItems?[0]?.ToString();
                var resullCl = LoadStructureService.LoadColumnsByTable(DatabaseName, SlectedTable);
                lbCollumnsSrc.Items.Clear();
                lbCollumnsSrc.Items.AddRange(resullCl.ToArray());
            }
            ClearColumn_Btn.Visible = true;

        }

        private void lbCollumnsSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTablesSrc.Enabled = false;
            var r = LoadStructureService.LoadDatabases();
            CB_Database_Dest.Items.AddRange(r.ToArray());
        }

        private void btnClearColumnsDest_Click(object sender, EventArgs e)
        {
            List_Columns_dest.Items.Clear();
            List_Columns_dest.Visible = false;
            btnClearColumnsDest.Visible = false;
            List_Tables_dest.Enabled = true;
        }

        private void btnClearTableDest_Click(object sender, EventArgs e)
        {

        }

        private void btnClearColumnsDest_Click_1(object sender, EventArgs e)
        {
            List_Columns_dest.Items.Clear();
            List_Columns_dest.Visible = false;
            btnClearColumnsDest.Visible = false;
            List_Tables_dest.Enabled = true;
        }

        private void btnClearTableDest_Click_1(object sender, EventArgs e)
        {
            List_Tables_dest.Items.Clear();
            List_Tables_dest.Visible = false;
            btnClearTableDest.Visible = false;
            CB_Database_Dest.Enabled = true;
        }

        private void List_Columns_dest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
