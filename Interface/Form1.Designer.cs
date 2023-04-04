namespace Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imp_btn = new Button();
            exp_btn = new Button();
            add_btn = new Button();
            del_btn = new Button();
            edit_btn = new Button();
            Grid = new DataGridView();
            srch_txtbox = new TextBox();
            load_btn = new Button();
            save_btn = new Button();
            new_btn = new Button();
            cardBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            setDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            printingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBindingSource).BeginInit();
            SuspendLayout();
            // 
            // imp_btn
            // 
            imp_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            imp_btn.Location = new Point(753, 493);
            imp_btn.Name = "imp_btn";
            imp_btn.Size = new Size(75, 23);
            imp_btn.TabIndex = 1;
            imp_btn.Text = "Import";
            imp_btn.UseVisualStyleBackColor = true;
            // 
            // exp_btn
            // 
            exp_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exp_btn.Location = new Point(834, 493);
            exp_btn.Name = "exp_btn";
            exp_btn.Size = new Size(75, 23);
            exp_btn.TabIndex = 2;
            exp_btn.Text = "Export";
            exp_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            add_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            add_btn.Location = new Point(12, 493);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 23);
            add_btn.TabIndex = 3;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // del_btn
            // 
            del_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            del_btn.Location = new Point(174, 493);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(75, 23);
            del_btn.TabIndex = 4;
            del_btn.Text = "Delete";
            del_btn.UseVisualStyleBackColor = true;
            del_btn.Click += del_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            edit_btn.Location = new Point(93, 493);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(75, 23);
            edit_btn.TabIndex = 5;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // Grid
            // 
            Grid.AllowUserToAddRows = false;
            Grid.AllowUserToDeleteRows = false;
            Grid.AllowUserToOrderColumns = true;
            Grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Grid.AutoGenerateColumns = false;
            Grid.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, quantDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, colorsDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, setDataGridViewTextBoxColumn, printingsDataGridViewTextBoxColumn });
            Grid.DataSource = cardBindingSource;
            Grid.Location = new Point(12, 70);
            Grid.Name = "Grid";
            Grid.ReadOnly = true;
            Grid.RowTemplate.Height = 25;
            Grid.Size = new Size(897, 412);
            Grid.StandardTab = true;
            Grid.TabIndex = 6;
            // 
            // srch_txtbox
            // 
            srch_txtbox.Location = new Point(12, 41);
            srch_txtbox.Name = "srch_txtbox";
            srch_txtbox.Size = new Size(331, 23);
            srch_txtbox.TabIndex = 8;
            srch_txtbox.TextChanged += srch_txtbox_TextChanged;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(57, 12);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(42, 23);
            load_btn.TabIndex = 10;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(105, 12);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(44, 23);
            save_btn.TabIndex = 11;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // new_btn
            // 
            new_btn.Location = new Point(12, 12);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(39, 23);
            new_btn.TabIndex = 12;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // cardBindingSource
            // 
            cardBindingSource.DataSource = typeof(Models.Card);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantDataGridViewTextBoxColumn
            // 
            quantDataGridViewTextBoxColumn.DataPropertyName = "Quant";
            quantDataGridViewTextBoxColumn.HeaderText = "Quant";
            quantDataGridViewTextBoxColumn.Name = "quantDataGridViewTextBoxColumn";
            quantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorsDataGridViewTextBoxColumn
            // 
            colorsDataGridViewTextBoxColumn.DataPropertyName = "Colors";
            colorsDataGridViewTextBoxColumn.HeaderText = "Colors";
            colorsDataGridViewTextBoxColumn.Name = "colorsDataGridViewTextBoxColumn";
            colorsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // setDataGridViewTextBoxColumn
            // 
            setDataGridViewTextBoxColumn.DataPropertyName = "Set";
            setDataGridViewTextBoxColumn.HeaderText = "Set";
            setDataGridViewTextBoxColumn.Name = "setDataGridViewTextBoxColumn";
            setDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printingsDataGridViewTextBoxColumn
            // 
            printingsDataGridViewTextBoxColumn.DataPropertyName = "Printings";
            printingsDataGridViewTextBoxColumn.HeaderText = "Printings";
            printingsDataGridViewTextBoxColumn.Name = "printingsDataGridViewTextBoxColumn";
            printingsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 528);
            Controls.Add(new_btn);
            Controls.Add(save_btn);
            Controls.Add(load_btn);
            Controls.Add(srch_txtbox);
            Controls.Add(Grid);
            Controls.Add(edit_btn);
            Controls.Add(del_btn);
            Controls.Add(add_btn);
            Controls.Add(exp_btn);
            Controls.Add(imp_btn);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button imp_btn;
        private Button exp_btn;
        private Button add_btn;
        private Button del_btn;
        private Button edit_btn;
        private DataGridView Grid;
        private TextBox srch_txtbox;
        private Button load_btn;
        private Button save_btn;
        private Button new_btn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn setDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn printingsDataGridViewTextBoxColumn;
        private BindingSource cardBindingSource;
    }
}