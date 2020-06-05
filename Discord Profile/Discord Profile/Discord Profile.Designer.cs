namespace Discord_Profile
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labToken = new System.Windows.Forms.Label();
            this.TOKEN = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labToken
            // 
            this.labToken.AutoSize = true;
            this.labToken.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToken.Location = new System.Drawing.Point(32, 107);
            this.labToken.Name = "labToken";
            this.labToken.Size = new System.Drawing.Size(54, 23);
            this.labToken.TabIndex = 0;
            this.labToken.Text = "Token";
            // 
            // TOKEN
            // 
            this.TOKEN.AutoSize = true;
            this.TOKEN.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOKEN.Location = new System.Drawing.Point(29, 66);
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.Size = new System.Drawing.Size(91, 37);
            this.TOKEN.TabIndex = 1;
            this.TOKEN.Text = "Token";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(29, 171);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(39, 37);
            this.ID.TabIndex = 3;
            this.ID.Text = "Id";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labId.Location = new System.Drawing.Point(32, 212);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(22, 23);
            this.labId.TabIndex = 2;
            this.labId.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.TOKEN);
            this.Controls.Add(this.labToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labToken;
        private System.Windows.Forms.Label TOKEN;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label labId;
    }
}

