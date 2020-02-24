namespace tileMapTool
{
    partial class Tools
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.columns = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(12, 41);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(75, 20);
            this.Rows.TabIndex = 4;
            this.Rows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rows.ValueChanged += new System.EventHandler(this.Rows_ValueChanged);
            // 
            // columns
            // 
            this.columns.Location = new System.Drawing.Point(136, 41);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(75, 20);
            this.columns.TabIndex = 5;
            this.columns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.columns.ValueChanged += new System.EventHandler(this.columns_ValueChanged);
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 580);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.Tools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown Rows;
        private System.Windows.Forms.NumericUpDown columns;
    }
}