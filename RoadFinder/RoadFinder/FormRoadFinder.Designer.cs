namespace RoadFinder
{
    partial class FormRoadFinder
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.lviewFirst = new System.Windows.Forms.ListView();
            this.First = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewSecond = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewThird = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(15, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(116, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Map (.txt)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find Road";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxFrom
            // 
            this.cbxFrom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Location = new System.Drawing.Point(54, 58);
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(144, 23);
            this.cbxFrom.Sorted = true;
            this.cbxFrom.TabIndex = 6;
            this.cbxFrom.SelectedIndexChanged += new System.EventHandler(this.cbxFrom_SelectedIndexChanged);
            // 
            // cbxTo
            // 
            this.cbxTo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Location = new System.Drawing.Point(230, 57);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(144, 23);
            this.cbxTo.Sorted = true;
            this.cbxTo.TabIndex = 7;
            // 
            // lviewFirst
            // 
            this.lviewFirst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.First});
            this.lviewFirst.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewFirst.GridLines = true;
            this.lviewFirst.Location = new System.Drawing.Point(12, 112);
            this.lviewFirst.Name = "lviewFirst";
            this.lviewFirst.Size = new System.Drawing.Size(155, 222);
            this.lviewFirst.TabIndex = 9;
            this.lviewFirst.Tag = "";
            this.lviewFirst.TileSize = new System.Drawing.Size(30, 30);
            this.lviewFirst.UseCompatibleStateImageBehavior = false;
            this.lviewFirst.View = System.Windows.Forms.View.Details;
            // 
            // First
            // 
            this.First.Text = "Best Road";
            this.First.Width = 150;
            // 
            // lviewSecond
            // 
            this.lviewSecond.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lviewSecond.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewSecond.GridLines = true;
            this.lviewSecond.Location = new System.Drawing.Point(173, 112);
            this.lviewSecond.Name = "lviewSecond";
            this.lviewSecond.Size = new System.Drawing.Size(155, 222);
            this.lviewSecond.TabIndex = 10;
            this.lviewSecond.UseCompatibleStateImageBehavior = false;
            this.lviewSecond.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Second Best Road";
            this.columnHeader1.Width = 150;
            // 
            // lviewThird
            // 
            this.lviewThird.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lviewThird.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewThird.GridLines = true;
            this.lviewThird.Location = new System.Drawing.Point(334, 112);
            this.lviewThird.Name = "lviewThird";
            this.lviewThird.Size = new System.Drawing.Size(155, 222);
            this.lviewThird.TabIndex = 11;
            this.lviewThird.UseCompatibleStateImageBehavior = false;
            this.lviewThird.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Third Best Road";
            this.columnHeader2.Width = 150;
            // 
            // FormRoadFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 345);
            this.Controls.Add(this.lviewThird);
            this.Controls.Add(this.lviewSecond);
            this.Controls.Add(this.lviewFirst);
            this.Controls.Add(this.cbxTo);
            this.Controls.Add(this.cbxFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Name = "FormRoadFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Road Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxFrom;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.ListView lviewFirst;
        private System.Windows.Forms.ColumnHeader First;
        private System.Windows.Forms.ListView lviewSecond;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lviewThird;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

