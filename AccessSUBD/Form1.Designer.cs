namespace AccessSUBD
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
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.dataGridViewRegisty = new System.Windows.Forms.DataGridView();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxPathMDB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisty)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRegisty
            // 
            this.dataGridViewRegisty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegisty.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewRegisty.Name = "dataGridViewRegisty";
            this.dataGridViewRegisty.Size = new System.Drawing.Size(776, 493);
            this.dataGridViewRegisty.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(306, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(94, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Подсоединить";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxPathMDB
            // 
            this.textBoxPathMDB.Location = new System.Drawing.Point(13, 30);
            this.textBoxPathMDB.Name = "textBoxPathMDB";
            this.textBoxPathMDB.Size = new System.Drawing.Size(269, 20);
            this.textBoxPathMDB.TabIndex = 2;
            this.textBoxPathMDB.Text = "D:\\_TEMP\\DATABASE.mdb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.textBoxPathMDB);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.dataGridViewRegisty);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRegisty;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxPathMDB;
    }
}

