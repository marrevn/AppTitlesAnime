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
            components = new System.ComponentModel.Container();
            flowLayoutPanelBotton = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill = new Panel();
            textBoxGenreName = new TextBox();
            labelGenreName = new Label();
            errorProvider1 = new ErrorProvider(components);
            flowLayoutPanelBotton.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            flowLayoutPanelBotton.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBotton.Size = new Size(434, 61);
            flowLayoutPanelBotton.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(116, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(135, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 35);
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
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(434, 85);
            panelFill.TabIndex = 0;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.Dock = DockStyle.Top;
            textBoxGenreName.Location = new Point(10, 35);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(404, 33);
            textBoxGenreName.TabIndex = 1;
            textBoxGenreName.TextChanged += TextBoxGenreName_TextChanged;
            textBoxGenreName.Validating += TextBoxGenreName_Validating;
            // 
            // labelGenreName
            // 
            labelGenreName.AutoSize = true;
            labelGenreName.Dock = DockStyle.Top;
            labelGenreName.Location = new Point(10, 10);
            labelGenreName.Name = "labelGenreName";
            labelGenreName.Size = new Size(123, 25);
            labelGenreName.TabIndex = 0;
            labelGenreName.Text = "Жанр аниме";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о жанре аниме";
            flowLayoutPanelBotton.ResumeLayout(false);
            flowLayoutPanelBotton.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelBotton;
        private Panel panelFill;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelGenreName;
        protected internal TextBox textBoxGenreName;
        private ErrorProvider errorProvider1;
    }
}