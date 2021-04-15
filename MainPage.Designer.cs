namespace Simon_Says
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.ask_txt = new System.Windows.Forms.TextBox();
            this.question_txt = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.ask_lbl = new System.Windows.Forms.Label();
            this.question_lbl = new System.Windows.Forms.Label();
            this.howto_btn = new System.Windows.Forms.Button();
            this.warning_pic = new System.Windows.Forms.PictureBox();
            this.warning_tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.warning_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ask_txt
            // 
            this.ask_txt.Location = new System.Drawing.Point(12, 94);
            this.ask_txt.Name = "ask_txt";
            this.ask_txt.Size = new System.Drawing.Size(352, 20);
            this.ask_txt.TabIndex = 0;
            this.ask_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ask_txt_KeyPress);
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(12, 160);
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(352, 20);
            this.question_txt.TabIndex = 1;
            this.question_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.question_txt_KeyDown);
            // 
            // title_lbl
            // 
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lbl.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(376, 51);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Simon Says";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ask_lbl
            // 
            this.ask_lbl.AutoSize = true;
            this.ask_lbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ask_lbl.Location = new System.Drawing.Point(12, 62);
            this.ask_lbl.Name = "ask_lbl";
            this.ask_lbl.Size = new System.Drawing.Size(308, 29);
            this.ask_lbl.TabIndex = 3;
            this.ask_lbl.Text = "Request Simon to answer you. ";
            // 
            // question_lbl
            // 
            this.question_lbl.AutoSize = true;
            this.question_lbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_lbl.Location = new System.Drawing.Point(12, 128);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(254, 29);
            this.question_lbl.TabIndex = 4;
            this.question_lbl.Text = "Your question for Simon.";
            // 
            // howto_btn
            // 
            this.howto_btn.ForeColor = System.Drawing.Color.Black;
            this.howto_btn.Location = new System.Drawing.Point(309, 201);
            this.howto_btn.Name = "howto_btn";
            this.howto_btn.Size = new System.Drawing.Size(55, 23);
            this.howto_btn.TabIndex = 5;
            this.howto_btn.Text = "How to?";
            this.howto_btn.UseVisualStyleBackColor = true;
            this.howto_btn.Click += new System.EventHandler(this.howto_btn_Click);
            // 
            // warning_pic
            // 
            this.warning_pic.ErrorImage = null;
            this.warning_pic.Image = ((System.Drawing.Image)(resources.GetObject("warning_pic.Image")));
            this.warning_pic.InitialImage = null;
            this.warning_pic.Location = new System.Drawing.Point(8, 188);
            this.warning_pic.Name = "warning_pic";
            this.warning_pic.Size = new System.Drawing.Size(59, 36);
            this.warning_pic.TabIndex = 6;
            this.warning_pic.TabStop = false;
            this.warning_pic.MouseHover += new System.EventHandler(this.warning_pic_MouseHover);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(376, 236);
            this.Controls.Add(this.warning_pic);
            this.Controls.Add(this.howto_btn);
            this.Controls.Add(this.question_lbl);
            this.Controls.Add(this.ask_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.question_txt);
            this.Controls.Add(this.ask_txt);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon Says";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warning_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ask_txt;
        private System.Windows.Forms.TextBox question_txt;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label ask_lbl;
        private System.Windows.Forms.Label question_lbl;
        private System.Windows.Forms.Button howto_btn;
        private System.Windows.Forms.PictureBox warning_pic;
        private System.Windows.Forms.ToolTip warning_tip;
    }
}

