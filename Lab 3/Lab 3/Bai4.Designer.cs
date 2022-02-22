namespace Lab_3
{
    partial class Bai4
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
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient1 = new System.Windows.Forms.Button();
            this.btnClient2 = new System.Windows.Forms.Button();
            this.btnClient3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(56, 62);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(170, 61);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient1
            // 
            this.btnClient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient1.Location = new System.Drawing.Point(320, 62);
            this.btnClient1.Name = "btnClient1";
            this.btnClient1.Size = new System.Drawing.Size(170, 61);
            this.btnClient1.TabIndex = 1;
            this.btnClient1.Text = "Client 1";
            this.btnClient1.UseVisualStyleBackColor = true;
            this.btnClient1.Click += new System.EventHandler(this.btnClient1_Click);
            // 
            // btnClient2
            // 
            this.btnClient2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient2.Location = new System.Drawing.Point(56, 189);
            this.btnClient2.Name = "btnClient2";
            this.btnClient2.Size = new System.Drawing.Size(170, 61);
            this.btnClient2.TabIndex = 2;
            this.btnClient2.Text = "Client 2";
            this.btnClient2.UseVisualStyleBackColor = true;
            this.btnClient2.Click += new System.EventHandler(this.btnClient2_Click);
            // 
            // btnClient3
            // 
            this.btnClient3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient3.Location = new System.Drawing.Point(320, 189);
            this.btnClient3.Name = "btnClient3";
            this.btnClient3.Size = new System.Drawing.Size(170, 61);
            this.btnClient3.TabIndex = 3;
            this.btnClient3.Text = "Client 3";
            this.btnClient3.UseVisualStyleBackColor = true;
            this.btnClient3.Click += new System.EventHandler(this.btnClient3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(189, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 61);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 401);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClient3);
            this.Controls.Add(this.btnClient2);
            this.Controls.Add(this.btnClient1);
            this.Controls.Add(this.btnServer);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient1;
        private System.Windows.Forms.Button btnClient2;
        private System.Windows.Forms.Button btnClient3;
        private System.Windows.Forms.Button btnExit;
    }
}