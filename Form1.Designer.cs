namespace Launcher
{
    partial class Launcher
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainMenu = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catalog = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.library = new System.Windows.Forms.TabPage();
            this.umbrella_CorpDataSet = new Launcher.Umbrella_CorpDataSet();
            this.umbrellaCorpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.catalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umbrella_CorpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umbrellaCorpDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainMenu);
            this.tabControl1.Controls.Add(this.catalog);
            this.tabControl1.Controls.Add(this.library);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 667);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.richTextBox1);
            this.mainMenu.Controls.Add(this.textBox1);
            this.mainMenu.Controls.Add(this.label1);
            this.mainMenu.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold);
            this.mainMenu.Location = new System.Drawing.Point(4, 45);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenu.Size = new System.Drawing.Size(992, 618);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Главный экран";
            this.mainMenu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(60, 400);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 161);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(379, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главное меню";
            // 
            // catalog
            // 
            this.catalog.Controls.Add(this.dataGridView1);
            this.catalog.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalog.Location = new System.Drawing.Point(4, 45);
            this.catalog.Name = "catalog";
            this.catalog.Padding = new System.Windows.Forms.Padding(3);
            this.catalog.Size = new System.Drawing.Size(992, 618);
            this.catalog.TabIndex = 1;
            this.catalog.Text = "Каталог";
            this.catalog.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.umbrellaCorpDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // library
            // 
            this.library.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.library.Location = new System.Drawing.Point(4, 45);
            this.library.Name = "library";
            this.library.Padding = new System.Windows.Forms.Padding(3);
            this.library.Size = new System.Drawing.Size(992, 618);
            this.library.TabIndex = 2;
            this.library.Text = "Библиотека";
            this.library.UseVisualStyleBackColor = true;
            // 
            // umbrella_CorpDataSet
            // 
            this.umbrella_CorpDataSet.DataSetName = "Umbrella_CorpDataSet";
            this.umbrella_CorpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // umbrellaCorpDataSetBindingSource
            // 
            this.umbrellaCorpDataSetBindingSource.DataSource = this.umbrella_CorpDataSet;
            this.umbrellaCorpDataSetBindingSource.Position = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(373, 312);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 662);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.tabControl1.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.catalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umbrella_CorpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umbrellaCorpDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage catalog;
        private System.Windows.Forms.TabPage library;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource umbrellaCorpDataSetBindingSource;
        private Launcher.Umbrella_CorpDataSet umbrella_CorpDataSet;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

