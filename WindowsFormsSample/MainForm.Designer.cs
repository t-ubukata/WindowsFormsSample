using System.Data;
using System.Windows.Forms;

namespace WindowsFormsSample
{
    partial class MainForm
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
            this.stadiums = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ボートレース場 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.都道府県 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stadiums)).BeginInit();
            this.SuspendLayout();
            // 
            // stadiums
            // 
            this.stadiums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stadiums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ボートレース場,
            this.都道府県});
            this.stadiums.Location = new System.Drawing.Point(200, 12);
            this.stadiums.Name = "stadiums";
            this.stadiums.Size = new System.Drawing.Size(343, 648);
            this.stadiums.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Name = "ID";
            // 
            // ボートレース場
            // 
            this.ボートレース場.Name = "ボートレース場";
            // 
            // 都道府県
            // 
            this.都道府県.Name = "都道府県";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.stadiums);
            this.Name = "MainForm";
            this.Text = "BoatRace";
            ((System.ComponentModel.ISupportInitialize)(this.stadiums)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DataGridView stadiums;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ボートレース場;
        private DataGridViewTextBoxColumn 都道府県;
    }
}

