
namespace NANA {
	partial class NANAForm {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.TB_ID = new MetroFramework.Controls.MetroTextBox();
			this.BtnLogin = new MetroFramework.Controls.MetroButton();
			this.TB_PW = new MetroFramework.Controls.MetroTextBox();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// TB_ID
			// 
			// 
			// 
			// 
			this.TB_ID.CustomButton.Image = null;
			this.TB_ID.CustomButton.Location = new System.Drawing.Point(53, 1);
			this.TB_ID.CustomButton.Name = "";
			this.TB_ID.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TB_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TB_ID.CustomButton.TabIndex = 1;
			this.TB_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TB_ID.CustomButton.UseSelectable = true;
			this.TB_ID.CustomButton.Visible = false;
			this.TB_ID.Lines = new string[] {
        "ID"};
			this.TB_ID.Location = new System.Drawing.Point(3, 10);
			this.TB_ID.MaxLength = 32767;
			this.TB_ID.Name = "TB_ID";
			this.TB_ID.PasswordChar = '\0';
			this.TB_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TB_ID.SelectedText = "";
			this.TB_ID.SelectionLength = 0;
			this.TB_ID.SelectionStart = 0;
			this.TB_ID.ShortcutsEnabled = true;
			this.TB_ID.Size = new System.Drawing.Size(75, 23);
			this.TB_ID.TabIndex = 1;
			this.TB_ID.Text = "ID";
			this.TB_ID.UseSelectable = true;
			this.TB_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TB_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// BtnLogin
			// 
			this.BtnLogin.Location = new System.Drawing.Point(3, 68);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(75, 23);
			this.BtnLogin.TabIndex = 2;
			this.BtnLogin.Text = "LOGIN";
			this.BtnLogin.UseSelectable = true;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// TB_PW
			// 
			// 
			// 
			// 
			this.TB_PW.CustomButton.Image = null;
			this.TB_PW.CustomButton.Location = new System.Drawing.Point(53, 1);
			this.TB_PW.CustomButton.Name = "";
			this.TB_PW.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TB_PW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TB_PW.CustomButton.TabIndex = 1;
			this.TB_PW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TB_PW.CustomButton.UseSelectable = true;
			this.TB_PW.CustomButton.Visible = false;
			this.TB_PW.Lines = new string[] {
        "PW"};
			this.TB_PW.Location = new System.Drawing.Point(3, 39);
			this.TB_PW.MaxLength = 32767;
			this.TB_PW.Name = "TB_PW";
			this.TB_PW.PasswordChar = '\0';
			this.TB_PW.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TB_PW.SelectedText = "";
			this.TB_PW.SelectionLength = 0;
			this.TB_PW.SelectionStart = 0;
			this.TB_PW.ShortcutsEnabled = true;
			this.TB_PW.Size = new System.Drawing.Size(75, 23);
			this.TB_PW.TabIndex = 3;
			this.TB_PW.Text = "PW";
			this.TB_PW.UseSelectable = true;
			this.TB_PW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TB_PW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(85, 10);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(47, 81);
			this.metroTile1.TabIndex = 4;
			this.metroTile1.UseSelectable = true;
			// 
			// NANAForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(135, 100);
			this.ControlBox = false;
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.TB_PW);
			this.Controls.Add(this.BtnLogin);
			this.Controls.Add(this.TB_ID);
			this.DisplayHeader = false;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NANAForm";
			this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "NANA";
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroTextBox TB_ID;
		private MetroFramework.Controls.MetroButton BtnLogin;
		private MetroFramework.Controls.MetroTextBox TB_PW;
		private MetroFramework.Controls.MetroTile metroTile1;
	}
}

