
namespace LibraryBooks
{
    partial class Library
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
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxPublishedYear = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelPublishedYear = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonChooseCover = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(199, 77);
            this.textBoxBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(175, 29);
            this.textBoxBookName.TabIndex = 1;
            // 
            // textBoxPublishedYear
            // 
            this.textBoxPublishedYear.Location = new System.Drawing.Point(199, 123);
            this.textBoxPublishedYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPublishedYear.Name = "textBoxPublishedYear";
            this.textBoxPublishedYear.Size = new System.Drawing.Size(175, 29);
            this.textBoxPublishedYear.TabIndex = 2;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.Location = new System.Drawing.Point(35, 77);
            this.labelBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(93, 21);
            this.labelBookName.TabIndex = 19;
            this.labelBookName.Text = "BookName";
            // 
            // labelPublishedYear
            // 
            this.labelPublishedYear.AutoSize = true;
            this.labelPublishedYear.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublishedYear.Location = new System.Drawing.Point(35, 123);
            this.labelPublishedYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPublishedYear.Name = "labelPublishedYear";
            this.labelPublishedYear.Size = new System.Drawing.Size(122, 21);
            this.labelPublishedYear.TabIndex = 18;
            this.labelPublishedYear.Text = "Published Year";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(199, 28);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(175, 29);
            this.textBoxID.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(35, 32);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 21);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(21, 19);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(106, 47);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonChooseCover
            // 
            this.buttonChooseCover.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseCover.Location = new System.Drawing.Point(418, 217);
            this.buttonChooseCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChooseCover.Name = "buttonChooseCover";
            this.buttonChooseCover.Size = new System.Drawing.Size(167, 36);
            this.buttonChooseCover.TabIndex = 3;
            this.buttonChooseCover.Text = "Choose Cover";
            this.buttonChooseCover.UseVisualStyleBackColor = true;
            this.buttonChooseCover.Click += new System.EventHandler(this.buttonChooseCover_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxCover.Location = new System.Drawing.Point(420, 19);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(165, 190);
            this.pictureBoxCover.TabIndex = 13;
            this.pictureBoxCover.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(15, 299);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(823, 286);
            this.dataGridView.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Published Year";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cover";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(21, 79);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(106, 47);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(21, 195);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 47);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(21, 136);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(106, 47);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPublishedYear);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.labelPublishedYear);
            this.panel1.Controls.Add(this.labelBookName);
            this.panel1.Controls.Add(this.textBoxBookName);
            this.panel1.Controls.Add(this.buttonChooseCover);
            this.panel1.Controls.Add(this.pictureBoxCover);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 267);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonInsert);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Location = new System.Drawing.Point(679, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 267);
            this.panel2.TabIndex = 1;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxPublishedYear;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelPublishedYear;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonChooseCover;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

