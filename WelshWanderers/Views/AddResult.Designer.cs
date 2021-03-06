﻿namespace WelshWanderers
{
    partial class AddResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TableAddMatchResult = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMajors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOther = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.InputOpponentMajorFouls = new System.Windows.Forms.TextBox();
            this.InputOpponentGoals = new System.Windows.Forms.TextBox();
            this.LabelOpponentMajorFouls = new System.Windows.Forms.Label();
            this.LabelOpponentGoals = new System.Windows.Forms.Label();
            this.NavCancel = new System.Windows.Forms.Button();
            this.EventNavSave = new System.Windows.Forms.Button();
            this.LabelOpponent = new System.Windows.Forms.Label();
            this.InputOpponent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableAddMatchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(190, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(142, 33);
            this.LabelHeader.TabIndex = 9;
            this.LabelHeader.Text = "Add Result";
            // 
            // TableAddMatchResult
            // 
            this.TableAddMatchResult.AllowUserToAddRows = false;
            this.TableAddMatchResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableAddMatchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableAddMatchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAddMatchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColPlayerName,
            this.ColGoals,
            this.ColMajors,
            this.ColOther});
            this.TableAddMatchResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TableAddMatchResult.Location = new System.Drawing.Point(12, 127);
            this.TableAddMatchResult.Name = "TableAddMatchResult";
            this.TableAddMatchResult.RowHeadersVisible = false;
            this.TableAddMatchResult.RowHeadersWidth = 10;
            this.TableAddMatchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableAddMatchResult.ShowCellToolTips = false;
            this.TableAddMatchResult.Size = new System.Drawing.Size(498, 251);
            this.TableAddMatchResult.TabIndex = 2;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 40;
            // 
            // ColPlayerName
            // 
            this.ColPlayerName.HeaderText = "Player";
            this.ColPlayerName.Name = "ColPlayerName";
            this.ColPlayerName.ReadOnly = true;
            this.ColPlayerName.Width = 140;
            // 
            // ColGoals
            // 
            this.ColGoals.HeaderText = "Goals";
            this.ColGoals.Name = "ColGoals";
            this.ColGoals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColGoals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColMajors
            // 
            this.ColMajors.HeaderText = "Major Fouls";
            this.ColMajors.Name = "ColMajors";
            this.ColMajors.Width = 120;
            // 
            // ColOther
            // 
            this.ColOther.HeaderText = "Other";
            this.ColOther.Items.AddRange(new object[] {
            "None",
            "Brutality",
            "Wrapped",
            "Yellow Card",
            "Red Card"});
            this.ColOther.Name = "ColOther";
            this.ColOther.Width = 135;
            // 
            // InputOpponentMajorFouls
            // 
            this.InputOpponentMajorFouls.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponentMajorFouls.Location = new System.Drawing.Point(410, 94);
            this.InputOpponentMajorFouls.Name = "InputOpponentMajorFouls";
            this.InputOpponentMajorFouls.Size = new System.Drawing.Size(100, 27);
            this.InputOpponentMajorFouls.TabIndex = 1;
            // 
            // InputOpponentGoals
            // 
            this.InputOpponentGoals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponentGoals.Location = new System.Drawing.Point(129, 94);
            this.InputOpponentGoals.Name = "InputOpponentGoals";
            this.InputOpponentGoals.Size = new System.Drawing.Size(100, 27);
            this.InputOpponentGoals.TabIndex = 0;
            // 
            // LabelOpponentMajorFouls
            // 
            this.LabelOpponentMajorFouls.AutoSize = true;
            this.LabelOpponentMajorFouls.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponentMajorFouls.Location = new System.Drawing.Point(252, 97);
            this.LabelOpponentMajorFouls.Name = "LabelOpponentMajorFouls";
            this.LabelOpponentMajorFouls.Size = new System.Drawing.Size(152, 18);
            this.LabelOpponentMajorFouls.TabIndex = 8;
            this.LabelOpponentMajorFouls.Text = "Opponent Major Fouls";
            // 
            // LabelOpponentGoals
            // 
            this.LabelOpponentGoals.AutoSize = true;
            this.LabelOpponentGoals.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponentGoals.Location = new System.Drawing.Point(12, 97);
            this.LabelOpponentGoals.Name = "LabelOpponentGoals";
            this.LabelOpponentGoals.Size = new System.Drawing.Size(112, 18);
            this.LabelOpponentGoals.TabIndex = 7;
            this.LabelOpponentGoals.Text = "Opponent Goals";
            // 
            // NavCancel
            // 
            this.NavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavCancel.Location = new System.Drawing.Point(12, 12);
            this.NavCancel.Name = "NavCancel";
            this.NavCancel.Size = new System.Drawing.Size(89, 30);
            this.NavCancel.TabIndex = 4;
            this.NavCancel.Text = "Cancel";
            this.NavCancel.UseVisualStyleBackColor = true;
            this.NavCancel.Click += new System.EventHandler(this.NavCancel_Click);
            // 
            // EventNavSave
            // 
            this.EventNavSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSave.Location = new System.Drawing.Point(421, 12);
            this.EventNavSave.Name = "EventNavSave";
            this.EventNavSave.Size = new System.Drawing.Size(89, 30);
            this.EventNavSave.TabIndex = 3;
            this.EventNavSave.Text = "Save";
            this.EventNavSave.UseVisualStyleBackColor = true;
            this.EventNavSave.Click += new System.EventHandler(this.EventNavSave_Click);
            // 
            // LabelOpponent
            // 
            this.LabelOpponent.AutoSize = true;
            this.LabelOpponent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponent.Location = new System.Drawing.Point(12, 65);
            this.LabelOpponent.Name = "LabelOpponent";
            this.LabelOpponent.Size = new System.Drawing.Size(72, 18);
            this.LabelOpponent.TabIndex = 6;
            this.LabelOpponent.Text = "Opponent";
            // 
            // InputOpponent
            // 
            this.InputOpponent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponent.Location = new System.Drawing.Point(90, 61);
            this.InputOpponent.Name = "InputOpponent";
            this.InputOpponent.ReadOnly = true;
            this.InputOpponent.Size = new System.Drawing.Size(139, 27);
            this.InputOpponent.TabIndex = 5;
            // 
            // AddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 391);
            this.Controls.Add(this.LabelOpponent);
            this.Controls.Add(this.InputOpponent);
            this.Controls.Add(this.EventNavSave);
            this.Controls.Add(this.NavCancel);
            this.Controls.Add(this.LabelOpponentGoals);
            this.Controls.Add(this.LabelOpponentMajorFouls);
            this.Controls.Add(this.InputOpponentGoals);
            this.Controls.Add(this.InputOpponentMajorFouls);
            this.Controls.Add(this.TableAddMatchResult);
            this.Controls.Add(this.LabelHeader);
            this.Name = "AddResult";
            this.Text = "AddResult";
            this.Load += new System.EventHandler(this.AddResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableAddMatchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableAddMatchResult;
        private System.Windows.Forms.TextBox InputOpponentMajorFouls;
        private System.Windows.Forms.TextBox InputOpponentGoals;
        private System.Windows.Forms.Label LabelOpponentMajorFouls;
        private System.Windows.Forms.Label LabelOpponentGoals;
        private System.Windows.Forms.Button NavCancel;
        private System.Windows.Forms.Button EventNavSave;
        private System.Windows.Forms.Label LabelOpponent;
        private System.Windows.Forms.TextBox InputOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMajors;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColOther;
    }
}