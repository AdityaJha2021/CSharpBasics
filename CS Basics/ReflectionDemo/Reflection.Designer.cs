
namespace ReflectionDemo
{
    partial class Reflection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnDiscoverTypeInformation = new System.Windows.Forms.Button();
            this.lstMethodName = new System.Windows.Forms.ListBox();
            this.lstConstructorName = new System.Windows.Forms.ListBox();
            this.lstPropertiesName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(12, 9);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(101, 25);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Type Name";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(148, 13);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(220, 31);
            this.txtTypeName.TabIndex = 1;
            // 
            // btnDiscoverTypeInformation
            // 
            this.btnDiscoverTypeInformation.Location = new System.Drawing.Point(476, 9);
            this.btnDiscoverTypeInformation.Name = "btnDiscoverTypeInformation";
            this.btnDiscoverTypeInformation.Size = new System.Drawing.Size(312, 34);
            this.btnDiscoverTypeInformation.TabIndex = 2;
            this.btnDiscoverTypeInformation.Text = "Discover Type Information";
            this.btnDiscoverTypeInformation.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInformation.Click += new System.EventHandler(this.btnDiscoverTypeInformation_Click);
            // 
            // lstMethodName
            // 
            this.lstMethodName.FormattingEnabled = true;
            this.lstMethodName.ItemHeight = 25;
            this.lstMethodName.Location = new System.Drawing.Point(12, 96);
            this.lstMethodName.Name = "lstMethodName";
            this.lstMethodName.Size = new System.Drawing.Size(180, 329);
            this.lstMethodName.TabIndex = 3;
            // 
            // lstConstructorName
            // 
            this.lstConstructorName.FormattingEnabled = true;
            this.lstConstructorName.ItemHeight = 25;
            this.lstConstructorName.Location = new System.Drawing.Point(276, 96);
            this.lstConstructorName.Name = "lstConstructorName";
            this.lstConstructorName.Size = new System.Drawing.Size(180, 329);
            this.lstConstructorName.TabIndex = 4;
            // 
            // lstPropertiesName
            // 
            this.lstPropertiesName.FormattingEnabled = true;
            this.lstPropertiesName.ItemHeight = 25;
            this.lstPropertiesName.Location = new System.Drawing.Point(583, 96);
            this.lstPropertiesName.Name = "lstPropertiesName";
            this.lstPropertiesName.Size = new System.Drawing.Size(180, 329);
            this.lstPropertiesName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPropertiesName);
            this.Controls.Add(this.lstConstructorName);
            this.Controls.Add(this.lstMethodName);
            this.Controls.Add(this.btnDiscoverTypeInformation);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.lblTypeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnDiscoverTypeInformation;
        private System.Windows.Forms.ListBox lstMethodName;
        private System.Windows.Forms.ListBox lstConstructorName;
        private System.Windows.Forms.ListBox lstPropertiesName;
    }
}

