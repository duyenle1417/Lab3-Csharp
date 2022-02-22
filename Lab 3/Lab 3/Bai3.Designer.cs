namespace Lab_3
{
    partial class Bai3
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
            this.btnTcpClient = new System.Windows.Forms.Button();
            this.btnTcpServer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTcpClient
            // 
            this.btnTcpClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTcpClient.Location = new System.Drawing.Point(43, 48);
            this.btnTcpClient.Name = "btnTcpClient";
            this.btnTcpClient.Size = new System.Drawing.Size(156, 61);
            this.btnTcpClient.TabIndex = 0;
            this.btnTcpClient.Text = "TCP Client";
            this.btnTcpClient.UseVisualStyleBackColor = true;
            this.btnTcpClient.Click += new System.EventHandler(this.btnTcpClient_Click);
            // 
            // btnTcpServer
            // 
            this.btnTcpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTcpServer.Location = new System.Drawing.Point(273, 48);
            this.btnTcpServer.Name = "btnTcpServer";
            this.btnTcpServer.Size = new System.Drawing.Size(156, 61);
            this.btnTcpServer.TabIndex = 1;
            this.btnTcpServer.Text = "TCP Server";
            this.btnTcpServer.UseVisualStyleBackColor = true;
            this.btnTcpServer.Click += new System.EventHandler(this.btnTcpServer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(156, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 61);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 270);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTcpServer);
            this.Controls.Add(this.btnTcpClient);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTcpClient;
        private System.Windows.Forms.Button btnTcpServer;
        private System.Windows.Forms.Button btnExit;
    }
}