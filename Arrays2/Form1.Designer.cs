namespace Arrays2
{
    partial class FormArrays2
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
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.groupBoxMass = new System.Windows.Forms.GroupBox();
            this.dataGridViewMass = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelA_val = new System.Windows.Forms.Label();
            this.labelB_val = new System.Windows.Forms.Label();
            this.labelC_val = new System.Windows.Forms.Label();
            this.labelD_val = new System.Windows.Forms.Label();
            this.groupBoxMass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.labelN.Location = new System.Drawing.Point(12, 15);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(154, 14);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Количество элементов:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(167, 12);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(34, 20);
            this.textBoxN.TabIndex = 1;
            // 
            // groupBoxMass
            // 
            this.groupBoxMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMass.Controls.Add(this.dataGridViewMass);
            this.groupBoxMass.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.groupBoxMass.Location = new System.Drawing.Point(12, 38);
            this.groupBoxMass.Name = "groupBoxMass";
            this.groupBoxMass.Size = new System.Drawing.Size(474, 87);
            this.groupBoxMass.TabIndex = 4;
            this.groupBoxMass.TabStop = false;
            this.groupBoxMass.Text = "Элементы массива:";
            // 
            // dataGridViewMass
            // 
            this.dataGridViewMass.AllowUserToDeleteRows = false;
            this.dataGridViewMass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMass.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMass.Name = "dataGridViewMass";
            this.dataGridViewMass.Size = new System.Drawing.Size(462, 62);
            this.dataGridViewMass.TabIndex = 6;
            this.dataGridViewMass.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMass_CellValueChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(207, 8);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(99, 27);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Location = new System.Drawing.Point(312, 8);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(99, 27);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Заполнить";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(12, 128);
            this.labelA.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(357, 28);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "Произведение элементов массива после минимального элемента ";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(12, 169);
            this.labelB.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(378, 28);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "Сумма элементов массива между первым отрицательным и вторым положительным элемент" +
    "ами";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(12, 215);
            this.labelC.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(350, 28);
            this.labelC.TabIndex = 9;
            this.labelC.Text = "Сумму элементов массива между первым и последним нулевыми элементами";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.Location = new System.Drawing.Point(12, 261);
            this.labelD.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(371, 28);
            this.labelD.TabIndex = 10;
            this.labelD.Text = "Произведение элементов масива между максимальным по модулю и минимальным по модул" +
    "ю элементами";
            // 
            // labelA_val
            // 
            this.labelA_val.AutoSize = true;
            this.labelA_val.Location = new System.Drawing.Point(408, 143);
            this.labelA_val.Name = "labelA_val";
            this.labelA_val.Size = new System.Drawing.Size(13, 13);
            this.labelA_val.TabIndex = 13;
            this.labelA_val.Text = "0";
            // 
            // labelB_val
            // 
            this.labelB_val.AutoSize = true;
            this.labelB_val.Location = new System.Drawing.Point(408, 184);
            this.labelB_val.Name = "labelB_val";
            this.labelB_val.Size = new System.Drawing.Size(13, 13);
            this.labelB_val.TabIndex = 14;
            this.labelB_val.Text = "0";
            // 
            // labelC_val
            // 
            this.labelC_val.AutoSize = true;
            this.labelC_val.Location = new System.Drawing.Point(408, 230);
            this.labelC_val.Name = "labelC_val";
            this.labelC_val.Size = new System.Drawing.Size(13, 13);
            this.labelC_val.TabIndex = 15;
            this.labelC_val.Text = "0";
            // 
            // labelD_val
            // 
            this.labelD_val.AutoSize = true;
            this.labelD_val.Location = new System.Drawing.Point(408, 276);
            this.labelD_val.Name = "labelD_val";
            this.labelD_val.Size = new System.Drawing.Size(13, 13);
            this.labelD_val.TabIndex = 16;
            this.labelD_val.Text = "0";
            // 
            // FormArrays2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 303);
            this.Controls.Add(this.labelD_val);
            this.Controls.Add(this.labelC_val);
            this.Controls.Add(this.labelB_val);
            this.Controls.Add(this.labelA_val);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.groupBoxMass);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.MinimumSize = new System.Drawing.Size(514, 341);
            this.Name = "FormArrays2";
            this.Text = "Arrays2";
            this.groupBoxMass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.GroupBox groupBoxMass;
        private System.Windows.Forms.DataGridView dataGridViewMass;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelA_val;
        private System.Windows.Forms.Label labelB_val;
        private System.Windows.Forms.Label labelC_val;
        private System.Windows.Forms.Label labelD_val;
    }
}

