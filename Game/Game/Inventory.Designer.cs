
namespace Game
{
    partial class Inventory
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_item = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(26, 13);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(45, 15);
            this.lbl_count.TabIndex = 0;
            this.lbl_count.Text = "label1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(26, 97);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 15);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "label2";
            // 
            // pic_item
            // 
            this.pic_item.Location = new System.Drawing.Point(18, 31);
            this.pic_item.Name = "pic_item";
            this.pic_item.Size = new System.Drawing.Size(62, 63);
            this.pic_item.TabIndex = 2;
            this.pic_item.TabStop = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_item);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_count);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(96, 124);
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_item;
    }
}
