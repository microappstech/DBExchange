using DBE.Services.Services;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DBExchange
{
    public partial class DBExchange : Form
    {
        private LoadStructureDbName LoadStructureService;
        public List<string> DbsName;
        public List<string> TablesName;
        public List<string> SelectedTablesName;

        public Dictionary<int, string> MappedColumns;
        public List<Dictionary<int, string>> CheckedColumnsSrc;
        public List<Dictionary<int, string>> CheckedColumnsDest;
        public Dictionary<string, List<Dictionary<int, string>>> CheckedTableColumnsDest;
        public Dictionary<string, List<Dictionary<int, string>>> CheckedTableColumnsSrc;

        private string DatabaseName { get; set; }
        private string DatabaseNameDest { get; set; }
        public DBExchange()
        {
            InitializeComponent();
            if (CheckedTableColumnsSrc is null)
            {
                CheckedTableColumnsSrc = new Dictionary<string, List<Dictionary<int, string>>>();
            }
            if (CheckedTableColumnsDest is null)
            {
                CheckedTableColumnsDest = new Dictionary<string, List<Dictionary<int, string>>>();
            }
            DbsName = new List<string>();
            LoadStructureService = new LoadStructureDbName();
            lbCollumnsSrc.Visible = false;
            lbTablesSrc.Visible = false;
            MappedColumns = new Dictionary<int, string>();
            CheckedColumnsSrc = new List<Dictionary<int, string>>();
            CheckedColumnsDest = new List<Dictionary<int, string>>();
            ClearColumn_Btn.Visible = false;
            Clearn_Cb_Tables_Btn.Visible = false;
            nextBtn.Enabled = false;
            DGVResult.ForeColor = Color.Black;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var r = LoadStructureService.LoadDatabases();
            DbsName = r.ToList();
            CB_Databases.Items.AddRange(DbsName.ToArray());

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            CheckedColumnsSrc.Add(new Dictionary<int, string> { { lbCollumnsSrc.SelectedIndex, lbCollumnsSrc.SelectedItem.ToString() } });
            CheckedColumnsDest.Add(new Dictionary<int, string> { { List_Columns_dest.SelectedIndex, List_Columns_dest.SelectedItem.ToString() } });
            DGVResult.Rows.Clear();
            DGVResult.Columns.Clear();
            DGVResult.Columns.Add("TableSrc", $"Table Source ");
            DGVResult.Columns.Add("TableDest", "Table Dest");
            foreach (var (ISrc, IDest) in CheckedColumnsSrc.Zip(CheckedColumnsDest, (x, y) => (x, y)))
            {
                DGVResult.Rows.Add(ISrc.Values.FirstOrDefault(), IDest.Values.FirstOrDefault());
            }
            DGVResult.Visible = true;
            RemoveSelecetd();

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
            if (List_Tables_dest.SelectedItem is not null)
            {
                var Columns = LoadStructureService.LoadColumnsByTable(DatabaseNameDest, List_Tables_dest.SelectedItem.ToString());
                List<string> ListCheckedClsDest = CheckedColumnsDest.Select(chClsDest => chClsDest.Values.FirstOrDefault()).ToList();                
                List_Columns_dest.Items.AddRange(Columns.ToList().Where(clsdes=> !CheckedColumnsDest.Select(chClsDest => chClsDest.Values.FirstOrDefault()).ToList().Contains(clsdes)).ToArray());
            }
            List_Columns_dest.Visible = true;
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
            List_Tables_dest.Enabled = false;
            nextBtn.Enabled = true;
        }

        public void ResetLists()
        {
            lbTablesSrc.Enabled = true;
            lbCollumnsSrc.Enabled = true;
            List_Columns_dest.Enabled = true;
            List_Tables_dest.Enabled = true;

            List_Columns_dest.ClearSelected();
            List_Tables_dest.ClearSelected();
            lbTablesSrc.ClearSelected();
            lbCollumnsSrc.ClearSelected();
        }
        public void RemoveSelecetd()
        {
            if(lbCollumnsSrc.SelectedIndex != 0)
                lbCollumnsSrc.Items.RemoveAt(lbCollumnsSrc.SelectedIndex);
            if (List_Columns_dest.SelectedIndex > 0)
                List_Columns_dest.Items.RemoveAt(List_Columns_dest.SelectedIndex);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetLists();
            
        }

    }
}
