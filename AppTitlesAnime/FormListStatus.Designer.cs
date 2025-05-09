﻿namespace AppTitlesAnime
{
    partial class FormListStatus
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddStatus = new Button();
            btnUpdateStatus = new Button();
            btnDeleteStatus = new Button();
            dataGridViewStatus = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(btnAddStatus);
            flowLayoutPanelTop.Controls.Add(btnUpdateStatus);
            flowLayoutPanelTop.Controls.Add(btnDeleteStatus);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnAddStatus
            // 
            btnAddStatus.AutoSize = true;
            btnAddStatus.Location = new Point(13, 13);
            btnAddStatus.Name = "btnAddStatus";
            btnAddStatus.Size = new Size(108, 35);
            btnAddStatus.TabIndex = 0;
            btnAddStatus.Text = "Добавить";
            btnAddStatus.UseVisualStyleBackColor = true;
            btnAddStatus.Click += BtnAddStatus_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.AutoSize = true;
            btnUpdateStatus.Location = new Point(127, 13);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(153, 35);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Редактировать";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // btnDeleteStatus
            // 
            btnDeleteStatus.AutoSize = true;
            btnDeleteStatus.Location = new Point(286, 13);
            btnDeleteStatus.Name = "btnDeleteStatus";
            btnDeleteStatus.Size = new Size(92, 35);
            btnDeleteStatus.TabIndex = 2;
            btnDeleteStatus.Text = "Удалить";
            btnDeleteStatus.UseVisualStyleBackColor = true;
            btnDeleteStatus.Click += BtnDeleteStatus_Click;
            // 
            // dataGridViewStatus
            // 
            dataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatus.BackgroundColor = Color.White;
            dataGridViewStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatus.Dock = DockStyle.Fill;
            dataGridViewStatus.Location = new Point(10, 10);
            dataGridViewStatus.MultiSelect = false;
            dataGridViewStatus.Name = "dataGridViewStatus";
            dataGridViewStatus.ReadOnly = true;
            dataGridViewStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatus.Size = new Size(914, 430);
            dataGridViewStatus.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewStatus);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 450);
            panelFill.TabIndex = 2;
            // 
            // FormListStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список статусов аниме";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddStatus;
        private Button btnUpdateStatus;
        private Button btnDeleteStatus;
        private DataGridView dataGridViewStatus;
        private Panel panelFill;
    }
}