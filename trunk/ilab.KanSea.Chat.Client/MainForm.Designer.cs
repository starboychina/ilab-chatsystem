﻿/**
 * 作者	: Hikaru
 * 日期	: 2011/9/28
 * 时间	: 0:51
 * QQ	: 39396682
 * Email: admin@kansea.com
 * 网站	: http://kansea.com  
 * 声明	: 未经作者许可，任何人不得发布出售该源码，请尊重别人的劳动成果，谢谢大家支持 
 */
namespace ilab.KanSea.Chat.Client
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.MessageRecord = new Ilab.KanSea.Chat.UI.Controls.TextBox();
            this.MessageInput = new Ilab.KanSea.Chat.UI.Controls.TextBox();
            this.MessageClose = new Ilab.KanSea.Chat.UI.Controls.Button();
            this.MessageSend = new Ilab.KanSea.Chat.UI.Controls.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageRecord
            // 
            this.MessageRecord.BackColor = System.Drawing.Color.Transparent;
            this.MessageRecord.font = new System.Drawing.Font("微软雅黑", 9F);
            this.MessageRecord.Ico = null;
            this.MessageRecord.IcoPadding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.MessageRecord.Isico = false;
            this.MessageRecord.IsPass = false;
            this.MessageRecord.lines = new string[0];
            this.MessageRecord.Location = new System.Drawing.Point(12, 40);
            this.MessageRecord.MaxLength = 32767;
            this.MessageRecord.Multiline = true;
            this.MessageRecord.Name = "MessageRecord";
            this.MessageRecord.PassChar = '\0';
            this.MessageRecord.ReadOnly = true;
            this.MessageRecord.Size = new System.Drawing.Size(422, 190);
            this.MessageRecord.TabIndex = 4;
            this.MessageRecord.text = "";
            // 
            // MessageInput
            // 
            this.MessageInput.BackColor = System.Drawing.Color.Transparent;
            this.MessageInput.font = new System.Drawing.Font("微软雅黑", 9F);
            this.MessageInput.Ico = null;
            this.MessageInput.IcoPadding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.MessageInput.Isico = false;
            this.MessageInput.IsPass = false;
            this.MessageInput.lines = new string[0];
            this.MessageInput.Location = new System.Drawing.Point(13, 236);
            this.MessageInput.MaxLength = 32767;
            this.MessageInput.Multiline = true;
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.PassChar = '\0';
            this.MessageInput.ReadOnly = false;
            this.MessageInput.Size = new System.Drawing.Size(421, 103);
            this.MessageInput.TabIndex = 5;
            this.MessageInput.text = "";
            // 
            // MessageClose
            // 
            this.MessageClose.BackColor = System.Drawing.Color.Transparent;
            this.MessageClose.BackImg = null;
            this.MessageClose.BacklightLTRB = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.MessageClose.Location = new System.Drawing.Point(266, 345);
            this.MessageClose.Name = "MessageClose";
            this.MessageClose.Size = new System.Drawing.Size(75, 23);
            this.MessageClose.TabIndex = 6;
            this.MessageClose.Text = "Close";
            this.MessageClose.UseVisualStyleBackColor = false;
            // 
            // MessageSend
            // 
            this.MessageSend.BackColor = System.Drawing.Color.Transparent;
            this.MessageSend.BackImg = null;
            this.MessageSend.BacklightLTRB = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.MessageSend.Location = new System.Drawing.Point(353, 345);
            this.MessageSend.Name = "MessageSend";
            this.MessageSend.Size = new System.Drawing.Size(75, 23);
            this.MessageSend.TabIndex = 7;
            this.MessageSend.Text = "Send";
            this.MessageSend.UseVisualStyleBackColor = false;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Location = new System.Drawing.Point(13, 13);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 12);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "UserName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 456);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.MessageSend);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.MessageRecord);
            this.Controls.Add(this.MessageClose);
            this.FormSystemBtnSet = Ilab.KanSea.Chat.UI.BaseForm.FormSystemBtn.btn_miniAndbtn_close;
            this.IsResize = false;
            this.Name = "MainForm";
            this.Text = "ilab.KanSea.Chat.Client";
            this.Controls.SetChildIndex(this.MessageClose, 0);
            this.Controls.SetChildIndex(this.MessageRecord, 0);
            this.Controls.SetChildIndex(this.MessageInput, 0);
            this.Controls.SetChildIndex(this.MessageSend, 0);
            this.Controls.SetChildIndex(this.UserName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private Ilab.KanSea.Chat.UI.Controls.TextBox MessageRecord;
        private Ilab.KanSea.Chat.UI.Controls.TextBox MessageInput;
        private Ilab.KanSea.Chat.UI.Controls.Button MessageClose;
        private Ilab.KanSea.Chat.UI.Controls.Button MessageSend;
        private System.Windows.Forms.Label UserName;
	}
}
