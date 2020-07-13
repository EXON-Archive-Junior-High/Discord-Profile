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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labToken = new System.Windows.Forms.Label();
            this.TOKEN = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.butTokenCopy = new System.Windows.Forms.Button();
            this.butIdCopy = new System.Windows.Forms.Button();
            this.butIpCopy = new System.Windows.Forms.Button();
            this.INTERANLIP = new System.Windows.Forms.Label();
            this.labInternalIP = new System.Windows.Forms.Label();
            this.butExternalIPCopy = new System.Windows.Forms.Button();
            this.EXTERNALIP = new System.Windows.Forms.Label();
            this.labExternalIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.top = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.topBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.setting = new Guna.UI2.WinForms.Guna2ImageButton();
            this.info = new Guna.UI2.WinForms.Guna2ImageButton();
            this.home = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.inputToken = new Guna.UI2.WinForms.Guna2TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.searchBut = new Guna.UI2.WinForms.Guna2Button();
            this.topBar.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labToken
            // 
            this.labToken.AutoSize = true;
            this.labToken.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToken.ForeColor = System.Drawing.Color.White;
            this.labToken.Location = new System.Drawing.Point(91, 77);
            this.labToken.Name = "labToken";
            this.labToken.Size = new System.Drawing.Size(42, 17);
            this.labToken.TabIndex = 0;
            this.labToken.Text = "Token";
            // 
            // TOKEN
            // 
            this.TOKEN.AutoSize = true;
            this.TOKEN.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOKEN.ForeColor = System.Drawing.Color.White;
            this.TOKEN.Location = new System.Drawing.Point(88, 38);
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.Size = new System.Drawing.Size(91, 37);
            this.TOKEN.TabIndex = 1;
            this.TOKEN.Text = "Token";
            this.TOKEN.Click += new System.EventHandler(this.TOKEN_Click);
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.ForeColor = System.Drawing.Color.White;
            this.NAME.Location = new System.Drawing.Point(91, 150);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(88, 37);
            this.NAME.TabIndex = 3;
            this.NAME.Text = "Name";
            this.NAME.Click += new System.EventHandler(this.NAME_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.Color.White;
            this.labName.Location = new System.Drawing.Point(92, 187);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(62, 25);
            this.labName.TabIndex = 2;
            this.labName.Text = "Name";
            // 
            // butTokenCopy
            // 
            this.butTokenCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTokenCopy.ForeColor = System.Drawing.Color.White;
            this.butTokenCopy.Location = new System.Drawing.Point(185, 46);
            this.butTokenCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butTokenCopy.Name = "butTokenCopy";
            this.butTokenCopy.Size = new System.Drawing.Size(75, 29);
            this.butTokenCopy.TabIndex = 4;
            this.butTokenCopy.Text = "Copy";
            this.butTokenCopy.UseVisualStyleBackColor = true;
            this.butTokenCopy.Click += new System.EventHandler(this.butTokenCopy_Click);
            // 
            // butIdCopy
            // 
            this.butIdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIdCopy.ForeColor = System.Drawing.Color.White;
            this.butIdCopy.Location = new System.Drawing.Point(189, 156);
            this.butIdCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butIdCopy.Name = "butIdCopy";
            this.butIdCopy.Size = new System.Drawing.Size(75, 29);
            this.butIdCopy.TabIndex = 5;
            this.butIdCopy.Text = "Copy";
            this.butIdCopy.UseVisualStyleBackColor = true;
            this.butIdCopy.Click += new System.EventHandler(this.butIdCopy_Click);
            // 
            // butIpCopy
            // 
            this.butIpCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIpCopy.ForeColor = System.Drawing.Color.White;
            this.butIpCopy.Location = new System.Drawing.Point(236, 275);
            this.butIpCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butIpCopy.Name = "butIpCopy";
            this.butIpCopy.Size = new System.Drawing.Size(75, 29);
            this.butIpCopy.TabIndex = 8;
            this.butIpCopy.Text = "Copy";
            this.butIpCopy.UseVisualStyleBackColor = true;
            this.butIpCopy.Click += new System.EventHandler(this.butIpCopy_Click);
            // 
            // INTERANLIP
            // 
            this.INTERANLIP.AutoSize = true;
            this.INTERANLIP.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTERANLIP.ForeColor = System.Drawing.Color.White;
            this.INTERANLIP.Location = new System.Drawing.Point(91, 265);
            this.INTERANLIP.Name = "INTERANLIP";
            this.INTERANLIP.Size = new System.Drawing.Size(136, 37);
            this.INTERANLIP.TabIndex = 7;
            this.INTERANLIP.Text = "Internal IP";
            this.INTERANLIP.Click += new System.EventHandler(this.ip_Click);
            // 
            // labInternalIP
            // 
            this.labInternalIP.AutoSize = true;
            this.labInternalIP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInternalIP.ForeColor = System.Drawing.Color.White;
            this.labInternalIP.Location = new System.Drawing.Point(94, 306);
            this.labInternalIP.Name = "labInternalIP";
            this.labInternalIP.Size = new System.Drawing.Size(98, 25);
            this.labInternalIP.TabIndex = 6;
            this.labInternalIP.Text = "Internal IP";
            // 
            // butExternalIPCopy
            // 
            this.butExternalIPCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExternalIPCopy.ForeColor = System.Drawing.Color.White;
            this.butExternalIPCopy.Location = new System.Drawing.Point(236, 408);
            this.butExternalIPCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butExternalIPCopy.Name = "butExternalIPCopy";
            this.butExternalIPCopy.Size = new System.Drawing.Size(75, 29);
            this.butExternalIPCopy.TabIndex = 11;
            this.butExternalIPCopy.Text = "Copy";
            this.butExternalIPCopy.UseVisualStyleBackColor = true;
            this.butExternalIPCopy.Click += new System.EventHandler(this.butExternalIPCopy_Click);
            // 
            // EXTERNALIP
            // 
            this.EXTERNALIP.AutoSize = true;
            this.EXTERNALIP.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXTERNALIP.ForeColor = System.Drawing.Color.White;
            this.EXTERNALIP.Location = new System.Drawing.Point(91, 398);
            this.EXTERNALIP.Name = "EXTERNALIP";
            this.EXTERNALIP.Size = new System.Drawing.Size(140, 37);
            this.EXTERNALIP.TabIndex = 10;
            this.EXTERNALIP.Text = "External IP";
            this.EXTERNALIP.Click += new System.EventHandler(this.EXTERNALIP_Click);
            // 
            // labExternalIP
            // 
            this.labExternalIP.AutoSize = true;
            this.labExternalIP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExternalIP.ForeColor = System.Drawing.Color.White;
            this.labExternalIP.Location = new System.Drawing.Point(94, 438);
            this.labExternalIP.Name = "labExternalIP";
            this.labExternalIP.Size = new System.Drawing.Size(101, 25);
            this.labExternalIP.TabIndex = 9;
            this.labExternalIP.Text = "External IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(378, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tag";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(380, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(380, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(378, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-mail";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(378, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Locale";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Locale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(378, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Verified";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(380, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Verified";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(556, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 32);
            this.label11.TabIndex = 25;
            this.label11.Text = "Phone";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(557, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Phone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(556, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 32);
            this.label13.TabIndex = 27;
            this.label13.Text = "Avatar";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(557, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Avatar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(556, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 32);
            this.label15.TabIndex = 29;
            this.label15.Text = "Flags / Public Flags";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(557, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Flags / Public Flags";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(556, 390);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 32);
            this.label17.TabIndex = 31;
            this.label17.Text = "Mfa Enabled";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(557, 425);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Mfa_enabled";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(556, 481);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 32);
            this.label19.TabIndex = 33;
            this.label19.Text = "NSFW Allowed";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(557, 516);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 17);
            this.label20.TabIndex = 32;
            this.label20.Text = "NSFW Allowed";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(91, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 37);
            this.label21.TabIndex = 36;
            this.label21.Text = "Developer";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(96, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 17);
            this.label22.TabIndex = 37;
            this.label22.Text = "엑슨";
            // 
            // top
            // 
            this.top.TargetControl = this.topBar;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Transparent;
            this.topBar.Controls.Add(this.guna2Panel3);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(71, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topBar.Name = "topBar";
            this.topBar.ShadowDecoration.Parent = this.topBar;
            this.topBar.Size = new System.Drawing.Size(994, 36);
            this.topBar.TabIndex = 43;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.guna2Panel3.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel3.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel3.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(729, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(265, 36);
            this.guna2Panel3.TabIndex = 3;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(115, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(50, 36);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(165, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(50, 36);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(215, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(50, 36);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.guna2Panel1.Controls.Add(this.search);
            this.guna2Panel1.Controls.Add(this.setting);
            this.guna2Panel1.Controls.Add(this.info);
            this.guna2Panel1.Controls.Add(this.home);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(71, 558);
            this.guna2Panel1.TabIndex = 42;
            // 
            // search
            // 
            this.search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.search.CheckedState.Parent = this.search;
            this.search.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("search.HoverState.Image")));
            this.search.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.search.HoverState.Parent = this.search;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImageRotate = 0F;
            this.search.ImageSize = new System.Drawing.Size(40, 40);
            this.search.Location = new System.Drawing.Point(12, 211);
            this.search.Name = "search";
            this.search.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.search.PressedState.Parent = this.search;
            this.search.Size = new System.Drawing.Size(50, 50);
            this.search.TabIndex = 3;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // setting
            // 
            this.setting.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.setting.CheckedState.Parent = this.setting;
            this.setting.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("setting.HoverState.Image")));
            this.setting.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.setting.HoverState.Parent = this.setting;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.ImageRotate = 0F;
            this.setting.ImageSize = new System.Drawing.Size(40, 40);
            this.setting.Location = new System.Drawing.Point(12, 281);
            this.setting.Name = "setting";
            this.setting.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.setting.PressedState.Parent = this.setting;
            this.setting.Size = new System.Drawing.Size(50, 50);
            this.setting.TabIndex = 2;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // info
            // 
            this.info.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.info.CheckedState.Parent = this.info;
            this.info.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("info.HoverState.Image")));
            this.info.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.info.HoverState.Parent = this.info;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.ImageRotate = 0F;
            this.info.ImageSize = new System.Drawing.Size(40, 40);
            this.info.Location = new System.Drawing.Point(12, 353);
            this.info.Name = "info";
            this.info.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.info.PressedState.Parent = this.info;
            this.info.Size = new System.Drawing.Size(50, 50);
            this.info.TabIndex = 1;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // home
            // 
            this.home.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.home.CheckedState.Parent = this.home;
            this.home.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("home.HoverState.Image")));
            this.home.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.home.HoverState.Parent = this.home;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageRotate = 0F;
            this.home.ImageSize = new System.Drawing.Size(40, 40);
            this.home.Location = new System.Drawing.Point(12, 137);
            this.home.Name = "home";
            this.home.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.home.PressedState.Parent = this.home;
            this.home.Size = new System.Drawing.Size(50, 50);
            this.home.TabIndex = 0;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.guna2Panel2.Controls.Add(this.label26);
            this.guna2Panel2.Controls.Add(this.label25);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(800, 36);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(265, 522);
            this.guna2Panel2.TabIndex = 44;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(6, 58);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 17);
            this.label26.TabIndex = 50;
            this.label26.Text = "내용";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(3, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(262, 32);
            this.label25.TabIndex = 49;
            this.label25.Text = "텍스트를 클릭해보세요";
            // 
            // inputToken
            // 
            this.inputToken.BorderRadius = 15;
            this.inputToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputToken.DefaultText = "";
            this.inputToken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputToken.DisabledState.Parent = this.inputToken;
            this.inputToken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputToken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputToken.FocusedState.Parent = this.inputToken;
            this.inputToken.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputToken.HoverState.Parent = this.inputToken;
            this.inputToken.Location = new System.Drawing.Point(94, 263);
            this.inputToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputToken.Name = "inputToken";
            this.inputToken.PasswordChar = '\0';
            this.inputToken.PlaceholderText = "";
            this.inputToken.SelectedText = "";
            this.inputToken.ShadowDecoration.Parent = this.inputToken;
            this.inputToken.Size = new System.Drawing.Size(691, 32);
            this.inputToken.TabIndex = 45;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(374, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 37);
            this.label23.TabIndex = 46;
            this.label23.Text = "Token";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(355, 302);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 17);
            this.label24.TabIndex = 47;
            this.label24.Text = "토큰을 입력해주세요";
            // 
            // searchBut
            // 
            this.searchBut.BorderRadius = 20;
            this.searchBut.CheckedState.Parent = this.searchBut;
            this.searchBut.CustomImages.Parent = this.searchBut;
            this.searchBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.searchBut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBut.ForeColor = System.Drawing.Color.White;
            this.searchBut.HoverState.Parent = this.searchBut;
            this.searchBut.Location = new System.Drawing.Point(328, 356);
            this.searchBut.Name = "searchBut";
            this.searchBut.ShadowDecoration.Parent = this.searchBut;
            this.searchBut.Size = new System.Drawing.Size(180, 50);
            this.searchBut.TabIndex = 48;
            this.searchBut.Text = "Search";
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1065, 558);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.inputToken);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butExternalIPCopy);
            this.Controls.Add(this.EXTERNALIP);
            this.Controls.Add(this.labExternalIP);
            this.Controls.Add(this.butIpCopy);
            this.Controls.Add(this.INTERANLIP);
            this.Controls.Add(this.labInternalIP);
            this.Controls.Add(this.butIdCopy);
            this.Controls.Add(this.butTokenCopy);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.TOKEN);
            this.Controls.Add(this.labToken);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Discord Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labToken;
        private System.Windows.Forms.Label TOKEN;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button butTokenCopy;
        private System.Windows.Forms.Button butIdCopy;
        private System.Windows.Forms.Button butIpCopy;
        private System.Windows.Forms.Label INTERANLIP;
        private System.Windows.Forms.Label labInternalIP;
        private System.Windows.Forms.Button butExternalIPCopy;
        private System.Windows.Forms.Label EXTERNALIP;
        private System.Windows.Forms.Label labExternalIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2DragControl top;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel topBar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ImageButton setting;
        private Guna.UI2.WinForms.Guna2ImageButton info;
        private Guna.UI2.WinForms.Guna2ImageButton home;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
        private Guna.UI2.WinForms.Guna2ImageButton search;
        private Guna.UI2.WinForms.Guna2TextBox inputToken;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2Button searchBut;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
    }
}

