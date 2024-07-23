namespace DrinkMachine
{
    partial class txtPrice
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
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnKeeping = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtNewDrink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMilk = new System.Windows.Forms.ComboBox();
            this.cmbCocoa = new System.Windows.Forms.ComboBox();
            this.cmbCoffee = new System.Windows.Forms.ComboBox();
            this.cmbSuger = new System.Windows.Forms.ComboBox();
            this.dgvDrinkTable = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cacau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinkTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Red;
            this.btnMinus.Location = new System.Drawing.Point(23, 132);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 26);
            this.btnMinus.TabIndex = 25;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlus.Location = new System.Drawing.Point(75, 132);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(36, 27);
            this.btnPlus.TabIndex = 24;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnKeeping
            // 
            this.btnKeeping.Location = new System.Drawing.Point(218, 59);
            this.btnKeeping.Name = "btnKeeping";
            this.btnKeeping.Size = new System.Drawing.Size(131, 25);
            this.btnKeeping.TabIndex = 23;
            this.btnKeeping.Text = "שמירה";
            this.btnKeeping.UseVisualStyleBackColor = true;
            this.btnKeeping.Click += new System.EventHandler(this.btnKeeping_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(404, 29);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(147, 25);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "יצירה";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNewDrink
            // 
            this.txtNewDrink.Location = new System.Drawing.Point(557, 43);
            this.txtNewDrink.Name = "txtNewDrink";
            this.txtNewDrink.Size = new System.Drawing.Size(110, 22);
            this.txtNewDrink.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "סוג שתיה חדש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "מחיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "חלב";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "קקאו";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "קפה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "סוכר";
            // 
            // cmbMilk
            // 
            this.cmbMilk.FormattingEnabled = true;
            this.cmbMilk.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbMilk.Location = new System.Drawing.Point(256, 136);
            this.cmbMilk.Name = "cmbMilk";
            this.cmbMilk.Size = new System.Drawing.Size(108, 24);
            this.cmbMilk.TabIndex = 12;
            // 
            // cmbCocoa
            // 
            this.cmbCocoa.FormattingEnabled = true;
            this.cmbCocoa.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCocoa.Location = new System.Drawing.Point(386, 136);
            this.cmbCocoa.Name = "cmbCocoa";
            this.cmbCocoa.Size = new System.Drawing.Size(108, 24);
            this.cmbCocoa.TabIndex = 11;
            // 
            // cmbCoffee
            // 
            this.cmbCoffee.FormattingEnabled = true;
            this.cmbCoffee.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCoffee.Location = new System.Drawing.Point(517, 136);
            this.cmbCoffee.Name = "cmbCoffee";
            this.cmbCoffee.Size = new System.Drawing.Size(108, 24);
            this.cmbCoffee.TabIndex = 10;
            // 
            // cmbSuger
            // 
            this.cmbSuger.FormattingEnabled = true;
            this.cmbSuger.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSuger.Location = new System.Drawing.Point(646, 136);
            this.cmbSuger.Name = "cmbSuger";
            this.cmbSuger.Size = new System.Drawing.Size(108, 24);
            this.cmbSuger.TabIndex = 14;
            // 
            // dgvDrinkTable
            // 
            this.dgvDrinkTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrinkTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.milk,
            this.cacau,
            this.coffee,
            this.suger});
            this.dgvDrinkTable.Location = new System.Drawing.Point(111, 222);
            this.dgvDrinkTable.Name = "dgvDrinkTable";
            this.dgvDrinkTable.RowHeadersWidth = 51;
            this.dgvDrinkTable.RowTemplate.Height = 24;
            this.dgvDrinkTable.Size = new System.Drawing.Size(619, 187);
            this.dgvDrinkTable.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(404, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 25);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 25);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(102, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "0";
            // 
            // name
            // 
            this.name.HeaderText = "שם";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "מחיר";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 75;
            // 
            // milk
            // 
            this.milk.HeaderText = "חלב";
            this.milk.MinimumWidth = 6;
            this.milk.Name = "milk";
            this.milk.Width = 75;
            // 
            // cacau
            // 
            this.cacau.HeaderText = "קקאו";
            this.cacau.MinimumWidth = 6;
            this.cacau.Name = "cacau";
            this.cacau.Width = 75;
            // 
            // coffee
            // 
            this.coffee.HeaderText = "קפה";
            this.coffee.MinimumWidth = 6;
            this.coffee.Name = "coffee";
            this.coffee.Width = 75;
            // 
            // suger
            // 
            this.suger.HeaderText = "סוכר";
            this.suger.MinimumWidth = 6;
            this.suger.Name = "suger";
            this.suger.Width = 75;
            // 
            // txtPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnKeeping);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNewDrink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMilk);
            this.Controls.Add(this.cmbCocoa);
            this.Controls.Add(this.cmbCoffee);
            this.Controls.Add(this.cmbSuger);
            this.Controls.Add(this.dgvDrinkTable);
            this.Name = "txtPrice";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinkTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnKeeping;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNewDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMilk;
        private System.Windows.Forms.ComboBox cmbCocoa;
        private System.Windows.Forms.ComboBox cmbCoffee;
        private System.Windows.Forms.ComboBox cmbSuger;
        private System.Windows.Forms.DataGridView dgvDrinkTable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacau;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn suger;
    }
}

