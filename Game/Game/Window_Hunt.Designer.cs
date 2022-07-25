
namespace Game
{
    partial class Window_Hunt
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
            this.btn_squ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_negu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_piz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_squ
            // 
            this.btn_squ.Location = new System.Drawing.Point(117, 36);
            this.btn_squ.Name = "btn_squ";
            this.btn_squ.Size = new System.Drawing.Size(159, 42);
            this.btn_squ.TabIndex = 0;
            this.btn_squ.Text = "사냥하기";
            this.btn_squ.UseVisualStyleBackColor = true;
            this.btn_squ.Click += new System.EventHandler(this.btn_squ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "다람쥐";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "토끼";
            // 
            // btn_rab
            // 
            this.btn_rab.Location = new System.Drawing.Point(117, 84);
            this.btn_rab.Name = "btn_rab";
            this.btn_rab.Size = new System.Drawing.Size(159, 42);
            this.btn_rab.TabIndex = 2;
            this.btn_rab.Text = "사냥하기";
            this.btn_rab.UseVisualStyleBackColor = true;
            this.btn_rab.Click += new System.EventHandler(this.btn_rab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "너구리";
            // 
            // btn_negu
            // 
            this.btn_negu.Location = new System.Drawing.Point(117, 132);
            this.btn_negu.Name = "btn_negu";
            this.btn_negu.Size = new System.Drawing.Size(159, 42);
            this.btn_negu.TabIndex = 4;
            this.btn_negu.Text = "사냥하기";
            this.btn_negu.UseVisualStyleBackColor = true;
            this.btn_negu.Click += new System.EventHandler(this.btn_negu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "비둘기";
            // 
            // btn_piz
            // 
            this.btn_piz.Location = new System.Drawing.Point(117, 180);
            this.btn_piz.Name = "btn_piz";
            this.btn_piz.Size = new System.Drawing.Size(159, 42);
            this.btn_piz.TabIndex = 6;
            this.btn_piz.Text = "사냥하기";
            this.btn_piz.UseVisualStyleBackColor = true;
            this.btn_piz.Click += new System.EventHandler(this.btn_piz_Click);
            // 
            // Window_Hunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_piz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_negu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_squ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Hunt";
            this.Text = "Window_Hunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_squ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_negu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_piz;
    }
}