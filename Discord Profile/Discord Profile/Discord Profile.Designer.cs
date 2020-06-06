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
            this.butTokenCopy = new System.Windows.Forms.Button();
            this.butIdCopy = new System.Windows.Forms.Button();
            this.butIpCopy = new System.Windows.Forms.Button();
            this.INTERANLIP = new System.Windows.Forms.Label();
            this.labInternalIP = new System.Windows.Forms.Label();
            this.butExternalIPCopy = new System.Windows.Forms.Button();
            this.EXTERNALIP = new System.Windows.Forms.Label();
            this.labExternalIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labToken
            // 
            this.labToken.AutoSize = true;
            this.labToken.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToken.Location = new System.Drawing.Point(32, 79);
            this.labToken.Name = "labToken";
            this.labToken.Size = new System.Drawing.Size(54, 23);
            this.labToken.TabIndex = 0;
            this.labToken.Text = "Token";
            // 
            // TOKEN
            // 
            this.TOKEN.AutoSize = true;
            this.TOKEN.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOKEN.Location = new System.Drawing.Point(29, 38);
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.Size = new System.Drawing.Size(91, 37);
            this.TOKEN.TabIndex = 1;
            this.TOKEN.Text = "Token";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(29, 126);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(39, 37);
            this.ID.TabIndex = 3;
            this.ID.Text = "Id";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labId.Location = new System.Drawing.Point(32, 167);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(22, 23);
            this.labId.TabIndex = 2;
            this.labId.Text = "Id";
            // 
            // butTokenCopy
            // 
            this.butTokenCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTokenCopy.Location = new System.Drawing.Point(126, 45);
            this.butTokenCopy.Name = "butTokenCopy";
            this.butTokenCopy.Size = new System.Drawing.Size(75, 23);
            this.butTokenCopy.TabIndex = 4;
            this.butTokenCopy.Text = "Copy";
            this.butTokenCopy.UseVisualStyleBackColor = true;
            this.butTokenCopy.Click += new System.EventHandler(this.butTokenCopy_Click);
            // 
            // butIdCopy
            // 
            this.butIdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIdCopy.Location = new System.Drawing.Point(72, 133);
            this.butIdCopy.Name = "butIdCopy";
            this.butIdCopy.Size = new System.Drawing.Size(75, 23);
            this.butIdCopy.TabIndex = 5;
            this.butIdCopy.Text = "Copy";
            this.butIdCopy.UseVisualStyleBackColor = true;
            this.butIdCopy.Click += new System.EventHandler(this.butIdCopy_Click);
            // 
            // butIpCopy
            // 
            this.butIpCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIpCopy.Location = new System.Drawing.Point(173, 225);
            this.butIpCopy.Name = "butIpCopy";
            this.butIpCopy.Size = new System.Drawing.Size(75, 23);
            this.butIpCopy.TabIndex = 8;
            this.butIpCopy.Text = "Copy";
            this.butIpCopy.UseVisualStyleBackColor = true;
            this.butIpCopy.Click += new System.EventHandler(this.butIpCopy_Click);
            // 
            // INTERANLIP
            // 
            this.INTERANLIP.AutoSize = true;
            this.INTERANLIP.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTERANLIP.Location = new System.Drawing.Point(29, 218);
            this.INTERANLIP.Name = "INTERANLIP";
            this.INTERANLIP.Size = new System.Drawing.Size(138, 37);
            this.INTERANLIP.TabIndex = 7;
            this.INTERANLIP.Text = "Internal IP";
            this.INTERANLIP.Click += new System.EventHandler(this.ip_Click);
            // 
            // labInternalIP
            // 
            this.labInternalIP.AutoSize = true;
            this.labInternalIP.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInternalIP.Location = new System.Drawing.Point(32, 259);
            this.labInternalIP.Name = "labInternalIP";
            this.labInternalIP.Size = new System.Drawing.Size(77, 23);
            this.labInternalIP.TabIndex = 6;
            this.labInternalIP.Text = "Internal IP";
            // 
            // butExternalIPCopy
            // 
            this.butExternalIPCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExternalIPCopy.Location = new System.Drawing.Point(173, 331);
            this.butExternalIPCopy.Name = "butExternalIPCopy";
            this.butExternalIPCopy.Size = new System.Drawing.Size(75, 23);
            this.butExternalIPCopy.TabIndex = 11;
            this.butExternalIPCopy.Text = "Copy";
            this.butExternalIPCopy.UseVisualStyleBackColor = true;
            this.butExternalIPCopy.Click += new System.EventHandler(this.butExternalIPCopy_Click);
            // 
            // EXTERNALIP
            // 
            this.EXTERNALIP.AutoSize = true;
            this.EXTERNALIP.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXTERNALIP.Location = new System.Drawing.Point(29, 324);
            this.EXTERNALIP.Name = "EXTERNALIP";
            this.EXTERNALIP.Size = new System.Drawing.Size(147, 37);
            this.EXTERNALIP.TabIndex = 10;
            this.EXTERNALIP.Text = "External IP";
            // 
            // labExternalIP
            // 
            this.labExternalIP.AutoSize = true;
            this.labExternalIP.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExternalIP.Location = new System.Drawing.Point(32, 365);
            this.labExternalIP.Name = "labExternalIP";
            this.labExternalIP.Size = new System.Drawing.Size(83, 23);
            this.labExternalIP.TabIndex = 9;
            this.labExternalIP.Text = "External IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butExternalIPCopy);
            this.Controls.Add(this.EXTERNALIP);
            this.Controls.Add(this.labExternalIP);
            this.Controls.Add(this.butIpCopy);
            this.Controls.Add(this.INTERANLIP);
            this.Controls.Add(this.labInternalIP);
            this.Controls.Add(this.butIdCopy);
            this.Controls.Add(this.butTokenCopy);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.TOKEN);
            this.Controls.Add(this.labToken);
            this.Name = "Form1";
            this.Text = "Discord Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labToken;
        private System.Windows.Forms.Label TOKEN;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Button butTokenCopy;
        private System.Windows.Forms.Button butIdCopy;
        private System.Windows.Forms.Button butIpCopy;
        private System.Windows.Forms.Label INTERANLIP;
        private System.Windows.Forms.Label labInternalIP;
        private System.Windows.Forms.Button butExternalIPCopy;
        private System.Windows.Forms.Label EXTERNALIP;
        private System.Windows.Forms.Label labExternalIP;
    }
}

