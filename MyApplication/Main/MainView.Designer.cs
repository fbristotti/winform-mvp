namespace MyApplication.Main
{
    partial class MainView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label conservadorLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label financeiroLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.conservadorCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.financeiroTextBox = new System.Windows.Forms.TextBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateLabel = new System.Windows.Forms.Label();
            conservadorLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            financeiroLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(18, 46);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // conservadorLabel
            // 
            conservadorLabel.AutoSize = true;
            conservadorLabel.Location = new System.Drawing.Point(18, 76);
            conservadorLabel.Name = "conservadorLabel";
            conservadorLabel.Size = new System.Drawing.Size(70, 13);
            conservadorLabel.TabIndex = 6;
            conservadorLabel.Text = "Conservador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 158);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 9;
            label1.Text = "Nome:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(30, 184);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(33, 13);
            valueLabel.TabIndex = 9;
            valueLabel.Text = "Qtde:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.modelBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(57, 42);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // conservadorCheckBox
            // 
            this.conservadorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.modelBindingSource, "Conservador", true));
            this.conservadorCheckBox.Location = new System.Drawing.Point(94, 71);
            this.conservadorCheckBox.Name = "conservadorCheckBox";
            this.conservadorCheckBox.Size = new System.Drawing.Size(22, 24);
            this.conservadorCheckBox.TabIndex = 7;
            this.conservadorCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Nome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(73, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 8;
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Quantidade", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.valueTextBox.Location = new System.Drawing.Point(73, 181);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(166, 20);
            this.valueTextBox.TabIndex = 10;
            // 
            // financeiroLabel
            // 
            financeiroLabel.AutoSize = true;
            financeiroLabel.Location = new System.Drawing.Point(8, 209);
            financeiroLabel.Name = "financeiroLabel";
            financeiroLabel.Size = new System.Drawing.Size(59, 13);
            financeiroLabel.TabIndex = 11;
            financeiroLabel.Text = "Financeiro:";
            // 
            // financeiroTextBox
            // 
            this.financeiroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Financeiro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.financeiroTextBox.Location = new System.Drawing.Point(73, 206);
            this.financeiroTextBox.Name = "financeiroTextBox";
            this.financeiroTextBox.ReadOnly = true;
            this.financeiroTextBox.Size = new System.Drawing.Size(166, 20);
            this.financeiroTextBox.TabIndex = 12;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(MyApplication.Main.Model);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(financeiroLabel);
            this.Controls.Add(this.financeiroTextBox);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(conservadorLabel);
            this.Controls.Add(this.conservadorCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(568, 257);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox conservadorCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox financeiroTextBox;
    }
}
