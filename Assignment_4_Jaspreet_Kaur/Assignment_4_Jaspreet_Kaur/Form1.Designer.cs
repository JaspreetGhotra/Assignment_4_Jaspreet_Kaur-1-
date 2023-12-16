namespace Assignment_4_Jaspreet_Kaur
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
            RockClick = new Button();
            PaperClick = new Button();
            ScissorClick = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RockClick
            // 
            RockClick.BackColor = SystemColors.ActiveCaption;
            RockClick.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RockClick.ForeColor = SystemColors.InactiveCaptionText;
            RockClick.Location = new Point(108, 190);
            RockClick.Name = "RockClick";
            RockClick.Size = new Size(75, 57);
            RockClick.TabIndex = 0;
            RockClick.Text = "Rock";
            RockClick.UseVisualStyleBackColor = false;
            RockClick.Click += button1_Click;
            // 
            // PaperClick
            // 
            PaperClick.BackColor = SystemColors.ActiveCaption;
            PaperClick.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PaperClick.Location = new Point(332, 363);
            PaperClick.Name = "PaperClick";
            PaperClick.Size = new Size(75, 57);
            PaperClick.TabIndex = 1;
            PaperClick.Text = "Paper";
            PaperClick.UseVisualStyleBackColor = false;
            PaperClick.Click += PaperClick_Click;
            // 
            // ScissorClick
            // 
            ScissorClick.BackColor = SystemColors.ActiveCaption;
            ScissorClick.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ScissorClick.Location = new Point(622, 190);
            ScissorClick.Name = "ScissorClick";
            ScissorClick.Size = new Size(75, 57);
            ScissorClick.TabIndex = 2;
            ScissorClick.Text = "Scissor";
            ScissorClick.UseVisualStyleBackColor = false;
            ScissorClick.Click += ScissorClick_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(260, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 113);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 72);
            label1.TabIndex = 4;
            label1.Text = "Let's Play";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(821, 455);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ScissorClick);
            Controls.Add(PaperClick);
            Controls.Add(RockClick);
            Name = "Form1";
            Text = "Rock,Paper,Scissor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RockClick;
        private Button PaperClick;
        private Button ScissorClick;
        private PictureBox pictureBox1;
        private Label label1;
    }
}