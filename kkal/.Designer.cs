namespace kkal
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
            this.components = new System.ComponentModel.Container();
            this.BtKkal = new System.Windows.Forms.Button();
            this.CbRecipe = new System.Windows.Forms.ComboBox();
            this.LbChosenRecipe = new System.Windows.Forms.ListBox();
            this.LbSumCal = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtKkal
            // 
            this.BtKkal.Location = new System.Drawing.Point(32, 316);
            this.BtKkal.Name = "BtKkal";
            this.BtKkal.Size = new System.Drawing.Size(202, 78);
            this.BtKkal.TabIndex = 0;
            this.BtKkal.Text = "Розрахувати калорійність";
            this.toolTip1.SetToolTip(this.BtKkal, "Натисніть, для розрахунку обраних вами страв");
            this.BtKkal.UseVisualStyleBackColor = true;
            this.BtKkal.Click += new System.EventHandler(this.BtKkal_Click);
            // 
            // CbRecipe
            // 
            this.CbRecipe.FormattingEnabled = true;
            this.CbRecipe.Location = new System.Drawing.Point(20, 82);
            this.CbRecipe.Name = "CbRecipe";
            this.CbRecipe.Size = new System.Drawing.Size(221, 28);
            this.CbRecipe.TabIndex = 1;
            this.CbRecipe.SelectedIndexChanged += new System.EventHandler(this.CbRecipe_SelectedIndexChanged);
            // 
            // LbChosenRecipe
            // 
            this.LbChosenRecipe.FormattingEnabled = true;
            this.LbChosenRecipe.ItemHeight = 20;
            this.LbChosenRecipe.Location = new System.Drawing.Point(304, 30);
            this.LbChosenRecipe.Name = "LbChosenRecipe";
            this.LbChosenRecipe.Size = new System.Drawing.Size(235, 384);
            this.LbChosenRecipe.TabIndex = 2;
            this.toolTip1.SetToolTip(this.LbChosenRecipe, "Обрані вами страви\r\n");
            // 
            // LbSumCal
            // 
            this.LbSumCal.FormattingEnabled = true;
            this.LbSumCal.ItemHeight = 20;
            this.LbSumCal.Location = new System.Drawing.Point(567, 30);
            this.LbSumCal.Name = "LbSumCal";
            this.LbSumCal.Size = new System.Drawing.Size(221, 384);
            this.LbSumCal.TabIndex = 3;
            this.toolTip1.SetToolTip(this.LbSumCal, "Калорійність обраних страв");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbRecipe);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть страву";
            this.toolTip1.SetToolTip(this.groupBox1, "З випадаючого списку оберіть страву, \r\nяку ви хочете приготувати.\r\n(Можна обрати " +
        "відразу декілька)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Рецепт";
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(32, 265);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(202, 45);
            this.BtClear.TabIndex = 5;
            this.BtClear.Text = "Очистити  всі поля";
            this.toolTip1.SetToolTip(this.BtClear, "Натисніть для того, щоб очистити всі поля\r\n\r\n");
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(32, 400);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(202, 38);
            this.BtClose.TabIndex = 6;
            this.BtClose.Text = "Завершити роботу";
            this.toolTip1.SetToolTip(this.BtClose, "Натисніть, щоб завершити роботу з додатком");
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Підказка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbSumCal);
            this.Controls.Add(this.LbChosenRecipe);
            this.Controls.Add(this.BtKkal);
            this.Name = "Form1";
            this.Text = "Calories";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtKkal;
        private System.Windows.Forms.ComboBox CbRecipe;
        private System.Windows.Forms.ListBox LbChosenRecipe;
        private System.Windows.Forms.ListBox LbSumCal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

