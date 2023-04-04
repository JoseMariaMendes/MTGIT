namespace Interface
{
    partial class RequestQuantSet
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            quant_txt = new TextBox();
            set_combo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // quant_txt
            // 
            quant_txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quant_txt.Location = new Point(91, 51);
            quant_txt.Name = "quant_txt";
            quant_txt.Size = new Size(169, 23);
            quant_txt.TabIndex = 0;
            quant_txt.TextChanged += quant_txt_TextChanged;
            // 
            // set_combo
            // 
            set_combo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            set_combo.FormattingEnabled = true;
            set_combo.Location = new Point(91, 80);
            set_combo.Name = "set_combo";
            set_combo.Size = new Size(169, 23);
            set_combo.TabIndex = 1;
            set_combo.SelectedIndexChanged += set_combo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 2;
            label1.Text = "Please specify the quantity and the set";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(32, 54);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 83);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 4;
            label3.Text = "Set";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(119, 124);
            button1.Name = "button1";
            button1.Size = new Size(78, 23);
            button1.TabIndex = 5;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RequestQuantSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 159);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(set_combo);
            Controls.Add(quant_txt);
            Name = "RequestQuantSet";
            Text = "Quantity and Set";
            Load += RequestQuantSet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox quant_txt;
        private ComboBox set_combo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}