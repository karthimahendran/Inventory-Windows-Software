﻿namespace Truck_inventory
{
    partial class editcustomer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.txtContPeson = new System.Windows.Forms.TextBox();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContPerson = new System.Windows.Forms.Label();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(343, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(206, 381);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 42;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAddress.Location = new System.Drawing.Point(241, 184);
            this.rtbAddress.MaxLength = 999;
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(220, 67);
            this.rtbAddress.TabIndex = 39;
            this.rtbAddress.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(241, 323);
            this.txtEmail.MaxLength = 99;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 22);
            this.txtEmail.TabIndex = 41;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNum.Location = new System.Drawing.Point(241, 274);
            this.txtContactNum.MaxLength = 10;
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(220, 22);
            this.txtContactNum.TabIndex = 40;
            // 
            // txtContPeson
            // 
            this.txtContPeson.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContPeson.Location = new System.Drawing.Point(241, 140);
            this.txtContPeson.MaxLength = 99;
            this.txtContPeson.Name = "txtContPeson";
            this.txtContPeson.Size = new System.Drawing.Size(220, 22);
            this.txtContPeson.TabIndex = 38;
            // 
            // txtSuppName
            // 
            this.txtSuppName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppName.Location = new System.Drawing.Point(241, 96);
            this.txtSuppName.MaxLength = 99;
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(220, 22);
            this.txtSuppName.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(65, 320);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(116, 20);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "E-Mail Address";
            // 
            // lblContNum
            // 
            this.lblContNum.AutoSize = true;
            this.lblContNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContNum.Location = new System.Drawing.Point(65, 271);
            this.lblContNum.Name = "lblContNum";
            this.lblContNum.Size = new System.Drawing.Size(125, 20);
            this.lblContNum.TabIndex = 32;
            this.lblContNum.Text = "Contact Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(65, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address";
            // 
            // lblContPerson
            // 
            this.lblContPerson.AutoSize = true;
            this.lblContPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContPerson.Location = new System.Drawing.Point(65, 137);
            this.lblContPerson.Name = "lblContPerson";
            this.lblContPerson.Size = new System.Drawing.Size(119, 20);
            this.lblContPerson.TabIndex = 36;
            this.lblContPerson.Text = "Contact Person";
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppName.Location = new System.Drawing.Point(65, 93);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(113, 20);
            this.lblSuppName.TabIndex = 35;
            this.lblSuppName.Text = "Supplier Name";
            // 
            // editcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 497);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.txtContPeson);
            this.Controls.Add(this.txtSuppName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContPerson);
            this.Controls.Add(this.lblSuppName);
            this.Name = "editcustomer";
            this.Text = "editcustomer";
            this.Load += new System.EventHandler(this.editcustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.TextBox txtContPeson;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContNum;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContPerson;
        private System.Windows.Forms.Label lblSuppName;
    }
}