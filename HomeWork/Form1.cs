using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace HomeWork
{
    public partial class MainForm : Form
    {
        public DataIO.DataIO Trains = new DataIO.DataIO ();
        SortedSet<string> InvalidTextBoxes = new SortedSet<string> ();

        const string COLUMN_ID = "id";
        const string COLUMN_TYPE = "type";
        const string COLUMN_MODEL = "model";
        const string COLUMN_CREATE = "create";
        const string COLUMN_REPAIR = "repair";

        public enum SearchMode
        {
            Contains,
            Equals
        }

        public MainForm ()
        {
            InitializeComponent ();
        }

        void menuFileCreate_Click (object sender, EventArgs e)
        {
            MenuFileCreate ();
        }

        void menuFileOpen_Click (object sender, EventArgs e)
        {
            MenuFileOpen ();
        }

        void menuFileSave_Click (object sender, EventArgs e)
        {
            MenuFileSave ();
        }

        void buttonCreate_Click (object sender, EventArgs e)
        {
            MenuFileCreate ();
        }

        void buttonOpen_Click (object sender, EventArgs e)
        {
            MenuFileOpen ();
        }

        void menuFileSaveAs_Click (object sender, EventArgs e)
        {
            MenuFileSaveAs ();
        }

        void menuFileExit_Click (object sender, EventArgs e)
        {
            Application.Exit ();
        }

        void buttonSave_Click (object sender, EventArgs e)
        {
            MenuFileSave ();
        }

        void eventFormShown (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (IOManager.FileName))
            {
                MenuFileOpen ();
            }
            else
            {
                OpenFile ();
            }
        }

        void dataGridView_SortCompare (
            object sender,
            DataGridViewSortCompareEventArgs e
        )
        {
            if (e.CellValue1 == null || e.CellValue2 == null)
            {
                if (e.CellValue1 == null && e.CellValue2 == null)
                    e.SortResult = 0;
                else if (e.CellValue1 == null)
                    e.SortResult = 1;
                else if (e.CellValue2 == null)
                    e.SortResult = -1;

                e.Handled = true;
                return;
            }

            if (e.Column.Name == COLUMN_CREATE ||
                e.Column.Name == COLUMN_REPAIR)
            {
                var dateA = DateTime.ParseExact (e.CellValue1.ToString (),
                                                 "dd.MM.yyyy",
                                                 null);
                var dateB = DateTime.ParseExact (e.CellValue2.ToString (),
                                                 "dd.MM.yyyy",
                                                 null);

                e.SortResult = dateA.CompareTo (dateB);
            }
            else
            {
                e.SortResult = string.Compare (e.CellValue1.ToString (),
                                               e.CellValue2.ToString ());
            }

            if (e.SortResult == 0)
            {
                int a = int.Parse (GetValueFromCell (dataGridView1.Rows[e.RowIndex1].Cells[COLUMN_ID]));
                int b = int.Parse (GetValueFromCell (dataGridView1.Rows[e.RowIndex2].Cells[COLUMN_ID]));

                e.SortResult = a.CompareTo (b);
            }

            e.Handled = true;
        }

        void dataGridView_SelectionChanged (object sender, EventArgs e)
        {
            richTextBoxId.Text = GetCommonPropertyFromAllSelectedRows (COLUMN_ID);
            richTextBoxType.Text = GetCommonPropertyFromAllSelectedRows (COLUMN_TYPE);
            richTextBoxModel.Text = GetCommonPropertyFromAllSelectedRows (COLUMN_MODEL);
            richTextBoxCreate.Text = GetCommonPropertyFromAllSelectedRows (COLUMN_CREATE);
            richTextBoxRepair.Text = GetCommonPropertyFromAllSelectedRows (COLUMN_REPAIR);

            UpdateYandexLink ();

            switch (dataGridView1.SelectedRows.Count)
            {
                case 0:
                    //buttonRemoveRow.Enabled = false;
                    break;
                case 1:
                    buttonRemoveRow.Enabled = true;
                    buttonRemoveRow.Text = "Удалить запись";
                    break;
                default:
                    buttonRemoveRow.Enabled = true;
                    buttonRemoveRow.Text = "Удалить записи";
                    break;
            }
        }

        void linkLabelInternet_LinkClicked (
            object sender,
            LinkLabelLinkClickedEventArgs e
        )
        {
            try
            {
                linkLabelInternet.Links[linkLabelInternet.Links.IndexOf (e.Link)].Visited = true;
                System.Diagnostics.Process.Start (linkLabelInternet.Text);
            }
            catch
            {
            }
        }

        void buttonAddRow_Click (object sender, EventArgs e)
        {
            dataGridView1.Rows.Add (1);
        }

        void buttonSaveChanges_Click (object sender, EventArgs e)
        {
            SaveChangesInSelectedRows (COLUMN_ID, richTextBoxId.Text);
            SaveChangesInSelectedRows (COLUMN_TYPE, richTextBoxType.Text);
            SaveChangesInSelectedRows (COLUMN_MODEL, richTextBoxModel.Text);
            SaveChangesInSelectedRows (COLUMN_CREATE, richTextBoxCreate.Text);
            SaveChangesInSelectedRows (COLUMN_REPAIR, richTextBoxRepair.Text);

            SaveDataToTrains ();
        }

        void richTextBoxType_TextChanged (object sender, EventArgs e)
        {
            UpdateYandexLink ();
        }

        void richTextBoxModel_TextChanged (object sender, EventArgs e)
        {
            UpdateYandexLink ();
        }

        void buttonRemoveRow_Click (object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            string caption = "Удаление " + (count == 1 ? "записи" : "записей");
            string message = "Вы уверены, что хотите удалить " + (count == 1 ? "запись" : "записи") + "?\n";
            message += "Удаленные данные нельзя будет вернуть!";

            var res = MessageBox.Show (message,
                                       caption,
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning,
                                       MessageBoxDefaultButton.Button1);

            if (res == DialogResult.Yes)
            {
                var arr = new DataGridViewRow[count];

                dataGridView1.SelectedRows.CopyTo (arr, 0);

                foreach (DataGridViewRow row in arr)
                    dataGridView1.Rows.Remove (row);
            }
        }

        void checkBox2_CheckedChanged (object sender, EventArgs e)
        {
            var set = new SortedSet<int> ();

            if (checkBoxOldRepaired.CheckState == CheckState.Checked)
            {
                var items = Trains.OldRepairedTrains ();

                foreach (var item in items)
                    set.Add (item.Id);
            }

            if (checkBoxMostPopular.CheckState == CheckState.Checked)
            {
                var items = Trains.GetPopularModels ();

                foreach (var item in items)
                    set.Add (item.Id);
            }

            if (checkBoxPopularYears.CheckState == CheckState.Checked)
            {
                var items = Trains.GetMostPopularYears ();

                foreach (var item in items)
                    set.Add (item.Id);
            }

            var columnCheckBox = (DataGridViewCheckBoxColumn)dataGridView1.Columns[0];


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int value;

                if (int.TryParse (GetValueFromCell (dataGridView1.Rows[i].Cells[COLUMN_ID]),
                                  out value))
                    dataGridView1.Rows[i].Cells[0].Value = set.Contains (value);
            }

            if (set.Count > 0)
                dataGridView1.Sort (dataGridView1.Columns[0],
                                    System.ComponentModel.ListSortDirection.Descending);
            else
                dataGridView1.Sort (dataGridView1.Columns[1],
                                    System.ComponentModel.ListSortDirection.Ascending);
        }

        void textBoxSearch_TextChanged (object sender, EventArgs e)
        {
            textBoxSearch.BackColor = SystemColors.Window;

            if (textBoxSearch.TextLength == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    dataGridView1.Rows[i].Selected = false;

                errorProvider1.SetError (textBoxSearch, "");

                return;
            }

            string text = textBoxSearch.Text;
            int eqIndex = text.IndexOf ('=');

            string[] allColumns = {
                COLUMN_ID,
                COLUMN_TYPE,
                COLUMN_MODEL,
                COLUMN_CREATE,
                COLUMN_REPAIR
            };

            if (eqIndex < 0)
            {
                var mode = SearchMode.Contains;

                if (text[0] == '$')
                {
                    text = text.Remove (0, 1);
                    mode = SearchMode.Equals;
                }

                SelectAllRightRows (text, allColumns, mode);
            }
            else
            {
                string column = text.Substring (0, eqIndex).Trim ();
                text = text.Substring (eqIndex + 1, text.Length - eqIndex - 1).Trim ();
                var mode = SearchMode.Contains;

                if (IsValidColumnName (column))
                {
                    if (string.IsNullOrEmpty (text))
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            dataGridView1.Rows[i].Selected = false;
                    }
                    else
                    {
                        if (text[0] == '$')
                        {
                            text = text.Remove (0, 1);
                            mode = SearchMode.Equals;
                        }

                        SelectAllRightRows (text, new[] { column }, mode);
                    }
                }
                else
                {
                    textBoxSearch.BackColor = Color.Red;

                    errorProvider1.SetError (textBoxSearch, "Неправильное название столбца\n" +
                    "Можно использовать: id, type, model, create, repair");

                    return;
                }

                errorProvider1.SetError (textBoxSearch, "");
            }
        }

        void textBoxes_Validating (object sender, EventArgs e)
        {
            if (IsValidColumnId (richTextBoxId.Text))
            {
                errorProvider1.SetError (richTextBoxId, "");
                richTextBoxId.BackColor = SystemColors.Window;
                InvalidTextBoxes.Remove ("id");
            }
            else
            {
                errorProvider1.SetError (richTextBoxId,
                                         "Такой инвентарный номер уже существует");
                richTextBoxId.BackColor = Color.Red;
                InvalidTextBoxes.Add ("id");
            }

            CheckDatesCreateAndRepair (richTextBoxCreate, richTextBoxRepair);

            buttonSaveChanges.Enabled = (InvalidTextBoxes.Count == 0);
        }

        void buttonSelectAll_Click (object sender, EventArgs e)
        {
            if (dataGridView1.AreAllCellsSelected (true))
            {
                if (dataGridView1.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        row.Selected = false;

                    dataGridView1.Rows[0].Selected = true;
                }
            }
            else
            {
                dataGridView1.SelectAll ();
            }
        }

        void printDocument1_PrintPage (
            object sender,
            System.Drawing.Printing.PrintPageEventArgs e
        )
        {
            Graphics g = e.Graphics;
            int x = 0;
            int y = 20;
            int cell_height = 0;

            int colCount = dataGridView1.ColumnCount;
            int rowCount = dataGridView1.RowCount - 1;

            Font font = new Font ("Tahoma",
                                 9,
                                 FontStyle.Bold,
                                 GraphicsUnit.Point);

            int[] widthC = new int[colCount];

            int current_col = 0;
            int current_row = 0;

            while (current_col < colCount)
            {
                if (g.MeasureString (dataGridView1.Columns[current_col].HeaderText.ToString (),
                                    font).Width > widthC[current_col])
                {
                    widthC[current_col] = (int)g.MeasureString (dataGridView1.Columns[current_col].HeaderText.ToString (),
                                                               font).Width;
                }
                current_col++;
            }

            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    if (g.MeasureString (dataGridView1[current_col, current_row].Value.ToString (),
                                        font).Width > widthC[current_col])
                    {
                        widthC[current_col] = (int)g.MeasureString (dataGridView1[current_col,
                                                                                 current_row].Value.ToString (),
                                                                   font).Width;
                    }
                    current_col++;
                }
                current_col = 0;
                current_row++;
            }

            current_col = 0;
            current_row = 0;

            string value = "";

            int width = widthC[current_col];
            int height = dataGridView1[current_col, current_row].Size.Height;

            Rectangle cell_border;
            SolidBrush brush = new SolidBrush (Color.Black);


            while (current_col < colCount)
            {
                width = widthC[current_col];
                cell_height = dataGridView1[current_col, current_row].Size.Height;
                cell_border = new Rectangle (x, y, width, height);
                value = dataGridView1.Columns[current_col].HeaderText.ToString ();
                g.DrawRectangle (new Pen (Color.Black), cell_border);
                g.DrawString (value, font, brush, x, y);
                x += widthC[current_col];
                current_col++;
            }
            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    width = widthC[current_col];
                    cell_height = dataGridView1[current_col, current_row].Size.Height;
                    cell_border = new Rectangle (x, y, width, height);
                    value = dataGridView1[current_col, current_row].Value.ToString ();
                    g.DrawRectangle (new Pen (Color.Black), cell_border);
                    g.DrawString (value, font, brush, x, y);
                    x += widthC[current_col];
                    current_col++;
                }
                current_col = 0;
                current_row++;
                x = 0;
                y += cell_height;
            }
        }

        void buttonPrint_Click (object sender, EventArgs e)
        {
            PrintData ();
        }

        void menuFilePrint_Click (object sender, EventArgs e)
        {
            PrintData ();
        }

        void menuHelpAbout_Click (object sender, EventArgs e)
        {
            FormAbout form = new FormAbout ();
            form.ShowDialog ();
        }

        public bool IsValidColumnName (string name)
        {
            switch (name)
            {
                case COLUMN_ID:
                case COLUMN_TYPE:
                case COLUMN_MODEL:
                case COLUMN_CREATE:
                case COLUMN_REPAIR:
                    return true;
                default:
                    return false;
            }
        }

        public void SelectAllRightRows (
            string text,
            string[] columns,
            SearchMode mode = SearchMode.Contains
        )
        {
            text = text.ToLower ();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool res = false;

                for (int j = 0; j < columns.Length && !res; j++)
                {
                    string value = dataGridView1.Rows[i].Cells[columns[j]].Value.ToString ().ToLower ();

                    if (mode == SearchMode.Contains)
                        res = value.Contains (text);
                    else if (mode == SearchMode.Equals)
                        res = value.Equals (text);
                }

                dataGridView1.Rows[i].Selected = res;
            }
        }

        public void MenuFileOpen ()
        {
            if (openFileDialog1.ShowDialog () ==
                System.Windows.Forms.DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
            {
                IOManager.FileName = openFileDialog1.FileName;
                OpenFile ();
            }
        }

        public void OpenFile ()
        {
            List<DataIO.TrainData> trains;

            if (IOManager.ReadXMLFile (out trains,
                                       IOManager.FileName))
            {
                Trains = new DataIO.DataIO (trains);
                LoadDataToGUI ();
            }
        }

        public void LoadDataToGUI ()
        {
            dataGridView1.Rows.Clear ();

            foreach (var train in Trains.Data)
            {
                var row = new DataGridViewRow ();

                var cellCheck = new DataGridViewCheckBoxCell ();
                var cellId = new DataGridViewTextBoxCell ();
                var cellType = new DataGridViewTextBoxCell ();
                var cellModel = new DataGridViewTextBoxCell ();
                var cellCreate = new DataGridViewTextBoxCell ();
                var cellRepair = new DataGridViewTextBoxCell ();

                cellCheck.Value = false;

                cellId.Value = train.Id;
                cellType.Value = train.Type;
                cellModel.Value = train.Model;
                cellCreate.Value = train.Create.ToString ("dd.MM.yyyy");
                cellRepair.Value = train.Repair.ToString ("dd.MM.yyyy");

                row.Cells.AddRange (cellCheck,
                                    cellId,
                                    cellType,
                                    cellModel,
                                    cellCreate,
                                    cellRepair);

                dataGridView1.Rows.Add (row);
            }
        }

        public void MenuFileCreate ()
        {
            if (!string.IsNullOrEmpty (IOManager.FileName))
                MenuFileSaveAs ();

            IOManager.FileName = string.Empty;
            dataGridView1.Rows.Clear ();
            buttonAddRow_Click (null, null);
        }

        public bool MenuFileSaveAs ()
        {
            if (IOManager.FileName.Length > 0)
                saveFileDialog.FileName = IOManager.FileName;

            if (saveFileDialog.ShowDialog () ==
                DialogResult.OK &&
                saveFileDialog.FileName.Length > 0)
            {
                IOManager.FileName = saveFileDialog.FileName;
                return MenuFileSave ();
            }

            return false;
        }

        public void SaveDataToTrains ()
        {
            var data = new List<DataIO.TrainData> ();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var item = new DataIO.TrainData ();

                item.Id = GetValueFromCell (row.Cells[COLUMN_ID]);
                item.Type = GetValueFromCell (row.Cells[COLUMN_TYPE]);
                item.Model = GetValueFromCell (row.Cells[COLUMN_MODEL]);
                item.Create = GetValueFromCell (row.Cells[COLUMN_CREATE]);
                item.Repair = GetValueFromCell (row.Cells[COLUMN_REPAIR]);

                data.Add (item);
            }

            Trains = new DataIO.DataIO (data);
        }

        public bool MenuFileSave ()
        {
            if (string.IsNullOrEmpty (IOManager.FileName))
                return MenuFileSaveAs ();
            
            SaveDataToTrains ();
            IOManager.WriteDataToXML (Trains.ToXmlFriendlyFormat ());

            return true;
        }

        public string GetValueFromCell (DataGridViewCell cell)
        {
            if (cell == null || cell.Value == null)
                return string.Empty;

            return cell.Value.ToString ();
        }

        public string GetCommonPropertyFromAllSelectedRows (string prop)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string res = GetValueFromCell (dataGridView1.SelectedRows[0].Cells[prop]);

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    if (res != GetValueFromCell (row.Cells[prop]))
                        return string.Empty;

                return res;
            }

            return string.Empty;
        }

        public void SaveChangesInSelectedRows (string prop, string newValue)
        {
            if (string.IsNullOrEmpty (newValue))
                return;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var cell = row.Cells[prop];

                if (cell != null)
                    cell.Value = newValue;
            }
        }

        // Проверка данных на валидность в поле richTextBoxId при вводе
        // вернет true если это уникальны инвентарный номер
        public bool IsValidColumnId (string value)
        {
            int except = -1;

            if (string.IsNullOrEmpty (value))
                return true;

            if (dataGridView1.SelectedRows.Count == 1)
                except = dataGridView1.SelectedRows[0].Index;
            else if (dataGridView1.SelectedRows.Count > 1)
                return false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == except)
                    continue;

                if (value == GetValueFromCell (row.Cells[COLUMN_ID]))
                    return false;
            }

            return true;
        }

        public bool IsValidDate (string value)
        {
            if (string.IsNullOrEmpty (value))
                return true;

            DateTime res;

            return DateTime.TryParseExact (value,
                                           "dd.MM.yyyy",
                                           null,
                                           System.Globalization.DateTimeStyles.None,
                                           out res);
        }

        public void CheckDatesCreateAndRepair (
            RichTextBox create,
            RichTextBox repair
        )
        {
            bool validCreate;
            bool validRepair;

            if (!(validCreate = IsValidDate (create.Text)))
            {
                errorProvider1.SetError (create,
                                         "Дата должна быть указана в формате dd.mm.yyyy");
                InvalidTextBoxes.Add ("create");
            }
            else
            {
                errorProvider1.SetError (create, "");
                InvalidTextBoxes.Remove ("create");
            }

            if (!(validRepair = IsValidDate (repair.Text)))
            {
                errorProvider1.SetError (repair,
                                         "Дата должна быть указана в формате dd.mm.yyyy");
                InvalidTextBoxes.Add ("repair");
            }
            else
            {
                errorProvider1.SetError (repair, "");
                InvalidTextBoxes.Remove ("repair");
            }

            if (validCreate && validRepair &&
                !string.IsNullOrEmpty (create.Text) &&
                !string.IsNullOrEmpty (repair.Text))
            {
                var dateCreate = DateTime.ParseExact (create.Text,
                                                      "dd.MM.yyyy",
                                                      null);
                var dateRepair = DateTime.ParseExact (repair.Text,
                                                      "dd.MM.yyyy",
                                                      null);

                if (dateCreate.CompareTo (dateRepair) == 1)
                {
                    errorProvider1.SetError (richTextBoxCreate,
                                             "Дата ремонта меньше даты создания");
                    errorProvider1.SetError (richTextBoxRepair,
                                             "Дата ремонта меньше даты создания");

                    InvalidTextBoxes.Add ("create");
                    InvalidTextBoxes.Add ("repair");
                }
                else
                {
                    errorProvider1.SetError (richTextBoxCreate, "");
                    errorProvider1.SetError (richTextBoxRepair, "");
                }
            }
            else
            {
                errorProvider1.SetError (richTextBoxCreate, "");
                errorProvider1.SetError (richTextBoxRepair, "");
            }

            create.BackColor = InvalidTextBoxes.Contains ("create") ? Color.Red : SystemColors.Window;
            repair.BackColor = InvalidTextBoxes.Contains ("repair") ? Color.Red : SystemColors.Window;

            buttonSaveChanges.Enabled = (InvalidTextBoxes.Count == 0);
        }

        public void UpdateYandexLink ()
        {
            linkLabelInternet.Text = "www.yandex.ru";

            if (!string.IsNullOrEmpty (richTextBoxType.Text))
            {
                linkLabelInternet.Text += "/yandsearch?text=";
                linkLabelInternet.Text += string.Join ("+",
                                                       richTextBoxType.Text.Split (new[] { ' ' }));

                if (!string.IsNullOrEmpty (richTextBoxModel.Text))
                    linkLabelInternet.Text += string.Format ("+{0}", string.Join ("+", 
                                                                                  richTextBoxModel.Text.Split (new[] {
                        ' '
                    })));
            }
        }

        public void PrintData ()
        {
            try
            {
                var dialog = new PrintPreviewDialog ();
                dialog.Document = printDocument1;
                dialog.ShowDialog ();
            }
            catch
            {
                MessageBox.Show ("Возможно, принтер не подключен",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        bool CanChange;
        bool CanSelect;
        bool change;
        bool select;

        void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            CanChange = CanSelect = false;

            if ( Control.ModifierKeys == Keys.Control)
            {
                if (e.KeyCode == Keys.E)
                {
                    change = !change;
                    CanChange = true;
                }
                else if (e.KeyCode == Keys.W)
                {
                    select = !select;
                    CanSelect = true;
                }
            }
        }

        void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( CanChange )
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                row.Cells[0].Value = change;

            if ( CanSelect)
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (GetValueFromCell(row.Cells[0]) == "True")
                    row.Selected = select;
        }
    }
}
