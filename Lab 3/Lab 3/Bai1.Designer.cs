namespace Lab_3
{
    partial class Bai1
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
            this.btnUdpClient = new System.Windows.Forms.Button();
            this.btnUdpServer = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUdpClient
            // 
            this.btnUdpClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUdpClient.Location = new System.Drawing.Point(38, 53);
            this.btnUdpClient.Name = "btnUdpClient";
            this.btnUdpClient.Size = new System.Drawing.Size(202, 75);
            this.btnUdpClient.TabIndex = 0;
            this.btnUdpClient.Text = "UDP Client";
            this.btnUdpClient.UseVisualStyleBackColor = true;
            this.btnUdpClient.Click += new System.EventHandler(this.btnUdpClient_Click);
            // 
            // btnUdpServer
            // 
            this.btnUdpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUdpServer.Location = new System.Drawing.Point(339, 53);
            this.btnUdpServer.Name = "btnUdpServer";
            this.btnUdpServer.Size = new System.Drawing.Size(202, 77);
            this.btnUdpServer.TabIndex = 1;
            this.btnUdpServer.Text = "UDP Server";
            this.btnUdpServer.UseVisualStyleBackColor = true;
            this.btnUdpServer.Click += new System.EventHandler(this.btnUdpServer_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoát.Location = new System.Drawing.Point(183, 162);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(202, 77);
            this.btnThoát.TabIndex = 2;
            this.btnThoát.Text = "Exit";
            this.btnThoát.UseVisualStyleBackColor = true;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 270);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.btnUdpServer);
            this.Controls.Add(this.btnUdpClient);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUdpClient;
        private System.Windows.Forms.Button btnUdpServer;
        private System.Windows.Forms.Button btnThoát;
    }
}