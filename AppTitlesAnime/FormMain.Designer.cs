namespace AppTitlesAnime
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowTypes = new Button();
            btnShowGenre = new Button();
            btnShowStatus = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnShowTitles = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.Location = new Point(13, 13);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(313, 35);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Отобразить список \"Типы аниме\"";
            btnShowTypes.UseVisualStyleBackColor = true;
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // btnShowGenre
            // 
            btnShowGenre.AutoSize = true;
            btnShowGenre.Location = new Point(13, 95);
            btnShowGenre.Name = "btnShowGenre";
            btnShowGenre.Size = new Size(329, 35);
            btnShowGenre.TabIndex = 1;
            btnShowGenre.Text = "Отобразить список \"Жанры аниме\"";
            btnShowGenre.UseVisualStyleBackColor = true;
            btnShowGenre.Click += BtnShowGenre_Click;
            // 
            // btnShowStatus
            // 
            btnShowStatus.AutoSize = true;
            btnShowStatus.Location = new Point(13, 136);
            btnShowStatus.Name = "btnShowStatus";
            btnShowStatus.Size = new Size(324, 35);
            btnShowStatus.TabIndex = 2;
            btnShowStatus.Text = "Отобразить список \"Статус аниме\"";
            btnShowStatus.UseVisualStyleBackColor = true;
            btnShowStatus.Click += BtnShowStatus_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnShowTypes);
            flowLayoutPanel1.Controls.Add(btnShowTitles);
            flowLayoutPanel1.Controls.Add(btnShowGenre);
            flowLayoutPanel1.Controls.Add(btnShowStatus);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(845, 409);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnShowTitles
            // 
            btnShowTitles.AutoSize = true;
            btnShowTitles.Location = new Point(13, 54);
            btnShowTitles.Name = "btnShowTitles";
            btnShowTitles.Size = new Size(330, 35);
            btnShowTitles.TabIndex = 2;
            btnShowTitles.Text = "Отобразить список \"Аниме\"";
            btnShowTitles.UseVisualStyleBackColor = true;
            btnShowTitles.Click += BtnShowTitles_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(845, 409);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowTypes;
        private Button btnShowGenre;
        private Button btnShowStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnShowTitles;
    }
}
