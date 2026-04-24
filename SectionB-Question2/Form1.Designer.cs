namespace SectionB_Question2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            cmbCitizenship = new ComboBox();
            lblName = new Label();
            lblId = new Label();
            lblCitizen = new Label();
            btnValidate = new Button();
            lblValidationResult = new Label();
            txtResults = new TextBox();
            btnGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeading.ForeColor = Color.Green;
            lblHeading.Location = new Point(326, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(522, 37);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Home Affairs Digital Identity Processor";
            // 
            // txtName
            // 
            txtName.Location = new Point(479, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 23);
            txtName.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(479, 138);
            txtId.Name = "txtId";
            txtId.Size = new Size(285, 23);
            txtId.TabIndex = 3;
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Items.AddRange(new object[] { "South African", "Citizen", "Permanent Resident", "Visitor" });
            cmbCitizenship.Location = new Point(479, 194);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(285, 23);
            cmbCitizenship.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(377, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Enter your name:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(376, 141);
            lblId.Name = "lblId";
            lblId.Size = new Size(78, 15);
            lblId.TabIndex = 6;
            lblId.Text = "Enter your ID:";
            // 
            // lblCitizen
            // 
            lblCitizen.AutoSize = true;
            lblCitizen.Location = new Point(355, 197);
            lblCitizen.Name = "lblCitizen";
            lblCitizen.Size = new Size(119, 15);
            lblCitizen.TabIndex = 7;
            lblCitizen.Text = "Choose your Citizen: ";
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.Green;
            btnValidate.ForeColor = Color.White;
            btnValidate.Location = new Point(531, 249);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(135, 23);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblValidationResult
            // 
            lblValidationResult.AutoSize = true;
            lblValidationResult.Location = new Point(531, 296);
            lblValidationResult.Name = "lblValidationResult";
            lblValidationResult.Size = new Size(0, 15);
            lblValidationResult.TabIndex = 9;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(469, 314);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(270, 194);
            txtResults.TabIndex = 10;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Green;
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(531, 514);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(135, 23);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(878, 577);
            Controls.Add(btnGenerate);
            Controls.Add(txtResults);
            Controls.Add(lblValidationResult);
            Controls.Add(btnValidate);
            Controls.Add(lblCitizen);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(cmbCitizenship);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private TextBox txtName;
        private TextBox txtId;
        private ComboBox cmbCitizenship;
        private Label lblName;
        private Label lblId;
        private Label lblCitizen;
        private Button btnValidate;
        private Label lblValidationResult;
        private TextBox txtResults;
        private Button btnGenerate;
    }
}
