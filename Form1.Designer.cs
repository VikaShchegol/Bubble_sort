namespace WindowsFormsApp8
{
    partial class frmBubbleSort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.btGenerate = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBubbleSort = new System.Windows.Forms.Button();
            this.txtBubbleSort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.txtArray);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерацiя масиву";
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(348, 43);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 82;
            this.dgvMass.RowTemplate.Height = 33;
            this.dgvMass.Size = new System.Drawing.Size(976, 202);
            this.dgvMass.TabIndex = 3;
            this.dgvMass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMass_CellContentClick);
            // 
            // btGenerate
            // 
            this.btGenerate.BackColor = System.Drawing.Color.LightGray;
            this.btGenerate.Location = new System.Drawing.Point(348, 251);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(690, 85);
            this.btGenerate.TabIndex = 2;
            this.btGenerate.Text = "Згенерувати порожнiй масив";
            this.btGenerate.UseVisualStyleBackColor = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(37, 149);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(261, 44);
            this.txtArray.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введiть кiлькiсть елементiв масиву: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBubbleSort);
            this.groupBox2.Controls.Add(this.txtBubbleSort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1352, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "\"Бульбашкова\" сортування";
            // 
            // btBubbleSort
            // 
            this.btBubbleSort.BackColor = System.Drawing.Color.LightGray;
            this.btBubbleSort.Location = new System.Drawing.Point(22, 54);
            this.btBubbleSort.Name = "btBubbleSort";
            this.btBubbleSort.Size = new System.Drawing.Size(276, 153);
            this.btBubbleSort.TabIndex = 2;
            this.btBubbleSort.Text = "Сортувати";
            this.btBubbleSort.UseVisualStyleBackColor = false;
            this.btBubbleSort.Click += new System.EventHandler(this.btBubbleSort_Click);
            // 
            // txtBubbleSort
            // 
            this.txtBubbleSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBubbleSort.Location = new System.Drawing.Point(317, 99);
            this.txtBubbleSort.Name = "txtBubbleSort";
            this.txtBubbleSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBubbleSort.Size = new System.Drawing.Size(946, 37);
            this.txtBubbleSort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Масив пiсля сортування:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(537, 668);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(335, 85);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихiд";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmBubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 779);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmBubbleSort";
            this.Text = "Сортування \"бульбашкою\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBubbleSort;
        private System.Windows.Forms.TextBox txtBubbleSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
    }
}

