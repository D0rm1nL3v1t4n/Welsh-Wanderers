﻿namespace WelshWanderers
{
    partial class UpcomingTrainings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableViewTrainings = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.NavHome = new System.Windows.Forms.Button();
            this.NavEdit = new System.Windows.Forms.Button();
            this.InputFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewTrainings)).BeginInit();
            this.SuspendLayout();
            // 
            // TableViewTrainings
            // 
            this.TableViewTrainings.AllowUserToAddRows = false;
            this.TableViewTrainings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableViewTrainings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableViewTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableViewTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColTeam,
            this.ColTime,
            this.ColDuration,
            this.ColDate});
            this.TableViewTrainings.Location = new System.Drawing.Point(12, 97);
            this.TableViewTrainings.Name = "TableViewTrainings";
            this.TableViewTrainings.ReadOnly = true;
            this.TableViewTrainings.RowHeadersVisible = false;
            this.TableViewTrainings.RowHeadersWidth = 10;
            this.TableViewTrainings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableViewTrainings.ShowCellToolTips = false;
            this.TableViewTrainings.Size = new System.Drawing.Size(413, 228);
            this.TableViewTrainings.TabIndex = 1;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 35;
            // 
            // ColTeam
            // 
            this.ColTeam.HeaderText = "Team";
            this.ColTeam.Name = "ColTeam";
            this.ColTeam.ReadOnly = true;
            this.ColTeam.Width = 90;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            this.ColTime.Width = 80;
            // 
            // ColDuration
            // 
            this.ColDuration.HeaderText = "Duration (min)";
            this.ColDuration.Name = "ColDuration";
            this.ColDuration.ReadOnly = true;
            this.ColDuration.Width = 120;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            this.ColDate.Width = 120;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(156, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(124, 33);
            this.LabelHeader.TabIndex = 17;
            this.LabelHeader.Text = "Trainings";
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(12, 12);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(66, 30);
            this.NavHome.TabIndex = 3;
            this.NavHome.Text = "Back";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // NavEdit
            // 
            this.NavEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavEdit.Location = new System.Drawing.Point(328, 331);
            this.NavEdit.Name = "NavEdit";
            this.NavEdit.Size = new System.Drawing.Size(97, 30);
            this.NavEdit.TabIndex = 2;
            this.NavEdit.Text = "View";
            this.NavEdit.UseVisualStyleBackColor = true;
            this.NavEdit.Click += new System.EventHandler(this.NavEdit_Click);
            // 
            // InputFilter
            // 
            this.InputFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFilter.FormattingEnabled = true;
            this.InputFilter.Items.AddRange(new object[] {
            "All",
            "Upcoming",
            "Past"});
            this.InputFilter.Location = new System.Drawing.Point(12, 64);
            this.InputFilter.Name = "InputFilter";
            this.InputFilter.Size = new System.Drawing.Size(170, 27);
            this.InputFilter.TabIndex = 0;
            this.InputFilter.SelectedIndexChanged += new System.EventHandler(this.InputFilter_SelectedIndexChanged);
            // 
            // UpcomingTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 372);
            this.Controls.Add(this.InputFilter);
            this.Controls.Add(this.NavEdit);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.TableViewTrainings);
            this.Name = "UpcomingTrainings";
            this.Text = "ViewTraining";
            this.Load += new System.EventHandler(this.ViewTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableViewTrainings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableViewTrainings;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button NavEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.ComboBox InputFilter;
    }
}