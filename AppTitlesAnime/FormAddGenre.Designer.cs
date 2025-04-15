namespace AppTitlesAnime
{
    partial class FormAddGenre
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
            flowLayoutPanelBotton = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill = new Panel();
            textBoxGenreName = new TextBox();
            labelGenreName = new Label();
            flowLayoutPanelBotton.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBotton
            // 
            flowLayoutPanelBotton.AutoSize = true;
            flowLayoutPanelBotton.Controls.Add(btnSaveChanges);
            flowLayoutPanelBotton.Controls.Add(btnCancel);
            flowLayoutPanelBotton.Dock = DockStyle.Bottom;
            flowLayoutPanelBotton.Location = new Point(0, 85);
            flowLayoutPanelBotton.Name = "flowLayoutPanelBotton";
            flowLayoutPanelBotton.Padding = new Padding(10);
            flowLayoutPanelBotton.Size = new Size(434, 61);
            flowLayoutPanelBotton.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxGenreName);
            panelFill.Controls.Add(labelGenreName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(434, 85);
            panelFill.TabIndex = 2;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.Dock = DockStyle.Top;
            textBoxGenreName.Location = new Point(10, 35);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(414, 33);
            textBoxGenreName.TabIndex = 1;
            // 
            // labelGenreName
            // 
            labelGenreName.AutoSize = true;
            labelGenreName.Dock = DockStyle.Top;
            labelGenreName.Location = new Point(10, 10);
            labelGenreName.Name = "labelGenreName";
            labelGenreName.Size = new Size(120, 25);
            labelGenreName.TabIndex = 0;
            labelGenreName.Text = "Жанр аниме";
            // 
            // FormAddGenre
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 146);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBotton);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddGenre";
            Text = "Информация о жанре аниме";
            flowLayoutPanelBotton.ResumeLayout(false);
            flowLayoutPanelBotton.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelBotton;
        private Panel panelFill;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelGenreName;
        private TextBox textBoxGenreName;
    }
}