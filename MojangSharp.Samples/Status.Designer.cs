namespace MojangSharp.Samples
{
    partial class Status
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
            this.minecraftNet = new System.Windows.Forms.CheckBox();
            this.sessionMinecraftNet = new System.Windows.Forms.CheckBox();
            this.accountMojangCom = new System.Windows.Forms.CheckBox();
            this.authserverMojangCom = new System.Windows.Forms.CheckBox();
            this.mojangCom = new System.Windows.Forms.CheckBox();
            this.texturesMinecraftNet = new System.Windows.Forms.CheckBox();
            this.apiMojangCom = new System.Windows.Forms.CheckBox();
            this.sessionserverMojangCom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // minecraftNet
            // 
            this.minecraftNet.AutoSize = true;
            this.minecraftNet.Enabled = false;
            this.minecraftNet.Location = new System.Drawing.Point(12, 12);
            this.minecraftNet.Name = "minecraftNet";
            this.minecraftNet.Size = new System.Drawing.Size(87, 17);
            this.minecraftNet.TabIndex = 0;
            this.minecraftNet.Text = "minecraft.net";
            this.minecraftNet.UseVisualStyleBackColor = true;
            // 
            // sessionMinecraftNet
            // 
            this.sessionMinecraftNet.AutoSize = true;
            this.sessionMinecraftNet.Enabled = false;
            this.sessionMinecraftNet.Location = new System.Drawing.Point(12, 35);
            this.sessionMinecraftNet.Name = "sessionMinecraftNet";
            this.sessionMinecraftNet.Size = new System.Drawing.Size(125, 17);
            this.sessionMinecraftNet.TabIndex = 1;
            this.sessionMinecraftNet.Text = "session.minecraft.net";
            this.sessionMinecraftNet.UseVisualStyleBackColor = true;
            // 
            // accountMojangCom
            // 
            this.accountMojangCom.AutoSize = true;
            this.accountMojangCom.Enabled = false;
            this.accountMojangCom.Location = new System.Drawing.Point(12, 58);
            this.accountMojangCom.Name = "accountMojangCom";
            this.accountMojangCom.Size = new System.Drawing.Size(125, 17);
            this.accountMojangCom.TabIndex = 2;
            this.accountMojangCom.Text = "account.mojang.com";
            this.accountMojangCom.UseVisualStyleBackColor = true;
            // 
            // authserverMojangCom
            // 
            this.authserverMojangCom.AutoSize = true;
            this.authserverMojangCom.Enabled = false;
            this.authserverMojangCom.Location = new System.Drawing.Point(12, 81);
            this.authserverMojangCom.Name = "authserverMojangCom";
            this.authserverMojangCom.Size = new System.Drawing.Size(136, 17);
            this.authserverMojangCom.TabIndex = 3;
            this.authserverMojangCom.Text = "authserver.mojang.com";
            this.authserverMojangCom.UseVisualStyleBackColor = true;
            // 
            // mojangCom
            // 
            this.mojangCom.AutoSize = true;
            this.mojangCom.Enabled = false;
            this.mojangCom.Location = new System.Drawing.Point(12, 173);
            this.mojangCom.Name = "mojangCom";
            this.mojangCom.Size = new System.Drawing.Size(83, 17);
            this.mojangCom.TabIndex = 7;
            this.mojangCom.Text = "mojang.com";
            this.mojangCom.UseVisualStyleBackColor = true;
            // 
            // texturesMinecraftNet
            // 
            this.texturesMinecraftNet.AutoSize = true;
            this.texturesMinecraftNet.Enabled = false;
            this.texturesMinecraftNet.Location = new System.Drawing.Point(12, 150);
            this.texturesMinecraftNet.Name = "texturesMinecraftNet";
            this.texturesMinecraftNet.Size = new System.Drawing.Size(127, 17);
            this.texturesMinecraftNet.TabIndex = 6;
            this.texturesMinecraftNet.Text = "textures.minecraft.net";
            this.texturesMinecraftNet.UseVisualStyleBackColor = true;
            // 
            // apiMojangCom
            // 
            this.apiMojangCom.AutoSize = true;
            this.apiMojangCom.Enabled = false;
            this.apiMojangCom.Location = new System.Drawing.Point(12, 127);
            this.apiMojangCom.Name = "apiMojangCom";
            this.apiMojangCom.Size = new System.Drawing.Size(100, 17);
            this.apiMojangCom.TabIndex = 5;
            this.apiMojangCom.Text = "api.mojang.com";
            this.apiMojangCom.UseVisualStyleBackColor = true;
            // 
            // sessionserverMojangCom
            // 
            this.sessionserverMojangCom.AutoSize = true;
            this.sessionserverMojangCom.Enabled = false;
            this.sessionserverMojangCom.Location = new System.Drawing.Point(12, 104);
            this.sessionserverMojangCom.Name = "sessionserverMojangCom";
            this.sessionserverMojangCom.Size = new System.Drawing.Size(150, 17);
            this.sessionserverMojangCom.TabIndex = 4;
            this.sessionserverMojangCom.Text = "sessionserver.mojang.com";
            this.sessionserverMojangCom.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mojangCom);
            this.Controls.Add(this.texturesMinecraftNet);
            this.Controls.Add(this.apiMojangCom);
            this.Controls.Add(this.sessionserverMojangCom);
            this.Controls.Add(this.authserverMojangCom);
            this.Controls.Add(this.accountMojangCom);
            this.Controls.Add(this.sessionMinecraftNet);
            this.Controls.Add(this.minecraftNet);
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox minecraftNet;
        private System.Windows.Forms.CheckBox sessionMinecraftNet;
        private System.Windows.Forms.CheckBox accountMojangCom;
        private System.Windows.Forms.CheckBox authserverMojangCom;
        private System.Windows.Forms.CheckBox mojangCom;
        private System.Windows.Forms.CheckBox texturesMinecraftNet;
        private System.Windows.Forms.CheckBox apiMojangCom;
        private System.Windows.Forms.CheckBox sessionserverMojangCom;
    }
}