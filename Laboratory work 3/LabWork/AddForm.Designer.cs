namespace LabWork
{
    partial class AddForm
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
            titleLabel = new Label();
            dateLabel = new Label();
            organizerLabel = new Label();
            placeLabel = new Label();
            applicationDeadlineLabel = new Label();
            costLabel = new Label();
            txtDate = new TextBox();
            txtApplicationDeadline = new TextBox();
            txtOrganizer = new TextBox();
            btnAdd = new Button();
            txtCost = new TextBox();
            txtPlace = new TextBox();
            txtTitle = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(220, 56);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(44, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(140, 165);
            dateLabel.Margin = new Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(124, 25);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date and time";
            // 
            // organizerLabel
            // 
            organizerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            organizerLabel.AutoSize = true;
            organizerLabel.Location = new Point(175, 333);
            organizerLabel.Margin = new Padding(4, 0, 4, 0);
            organizerLabel.Name = "organizerLabel";
            organizerLabel.Size = new Size(89, 25);
            organizerLabel.TabIndex = 2;
            organizerLabel.Text = "Organizer";
            // 
            // placeLabel
            // 
            placeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            placeLabel.AutoSize = true;
            placeLabel.Location = new Point(212, 107);
            placeLabel.Margin = new Padding(4, 0, 4, 0);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(52, 25);
            placeLabel.TabIndex = 3;
            placeLabel.Text = "Place";
            // 
            // applicationDeadlineLabel
            // 
            applicationDeadlineLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            applicationDeadlineLabel.AutoSize = true;
            applicationDeadlineLabel.Location = new Point(90, 277);
            applicationDeadlineLabel.Margin = new Padding(4, 0, 4, 0);
            applicationDeadlineLabel.Name = "applicationDeadlineLabel";
            applicationDeadlineLabel.Size = new Size(174, 25);
            applicationDeadlineLabel.TabIndex = 4;
            applicationDeadlineLabel.Text = "Application deadline";
            // 
            // costLabel
            // 
            costLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            costLabel.AutoSize = true;
            costLabel.Location = new Point(216, 222);
            costLabel.Margin = new Padding(4, 0, 4, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(48, 25);
            costLabel.TabIndex = 5;
            costLabel.Text = "Cost";
            // 
            // txtDate
            // 
            txtDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDate.Location = new Point(282, 162);
            txtDate.Margin = new Padding(4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(256, 31);
            txtDate.TabIndex = 10;
            // 
            // txtApplicationDeadline
            // 
            txtApplicationDeadline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApplicationDeadline.Location = new Point(282, 274);
            txtApplicationDeadline.Margin = new Padding(4);
            txtApplicationDeadline.Name = "txtApplicationDeadline";
            txtApplicationDeadline.Size = new Size(256, 31);
            txtApplicationDeadline.TabIndex = 11;
            // 
            // txtOrganizer
            // 
            txtOrganizer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOrganizer.Location = new Point(282, 330);
            txtOrganizer.Margin = new Padding(4);
            txtOrganizer.Name = "txtOrganizer";
            txtOrganizer.Size = new Size(256, 31);
            txtOrganizer.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(282, 406);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 42);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add conference";
            btnAdd.TextAlign = ContentAlignment.TopCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // txtCost
            // 
            txtCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCost.Location = new Point(282, 219);
            txtCost.Margin = new Padding(4);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(109, 31);
            txtCost.TabIndex = 14;
            // 
            // txtPlace
            // 
            txtPlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPlace.Location = new Point(282, 104);
            txtPlace.Margin = new Padding(4);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(256, 31);
            txtPlace.TabIndex = 15;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(282, 53);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(256, 31);
            txtTitle.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(399, 222);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 17;
            label1.Text = "UAH";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 502);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(txtPlace);
            Controls.Add(txtCost);
            Controls.Add(btnAdd);
            Controls.Add(txtOrganizer);
            Controls.Add(txtApplicationDeadline);
            Controls.Add(txtDate);
            Controls.Add(costLabel);
            Controls.Add(applicationDeadlineLabel);
            Controls.Add(placeLabel);
            Controls.Add(organizerLabel);
            Controls.Add(dateLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(4);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label dateLabel;
        private Label organizerLabel;
        private Label placeLabel;
        private Label applicationDeadlineLabel;
        private Label costLabel;
        private TextBox txtDate;
        private TextBox txtApplicationDeadline;
        private TextBox txtOrganizer;
        private Button btnAdd;
        private TextBox txtCost;
        private TextBox txtPlace;
        private TextBox txtTitle;
        private Label label1;
    }
}