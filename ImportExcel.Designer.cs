
namespace ProjectSept13
{
    partial class ImportExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportExcel));
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnImportSearch = new System.Windows.Forms.Button();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Crimson;
            this.btnOpen.Location = new System.Drawing.Point(30, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(402, 34);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(27, 59);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(68, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Selected File";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(30, 75);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(402, 20);
            this.txtFile.TabIndex = 2;
            // 
            // btnImportSearch
            // 
            this.btnImportSearch.Location = new System.Drawing.Point(30, 117);
            this.btnImportSearch.Name = "btnImportSearch";
            this.btnImportSearch.Size = new System.Drawing.Size(402, 38);
            this.btnImportSearch.TabIndex = 3;
            this.btnImportSearch.Text = "Import";
            this.btnImportSearch.UseVisualStyleBackColor = true;
            this.btnImportSearch.Click += new System.EventHandler(this.btnImportSearch_Click);
            // 
            // btnCloseSearch
            // 
            this.btnCloseSearch.Location = new System.Drawing.Point(336, 177);
            this.btnCloseSearch.Name = "btnCloseSearch";
            this.btnCloseSearch.Size = new System.Drawing.Size(96, 22);
            this.btnCloseSearch.TabIndex = 4;
            this.btnCloseSearch.Text = "Close";
            this.btnCloseSearch.UseVisualStyleBackColor = true;
            this.btnCloseSearch.Click += new System.EventHandler(this.btnCloseSearch_Click);
            // 
            // ImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 211);
            this.Controls.Add(this.btnCloseSearch);
            this.Controls.Add(this.btnImportSearch);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportExcel";
            this.Text = "ImportExcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnImportSearch;
        private System.Windows.Forms.Button btnCloseSearch;
    }
}