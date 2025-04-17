namespace AppTitlesAnime
{
    partial class FormListGenre
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
            btnAddGenre = new Button();
            btnUpdateGenre = new Button();
            btnDeleteGenre = new Button();
            dataGridViewGenre = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(btnAddGenre);
            flowLayoutPanelTop.Controls.Add(btnUpdateGenre);
            flowLayoutPanelTop.Controls.Add(btnDeleteGenre);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnAddGenre
            // 
            btnAddGenre.AutoSize = true;
            btnAddGenre.Location = new Point(13, 13);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(106, 35);
            btnAddGenre.TabIndex = 0;
            btnAddGenre.Text = "Добавить";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += BtnAddGenre_Click;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.AutoSize = true;
            btnUpdateGenre.Location = new Point(125, 13);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(151, 35);
            btnUpdateGenre.TabIndex = 1;
            btnUpdateGenre.Text = "Редактировать";
            btnUpdateGenre.UseVisualStyleBackColor = true;
            btnUpdateGenre.Click += BtnUpdateGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.AutoSize = true;
            btnDeleteGenre.Location = new Point(282, 13);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(92, 35);
            btnDeleteGenre.TabIndex = 2;
            btnDeleteGenre.Text = "Удалить";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += BtnDeleteGenre_Click;
            // 
            // dataGridViewGenre
            // 
            dataGridViewGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenre.BackgroundColor = Color.White;
            dataGridViewGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenre.Dock = DockStyle.Fill;
            dataGridViewGenre.Location = new Point(10, 10);
            dataGridViewGenre.MultiSelect = false;
            dataGridViewGenre.Name = "dataGridViewGenre";
            dataGridViewGenre.ReadOnly = true;
            dataGridViewGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenre.Size = new Size(914, 430);
            dataGridViewGenre.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewGenre);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 450);
            panelFill.TabIndex = 2;
            // 
            // FormListGenre
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListGenre";
            Text = "Список жанров аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddGenre;
        private Button btnUpdateGenre;
        private Button btnDeleteGenre;
        private DataGridView dataGridViewGenre;
        private Panel panelFill;
    }
}