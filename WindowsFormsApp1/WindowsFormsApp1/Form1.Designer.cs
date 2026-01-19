namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.btnDeSerialize = new System.Windows.Forms.Button();
            this.xmlSerializer = new System.Windows.Forms.Button();
            this.xmlDeserializer = new System.Windows.Forms.Button();
            this.soapSerializer = new System.Windows.Forms.Button();
            this.soapDeserializer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(33, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Firebrick;
            this.txtID.Location = new System.Drawing.Point(236, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(269, 38);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Firebrick;
            this.txtName.Location = new System.Drawing.Point(236, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 38);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(104, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.Firebrick;
            this.txtSalary.Location = new System.Drawing.Point(236, 169);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(269, 38);
            this.txtSalary.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(104, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.BackColor = System.Drawing.Color.White;
            this.btnBinSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinSerialize.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBinSerialize.Location = new System.Drawing.Point(39, 296);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(218, 34);
            this.btnBinSerialize.TabIndex = 6;
            this.btnBinSerialize.Text = "Bin Serialize";
            this.btnBinSerialize.UseVisualStyleBackColor = false;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click);
            // 
            // btnDeSerialize
            // 
            this.btnDeSerialize.BackColor = System.Drawing.Color.White;
            this.btnDeSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeSerialize.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDeSerialize.Location = new System.Drawing.Point(39, 346);
            this.btnDeSerialize.Name = "btnDeSerialize";
            this.btnDeSerialize.Size = new System.Drawing.Size(218, 29);
            this.btnDeSerialize.TabIndex = 7;
            this.btnDeSerialize.Text = "Bin DeSerialize";
            this.btnDeSerialize.UseVisualStyleBackColor = false;
            this.btnDeSerialize.Click += new System.EventHandler(this.btnDeSerialize_Click);
            // 
            // xmlSerializer
            // 
            this.xmlSerializer.BackColor = System.Drawing.Color.White;
            this.xmlSerializer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlSerializer.ForeColor = System.Drawing.Color.Firebrick;
            this.xmlSerializer.Location = new System.Drawing.Point(295, 296);
            this.xmlSerializer.Name = "xmlSerializer";
            this.xmlSerializer.Size = new System.Drawing.Size(158, 34);
            this.xmlSerializer.TabIndex = 8;
            this.xmlSerializer.Text = "XMLSerializer";
            this.xmlSerializer.UseVisualStyleBackColor = false;
            this.xmlSerializer.Click += new System.EventHandler(this.button3_Click);
            // 
            // xmlDeserializer
            // 
            this.xmlDeserializer.BackColor = System.Drawing.Color.White;
            this.xmlDeserializer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlDeserializer.ForeColor = System.Drawing.Color.Firebrick;
            this.xmlDeserializer.Location = new System.Drawing.Point(295, 346);
            this.xmlDeserializer.Name = "xmlDeserializer";
            this.xmlDeserializer.Size = new System.Drawing.Size(158, 29);
            this.xmlDeserializer.TabIndex = 9;
            this.xmlDeserializer.Text = "XMLDeserializer";
            this.xmlDeserializer.UseVisualStyleBackColor = false;
            this.xmlDeserializer.Click += new System.EventHandler(this.button4_Click);
            // 
            // soapSerializer
            // 
            this.soapSerializer.BackColor = System.Drawing.Color.White;
            this.soapSerializer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soapSerializer.ForeColor = System.Drawing.Color.Firebrick;
            this.soapSerializer.Location = new System.Drawing.Point(480, 296);
            this.soapSerializer.Name = "soapSerializer";
            this.soapSerializer.Size = new System.Drawing.Size(211, 34);
            this.soapSerializer.TabIndex = 10;
            this.soapSerializer.Text = "SOAPSerializer";
            this.soapSerializer.UseVisualStyleBackColor = false;
            this.soapSerializer.Click += new System.EventHandler(this.button5_Click);
            // 
            // soapDeserializer
            // 
            this.soapDeserializer.BackColor = System.Drawing.Color.White;
            this.soapDeserializer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soapDeserializer.ForeColor = System.Drawing.Color.Firebrick;
            this.soapDeserializer.Location = new System.Drawing.Point(480, 346);
            this.soapDeserializer.Name = "soapDeserializer";
            this.soapDeserializer.Size = new System.Drawing.Size(211, 29);
            this.soapDeserializer.TabIndex = 11;
            this.soapDeserializer.Text = "SOAPDeserializer";
            this.soapDeserializer.UseVisualStyleBackColor = false;
            this.soapDeserializer.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.soapDeserializer);
            this.Controls.Add(this.soapSerializer);
            this.Controls.Add(this.xmlDeserializer);
            this.Controls.Add(this.xmlSerializer);
            this.Controls.Add(this.btnDeSerialize);
            this.Controls.Add(this.btnBinSerialize);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBinSerialize;
        private System.Windows.Forms.Button btnDeSerialize;
        private System.Windows.Forms.Button soapSerializer;
        private System.Windows.Forms.Button xmlDeserializer;
        private System.Windows.Forms.Button xmlSerializer;
        private System.Windows.Forms.Button soapDeserializer;
    }
}

