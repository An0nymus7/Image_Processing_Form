namespace Image_Processing_Form
{
    partial class Main
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
            pb_original = new PictureBox();
            pb_processed = new PictureBox();
            btn_browse = new Button();
            btn_Gray = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_ScanFolder = new Button();
            btn_resize = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_original).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_processed).BeginInit();
            SuspendLayout();
            // 
            // pb_original
            // 
            pb_original.Dock = DockStyle.Left;
            pb_original.Location = new Point(0, 0);
            pb_original.Margin = new Padding(3, 2, 3, 2);
            pb_original.Name = "pb_original";
            pb_original.Size = new Size(456, 681);
            pb_original.TabIndex = 0;
            pb_original.TabStop = false;
            // 
            // pb_processed
            // 
            pb_processed.Dock = DockStyle.Right;
            pb_processed.Location = new Point(854, 0);
            pb_processed.Margin = new Padding(3, 2, 3, 2);
            pb_processed.Name = "pb_processed";
            pb_processed.Size = new Size(410, 681);
            pb_processed.TabIndex = 1;
            pb_processed.TabStop = false;
            // 
            // btn_browse
            // 
            btn_browse.Anchor = AnchorStyles.Left;
            btn_browse.Location = new Point(484, 154);
            btn_browse.Margin = new Padding(3, 2, 3, 2);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(81, 38);
            btn_browse.TabIndex = 2;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // btn_Gray
            // 
            btn_Gray.Anchor = AnchorStyles.Right;
            btn_Gray.Location = new Point(743, 414);
            btn_Gray.Margin = new Padding(3, 2, 3, 2);
            btn_Gray.Name = "btn_Gray";
            btn_Gray.Size = new Size(81, 38);
            btn_Gray.TabIndex = 3;
            btn_Gray.Text = "Gray";
            btn_Gray.UseVisualStyleBackColor = true;
            btn_Gray.Click += btn_Gray_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(659, 454);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 4;
            label1.Text = "sets the image grayscale------>";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(461, 193);
            label2.Name = "label2";
            label2.Size = new Size(184, 15);
            label2.TabIndex = 5;
            label2.Text = "<------ resized image but original";
            // 
            // btn_ScanFolder
            // 
            btn_ScanFolder.Anchor = AnchorStyles.None;
            btn_ScanFolder.Location = new Point(534, 281);
            btn_ScanFolder.Margin = new Padding(3, 2, 3, 2);
            btn_ScanFolder.Name = "btn_ScanFolder";
            btn_ScanFolder.Size = new Size(146, 61);
            btn_ScanFolder.TabIndex = 6;
            btn_ScanFolder.Text = "Select Folder for scan";
            btn_ScanFolder.UseVisualStyleBackColor = true;
            btn_ScanFolder.Click += btn_ScanFolder_Click;
            // 
            // btn_resize
            // 
            btn_resize.Anchor = AnchorStyles.Right;
            btn_resize.Location = new Point(743, 482);
            btn_resize.Margin = new Padding(3, 2, 3, 2);
            btn_resize.Name = "btn_resize";
            btn_resize.Size = new Size(81, 38);
            btn_resize.TabIndex = 7;
            btn_resize.Text = "Resize";
            btn_resize.UseVisualStyleBackColor = true;
            btn_resize.Click += btn_resize_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(659, 522);
            label3.Name = "label3";
            label3.Size = new Size(195, 15);
            label3.TabIndex = 8;
            label3.Text = "Resizes the image 1280x720  ------>";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label3);
            Controls.Add(btn_resize);
            Controls.Add(btn_ScanFolder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Gray);
            Controls.Add(btn_browse);
            Controls.Add(pb_processed);
            Controls.Add(pb_original);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1280, 720);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pb_original).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_processed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_original;
        private PictureBox pb_processed;
        private Button btn_browse;
        private Button btn_Gray;
        private Label label1;
        private Label label2;
        private Button btn_ScanFolder;
        private Button btn_resize;
        private Label label3;
    }
}