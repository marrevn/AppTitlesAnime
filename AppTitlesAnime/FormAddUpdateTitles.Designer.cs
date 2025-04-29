namespace AppTitlesAnime
{
    partial class FormAddUpdateTitles
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
            panelFill = new Panel();
            textBoxOriginalName = new TextBox();
            labelOriginalName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            labelName = new Label();
            textBox1 = new TextBox();
            labelType = new Label();
            comboBoxType = new ComboBox();
            labelCountSeries = new Label();
            numericUpDowncountSeries = new NumericUpDown();
            labelDuration = new Label();
            numericUpDownDuration = new NumericUpDown();
            labelStudio = new Label();
            textBoxSeries = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDowncountSeries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxDescription);
            panelFill.Controls.Add(labelDescription);
            panelFill.Controls.Add(textBoxSeries);
            panelFill.Controls.Add(labelStudio);
            panelFill.Controls.Add(numericUpDownDuration);
            panelFill.Controls.Add(labelDuration);
            panelFill.Controls.Add(numericUpDowncountSeries);
            panelFill.Controls.Add(labelCountSeries);
            panelFill.Controls.Add(comboBoxType);
            panelFill.Controls.Add(labelType);
            panelFill.Controls.Add(textBox1);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(flowLayoutPanelBottom);
            panelFill.Controls.Add(textBoxOriginalName);
            panelFill.Controls.Add(labelOriginalName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(775, 579);
            panelFill.TabIndex = 1;
            // 
            // textBoxOriginalName
            // 
            textBoxOriginalName.Dock = DockStyle.Top;
            textBoxOriginalName.Location = new Point(10, 35);
            textBoxOriginalName.Name = "textBoxOriginalName";
            textBoxOriginalName.Size = new Size(745, 33);
            textBoxOriginalName.TabIndex = 1;
            // 
            // labelOriginalName
            // 
            labelOriginalName.AutoSize = true;
            labelOriginalName.Dock = DockStyle.Top;
            labelOriginalName.Location = new Point(10, 10);
            labelOriginalName.Name = "labelOriginalName";
            labelOriginalName.Size = new Size(178, 25);
            labelOriginalName.TabIndex = 0;
            labelOriginalName.Text = "Оригинальное имя";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(10, 508);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(745, 61);
            flowLayoutPanelBottom.TabIndex = 2;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 2;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(10, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(109, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Имя аниме";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(10, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(745, 33);
            textBox1.TabIndex = 4;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Top;
            labelType.Location = new Point(10, 126);
            labelType.Name = "labelType";
            labelType.Size = new Size(104, 25);
            labelType.TabIndex = 7;
            labelType.Text = "Тип аниме";
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Top;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(10, 151);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(745, 33);
            comboBoxType.TabIndex = 8;
            // 
            // labelCountSeries
            // 
            labelCountSeries.AutoSize = true;
            labelCountSeries.Dock = DockStyle.Top;
            labelCountSeries.Location = new Point(10, 184);
            labelCountSeries.Name = "labelCountSeries";
            labelCountSeries.Size = new Size(171, 25);
            labelCountSeries.TabIndex = 9;
            labelCountSeries.Text = "Количество серий";
            // 
            // numericUpDowncountSeries
            // 
            numericUpDowncountSeries.Dock = DockStyle.Top;
            numericUpDowncountSeries.Location = new Point(10, 209);
            numericUpDowncountSeries.Name = "numericUpDowncountSeries";
            numericUpDowncountSeries.Size = new Size(745, 33);
            numericUpDowncountSeries.TabIndex = 10;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Dock = DockStyle.Top;
            labelDuration.Location = new Point(10, 242);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(296, 25);
            labelDuration.TabIndex = 11;
            labelDuration.Text = "Продолжительность серии, мин.";
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Dock = DockStyle.Top;
            numericUpDownDuration.Location = new Point(10, 267);
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(745, 33);
            numericUpDownDuration.TabIndex = 12;
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.Dock = DockStyle.Top;
            labelStudio.Location = new Point(10, 300);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(72, 25);
            labelStudio.TabIndex = 13;
            labelStudio.Text = "Студия";
            // 
            // textBoxSeries
            // 
            textBoxSeries.Dock = DockStyle.Top;
            textBoxSeries.Location = new Point(10, 325);
            textBoxSeries.Name = "textBoxSeries";
            textBoxSeries.Size = new Size(745, 33);
            textBoxSeries.TabIndex = 14;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Location = new Point(10, 358);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(99, 25);
            labelDescription.TabIndex = 15;
            labelDescription.Text = "Описание";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Top;
            textBoxDescription.Location = new Point(10, 383);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(745, 33);
            textBoxDescription.TabIndex = 16;
            // 
            // FormAddUpdateTitles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(775, 579);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormAddUpdateTitles";
            Text = "Информация об аниме";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDowncountSeries).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        protected internal TextBox textBoxOriginalName;
        private Label labelOriginalName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelDuration;
        private NumericUpDown numericUpDowncountSeries;
        private Label labelCountSeries;
        private ComboBox comboBoxType;
        private Label labelType;
        protected internal TextBox textBox1;
        private Label labelName;
        protected internal TextBox textBoxDescription;
        private Label labelDescription;
        protected internal TextBox textBoxSeries;
        private Label labelStudio;
        private NumericUpDown numericUpDownDuration;
    }
}