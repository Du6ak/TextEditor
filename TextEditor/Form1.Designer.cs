namespace TextEditor
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.odin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chetire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vosem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.panel1.Location = new System.Drawing.Point(13, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 363);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odin,
            this.dva,
            this.tri,
            this.chetire,
            this.pyat,
            this.shest,
            this.sem,
            this.vosem,
            this.devyat,
            this.desyat});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "1. Наименование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // odin
            // 
            this.odin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.odin.HeaderText = "1";
            this.odin.Name = "odin";
            this.odin.ReadOnly = true;
            this.odin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.odin.Width = 45;
            // 
            // dva
            // 
            this.dva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dva.HeaderText = "2";
            this.dva.Name = "dva";
            this.dva.ReadOnly = true;
            this.dva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dva.Width = 45;
            // 
            // tri
            // 
            this.tri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tri.HeaderText = "3";
            this.tri.Name = "tri";
            this.tri.ReadOnly = true;
            this.tri.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tri.Width = 45;
            // 
            // chetire
            // 
            this.chetire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chetire.HeaderText = "4";
            this.chetire.Name = "chetire";
            this.chetire.ReadOnly = true;
            this.chetire.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chetire.Width = 45;
            // 
            // pyat
            // 
            this.pyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pyat.HeaderText = "5";
            this.pyat.Name = "pyat";
            this.pyat.ReadOnly = true;
            this.pyat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pyat.Width = 45;
            // 
            // shest
            // 
            this.shest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.shest.HeaderText = "6";
            this.shest.Name = "shest";
            this.shest.ReadOnly = true;
            this.shest.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.shest.Width = 45;
            // 
            // sem
            // 
            this.sem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sem.HeaderText = "7";
            this.sem.Name = "sem";
            this.sem.ReadOnly = true;
            this.sem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sem.Width = 45;
            // 
            // vosem
            // 
            this.vosem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vosem.HeaderText = "8";
            this.vosem.Name = "vosem";
            this.vosem.ReadOnly = true;
            this.vosem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vosem.Width = 45;
            // 
            // devyat
            // 
            this.devyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.devyat.HeaderText = "9";
            this.devyat.Name = "devyat";
            this.devyat.ReadOnly = true;
            this.devyat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.devyat.Width = 45;
            // 
            // desyat
            // 
            this.desyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.desyat.HeaderText = "10";
            this.desyat.Name = "desyat";
            this.desyat.ReadOnly = true;
            this.desyat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.desyat.Width = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn odin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dva;
        private System.Windows.Forms.DataGridViewTextBoxColumn tri;
        private System.Windows.Forms.DataGridViewTextBoxColumn chetire;
        private System.Windows.Forms.DataGridViewTextBoxColumn pyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn shest;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn vosem;
        private System.Windows.Forms.DataGridViewTextBoxColumn devyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn desyat;
    }
}

