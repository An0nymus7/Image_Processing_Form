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
            this.pb_original.Location = new System.Drawing.Point(0, 0);
            this.pb_original.Name = "pb_original";
            this.pb_original.Size = new System.Drawing.Size(424, 690);
            this.pb_original.TabIndex = 0;
            this.pb_original.TabStop = false;
            // 
            // pb_processed
            // 
            this.pb_processed.Location = new System.Drawing.Point(583, 0);
            this.pb_processed.Name = "pb_processed";
            this.pb_processed.Size = new System.Drawing.Size(413, 690);
            this.pb_processed.TabIndex = 1;
            this.pb_processed.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(456, 96);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(93, 50);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_Gray
            // 
            this.btn_Gray.Location = new System.Drawing.Point(456, 450);
            this.btn_Gray.Name = "btn_Gray";
            this.btn_Gray.Size = new System.Drawing.Size(93, 50);
            this.btn_Gray.TabIndex = 3;
            this.btn_Gray.Text = "Gray";
            this.btn_Gray.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "------>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "<------ resized image but original";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 690);
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