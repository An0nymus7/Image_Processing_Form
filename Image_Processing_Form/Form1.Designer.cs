namespace Image_Processing_Form
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
            this.pb_original = new System.Windows.Forms.PictureBox();
            this.pb_processed = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_Gray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_processed)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_original
            // 
            this.pb_original.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_original.Location = new System.Drawing.Point(0, 0);
            this.pb_original.Name = "pb_original";
            this.pb_original.Size = new System.Drawing.Size(521, 690);
            this.pb_original.TabIndex = 0;
            this.pb_original.TabStop = false;
            // 
            // pb_processed
            // 
            this.pb_processed.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_processed.Location = new System.Drawing.Point(833, 0);
            this.pb_processed.Name = "pb_processed";
            this.pb_processed.Size = new System.Drawing.Size(469, 690);
            this.pb_processed.TabIndex = 1;
            this.pb_processed.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_browse.Location = new System.Drawing.Point(553, 97);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(93, 50);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_Gray
            // 
            this.btn_Gray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Gray.Location = new System.Drawing.Point(706, 444);
            this.btn_Gray.Name = "btn_Gray";
            this.btn_Gray.Size = new System.Drawing.Size(93, 50);
            this.btn_Gray.TabIndex = 3;
            this.btn_Gray.Text = "Gray";
            this.btn_Gray.UseVisualStyleBackColor = true;
            this.btn_Gray.Click += new System.EventHandler(this.btn_Gray_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "sets the image grayscale------>";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "<------ resized image but original";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gray);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pb_processed);
            this.Controls.Add(this.pb_original);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_processed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_original;
        private PictureBox pb_processed;
        private Button btn_browse;
        private Button btn_Gray;
        private Label label1;
        private Label label2;
    }
}