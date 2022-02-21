namespace SpreadsheetApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.create = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.nameToLoad = new System.Windows.Forms.TextBox();
            this.loadName = new System.Windows.Forms.Label();
            this.resultCreate = new System.Windows.Forms.Label();
            this.rowCreate = new System.Windows.Forms.TextBox();
            this.colCreate = new System.Windows.Forms.TextBox();
            this.addRow = new System.Windows.Forms.Button();
            this.addRowAt = new System.Windows.Forms.TextBox();
            this.addCol = new System.Windows.Forms.Button();
            this.addColAt = new System.Windows.Forms.TextBox();
            this.searchRange = new System.Windows.Forms.Button();
            this.searchRow1 = new System.Windows.Forms.TextBox();
            this.searchCol1 = new System.Windows.Forms.TextBox();
            this.searchRow2 = new System.Windows.Forms.TextBox();
            this.searchCol2 = new System.Windows.Forms.TextBox();
            this.stringToSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StringSearch = new System.Windows.Forms.Label();
            this.toCreateSHEETrow = new System.Windows.Forms.Label();
            this.toCreateSHEETcolumn = new System.Windows.Forms.Label();
            this.toAddRow = new System.Windows.Forms.Label();
            this.toAddColumn = new System.Windows.Forms.Label();
            this.RANGErc12 = new System.Windows.Forms.Label();
            this.rangeR = new System.Windows.Forms.Label();
            this.Point1 = new System.Windows.Forms.Label();
            this.Point2 = new System.Windows.Forms.Label();
            this.rangeC = new System.Windows.Forms.Label();
            this.SearchResult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Save = new System.Windows.Forms.Button();
            this.filetoSave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.StatusBOX = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.createBY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(24, 24);
            this.create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(90, 50);
            this.create.TabIndex = 0;
            this.create.Text = "Create Sheet";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // load
            // 
            this.load.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(650, 24);
            this.load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(90, 50);
            this.load.TabIndex = 2;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // nameToLoad
            // 
            this.nameToLoad.Location = new System.Drawing.Point(619, 110);
            this.nameToLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameToLoad.Name = "nameToLoad";
            this.nameToLoad.Size = new System.Drawing.Size(144, 20);
            this.nameToLoad.TabIndex = 3;
            this.nameToLoad.TextChanged += new System.EventHandler(this.nameToLoad_TextChanged);
            // 
            // loadName
            // 
            this.loadName.AutoSize = true;
            this.loadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadName.ForeColor = System.Drawing.Color.White;
            this.loadName.Image = ((System.Drawing.Image)(resources.GetObject("loadName.Image")));
            this.loadName.Location = new System.Drawing.Point(629, 90);
            this.loadName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadName.Name = "loadName";
            this.loadName.Size = new System.Drawing.Size(125, 15);
            this.loadName.TabIndex = 4;
            this.loadName.Text = " select a file name";
            // 
            // resultCreate
            // 
            this.resultCreate.AutoSize = true;
            this.resultCreate.Location = new System.Drawing.Point(199, 106);
            this.resultCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultCreate.Name = "resultCreate";
            this.resultCreate.Size = new System.Drawing.Size(0, 13);
            this.resultCreate.TabIndex = 5;
            // 
            // rowCreate
            // 
            this.rowCreate.Location = new System.Drawing.Point(25, 86);
            this.rowCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rowCreate.Name = "rowCreate";
            this.rowCreate.Size = new System.Drawing.Size(30, 20);
            this.rowCreate.TabIndex = 7;
            // 
            // colCreate
            // 
            this.colCreate.Location = new System.Drawing.Point(80, 86);
            this.colCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colCreate.Name = "colCreate";
            this.colCreate.Size = new System.Drawing.Size(30, 20);
            this.colCreate.TabIndex = 8;
            this.colCreate.TextChanged += new System.EventHandler(this.colCreate_TextChanged);
            // 
            // addRow
            // 
            this.addRow.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRow.Location = new System.Drawing.Point(160, 25);
            this.addRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(90, 50);
            this.addRow.TabIndex = 9;
            this.addRow.Text = "Add row";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // addRowAt
            // 
            this.addRowAt.Location = new System.Drawing.Point(185, 85);
            this.addRowAt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRowAt.Name = "addRowAt";
            this.addRowAt.Size = new System.Drawing.Size(30, 20);
            this.addRowAt.TabIndex = 10;
            // 
            // addCol
            // 
            this.addCol.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCol.Location = new System.Drawing.Point(299, 24);
            this.addCol.Name = "addCol";
            this.addCol.Size = new System.Drawing.Size(90, 50);
            this.addCol.TabIndex = 11;
            this.addCol.Text = "Add column";
            this.addCol.UseVisualStyleBackColor = true;
            this.addCol.Click += new System.EventHandler(this.addCol_Click);
            // 
            // addColAt
            // 
            this.addColAt.Location = new System.Drawing.Point(336, 89);
            this.addColAt.Name = "addColAt";
            this.addColAt.Size = new System.Drawing.Size(30, 20);
            this.addColAt.TabIndex = 12;
            this.addColAt.TextChanged += new System.EventHandler(this.addColAt_TextChanged);
            // 
            // searchRange
            // 
            this.searchRange.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRange.Location = new System.Drawing.Point(460, 24);
            this.searchRange.Name = "searchRange";
            this.searchRange.Size = new System.Drawing.Size(90, 50);
            this.searchRange.TabIndex = 15;
            this.searchRange.Text = "Search in range";
            this.searchRange.UseVisualStyleBackColor = true;
            this.searchRange.Click += new System.EventHandler(this.searchRange_Click);
            // 
            // searchRow1
            // 
            this.searchRow1.Location = new System.Drawing.Point(490, 111);
            this.searchRow1.Name = "searchRow1";
            this.searchRow1.Size = new System.Drawing.Size(30, 20);
            this.searchRow1.TabIndex = 16;
            // 
            // searchCol1
            // 
            this.searchCol1.Location = new System.Drawing.Point(540, 110);
            this.searchCol1.Name = "searchCol1";
            this.searchCol1.Size = new System.Drawing.Size(30, 20);
            this.searchCol1.TabIndex = 17;
            this.searchCol1.TextChanged += new System.EventHandler(this.searchCol1_TextChanged);
            // 
            // searchRow2
            // 
            this.searchRow2.Location = new System.Drawing.Point(490, 137);
            this.searchRow2.Name = "searchRow2";
            this.searchRow2.Size = new System.Drawing.Size(30, 20);
            this.searchRow2.TabIndex = 18;
            // 
            // searchCol2
            // 
            this.searchCol2.Location = new System.Drawing.Point(540, 137);
            this.searchCol2.Name = "searchCol2";
            this.searchCol2.Size = new System.Drawing.Size(30, 20);
            this.searchCol2.TabIndex = 19;
            // 
            // stringToSearch
            // 
            this.stringToSearch.Location = new System.Drawing.Point(440, 182);
            this.stringToSearch.Name = "stringToSearch";
            this.stringToSearch.Size = new System.Drawing.Size(79, 20);
            this.stringToSearch.TabIndex = 20;
            this.stringToSearch.TextChanged += new System.EventHandler(this.stringToSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(441, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Result:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(837, 231);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // StringSearch
            // 
            this.StringSearch.AutoSize = true;
            this.StringSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringSearch.ForeColor = System.Drawing.Color.White;
            this.StringSearch.Image = ((System.Drawing.Image)(resources.GetObject("StringSearch.Image")));
            this.StringSearch.Location = new System.Drawing.Point(438, 164);
            this.StringSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StringSearch.Name = "StringSearch";
            this.StringSearch.Size = new System.Drawing.Size(152, 15);
            this.StringSearch.TabIndex = 25;
            this.StringSearch.Text = "Type a string to search";
            // 
            // toCreateSHEETrow
            // 
            this.toCreateSHEETrow.AutoSize = true;
            this.toCreateSHEETrow.ForeColor = System.Drawing.Color.White;
            this.toCreateSHEETrow.Image = ((System.Drawing.Image)(resources.GetObject("toCreateSHEETrow.Image")));
            this.toCreateSHEETrow.Location = new System.Drawing.Point(20, 76);
            this.toCreateSHEETrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toCreateSHEETrow.Name = "toCreateSHEETrow";
            this.toCreateSHEETrow.Size = new System.Drawing.Size(29, 13);
            this.toCreateSHEETrow.TabIndex = 26;
            this.toCreateSHEETrow.Text = "rows";
            // 
            // toCreateSHEETcolumn
            // 
            this.toCreateSHEETcolumn.AutoSize = true;
            this.toCreateSHEETcolumn.ForeColor = System.Drawing.Color.White;
            this.toCreateSHEETcolumn.Image = ((System.Drawing.Image)(resources.GetObject("toCreateSHEETcolumn.Image")));
            this.toCreateSHEETcolumn.Location = new System.Drawing.Point(57, 76);
            this.toCreateSHEETcolumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toCreateSHEETcolumn.Name = "toCreateSHEETcolumn";
            this.toCreateSHEETcolumn.Size = new System.Drawing.Size(46, 13);
            this.toCreateSHEETcolumn.TabIndex = 27;
            this.toCreateSHEETcolumn.Text = "columns";
            // 
            // toAddRow
            // 
            this.toAddRow.AutoSize = true;
            this.toAddRow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toAddRow.ForeColor = System.Drawing.Color.White;
            this.toAddRow.Image = ((System.Drawing.Image)(resources.GetObject("toAddRow.Image")));
            this.toAddRow.Location = new System.Drawing.Point(182, 76);
            this.toAddRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toAddRow.Name = "toAddRow";
            this.toAddRow.Size = new System.Drawing.Size(27, 13);
            this.toAddRow.TabIndex = 28;
            this.toAddRow.Text = "row";
            // 
            // toAddColumn
            // 
            this.toAddColumn.AutoSize = true;
            this.toAddColumn.ForeColor = System.Drawing.Color.White;
            this.toAddColumn.Image = ((System.Drawing.Image)(resources.GetObject("toAddColumn.Image")));
            this.toAddColumn.Location = new System.Drawing.Point(316, 78);
            this.toAddColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toAddColumn.Name = "toAddColumn";
            this.toAddColumn.Size = new System.Drawing.Size(41, 13);
            this.toAddColumn.TabIndex = 29;
            this.toAddColumn.Text = "column";
            // 
            // RANGErc12
            // 
            this.RANGErc12.AutoSize = true;
            this.RANGErc12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RANGErc12.ForeColor = System.Drawing.Color.White;
            this.RANGErc12.Image = ((System.Drawing.Image)(resources.GetObject("RANGErc12.Image")));
            this.RANGErc12.Location = new System.Drawing.Point(433, 87);
            this.RANGErc12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RANGErc12.Name = "RANGErc12";
            this.RANGErc12.Size = new System.Drawing.Size(178, 15);
            this.RANGErc12.TabIndex = 30;
            this.RANGErc12.Text = "Type a start and end range";
            // 
            // rangeR
            // 
            this.rangeR.AutoSize = true;
            this.rangeR.ForeColor = System.Drawing.Color.White;
            this.rangeR.Image = ((System.Drawing.Image)(resources.GetObject("rangeR.Image")));
            this.rangeR.Location = new System.Drawing.Point(486, 103);
            this.rangeR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rangeR.Name = "rangeR";
            this.rangeR.Size = new System.Drawing.Size(24, 13);
            this.rangeR.TabIndex = 31;
            this.rangeR.Text = "row";
            // 
            // Point1
            // 
            this.Point1.AutoSize = true;
            this.Point1.ForeColor = System.Drawing.Color.White;
            this.Point1.Image = ((System.Drawing.Image)(resources.GetObject("Point1.Image")));
            this.Point1.Location = new System.Drawing.Point(438, 112);
            this.Point1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(40, 13);
            this.Point1.TabIndex = 32;
            this.Point1.Text = "Point1:";
            // 
            // Point2
            // 
            this.Point2.AutoSize = true;
            this.Point2.ForeColor = System.Drawing.Color.White;
            this.Point2.Image = ((System.Drawing.Image)(resources.GetObject("Point2.Image")));
            this.Point2.Location = new System.Drawing.Point(438, 140);
            this.Point2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(40, 13);
            this.Point2.TabIndex = 33;
            this.Point2.Text = "Point2:";
            // 
            // rangeC
            // 
            this.rangeC.AutoSize = true;
            this.rangeC.ForeColor = System.Drawing.Color.White;
            this.rangeC.Image = ((System.Drawing.Image)(resources.GetObject("rangeC.Image")));
            this.rangeC.Location = new System.Drawing.Point(524, 102);
            this.rangeC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rangeC.Name = "rangeC";
            this.rangeC.Size = new System.Drawing.Size(41, 13);
            this.rangeC.TabIndex = 34;
            this.rangeC.Text = "column";
            // 
            // SearchResult
            // 
            this.SearchResult.AutoSize = true;
            this.SearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchResult.Location = new System.Drawing.Point(494, 217);
            this.SearchResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(0, 15);
            this.SearchResult.TabIndex = 36;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(835, 24);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 50);
            this.Save.TabIndex = 37;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // filetoSave
            // 
            this.filetoSave.Location = new System.Drawing.Point(833, 107);
            this.filetoSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filetoSave.Name = "filetoSave";
            this.filetoSave.Size = new System.Drawing.Size(88, 20);
            this.filetoSave.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(832, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Type file name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Location = new System.Drawing.Point(112, 137);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(178, 72);
            this.dataGridView2.TabIndex = 0;
            // 
            // StatusBOX
            // 
            this.StatusBOX.AutoSize = true;
            this.StatusBOX.BackColor = System.Drawing.SystemColors.Menu;
            this.StatusBOX.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBOX.Location = new System.Drawing.Point(164, 149);
            this.StatusBOX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusBOX.Name = "StatusBOX";
            this.StatusBOX.Size = new System.Drawing.Size(76, 33);
            this.StatusBOX.TabIndex = 40;
            this.StatusBOX.Text = "Status";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.Menu;
            this.Result.Location = new System.Drawing.Point(178, 182);
            this.Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(22, 13);
            this.Result.TabIndex = 41;
            this.Result.Text = "-----";
            // 
            // createBY
            // 
            this.createBY.AutoSize = true;
            this.createBY.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createBY.Image = ((System.Drawing.Image)(resources.GetObject("createBY.Image")));
            this.createBY.Location = new System.Drawing.Point(904, 451);
            this.createBY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createBY.Name = "createBY";
            this.createBY.Size = new System.Drawing.Size(196, 33);
            this.createBY.TabIndex = 42;
            this.createBY.Text = "BY: Dar and Ohad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1137, 495);
            this.Controls.Add(this.createBY);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.StatusBOX);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filetoSave);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.SearchResult);
            this.Controls.Add(this.rangeC);
            this.Controls.Add(this.Point2);
            this.Controls.Add(this.Point1);
            this.Controls.Add(this.rangeR);
            this.Controls.Add(this.RANGErc12);
            this.Controls.Add(this.toAddColumn);
            this.Controls.Add(this.toAddRow);
            this.Controls.Add(this.toCreateSHEETcolumn);
            this.Controls.Add(this.toCreateSHEETrow);
            this.Controls.Add(this.StringSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stringToSearch);
            this.Controls.Add(this.searchCol2);
            this.Controls.Add(this.searchRow2);
            this.Controls.Add(this.searchCol1);
            this.Controls.Add(this.searchRow1);
            this.Controls.Add(this.searchRange);
            this.Controls.Add(this.addColAt);
            this.Controls.Add(this.addCol);
            this.Controls.Add(this.addRowAt);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.colCreate);
            this.Controls.Add(this.rowCreate);
            this.Controls.Add(this.resultCreate);
            this.Controls.Add(this.loadName);
            this.Controls.Add(this.nameToLoad);
            this.Controls.Add(this.load);
            this.Controls.Add(this.create);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Spreadsheet GUI application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox nameToLoad;
        private System.Windows.Forms.Label loadName;
        private System.Windows.Forms.Label resultCreate;
        private System.Windows.Forms.TextBox rowCreate;
        private System.Windows.Forms.TextBox colCreate;
        private System.Windows.Forms.Button addRow;
        private System.Windows.Forms.TextBox addRowAt;
        private System.Windows.Forms.Button addCol;
        private System.Windows.Forms.TextBox addColAt;
        private System.Windows.Forms.Button searchRange;
        private System.Windows.Forms.TextBox searchRow1;
        private System.Windows.Forms.TextBox searchCol1;
        private System.Windows.Forms.TextBox searchRow2;
        private System.Windows.Forms.TextBox searchCol2;
        private System.Windows.Forms.TextBox stringToSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StringSearch;
        private System.Windows.Forms.Label toCreateSHEETrow;
        private System.Windows.Forms.Label toCreateSHEETcolumn;
        private System.Windows.Forms.Label toAddRow;
        private System.Windows.Forms.Label toAddColumn;
        private System.Windows.Forms.Label RANGErc12;
        private System.Windows.Forms.Label rangeR;
        private System.Windows.Forms.Label Point1;
        private System.Windows.Forms.Label Point2;
        private System.Windows.Forms.Label rangeC;
        private System.Windows.Forms.Label SearchResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox filetoSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label StatusBOX;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label createBY;
    }
}

