namespace SectionA_Question3
{
    partial class Form1
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
            lblHeading = new Label();
            lstLanguages = new ListBox();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeading.Location = new Point(182, 21);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(516, 37);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "My Favourite Programming Languages";
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(221, 83);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(421, 184);
            lstLanguages.TabIndex = 1;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(221, 285);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.PlaceholderText = "Enter Programming Language";
            txtLanguage.Size = new Size(421, 23);
            txtLanguage.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(221, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(366, 329);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(139, 35);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblStatus.Location = new Point(221, 386);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 485);
            Controls.Add(lblStatus);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(lstLanguages);
            Controls.Add(lblHeading);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private ListBox lstLanguages;
        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblStatus;
    }
}
