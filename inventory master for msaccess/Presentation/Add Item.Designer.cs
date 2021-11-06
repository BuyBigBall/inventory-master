﻿/*
 * Created by SharpDevelop.
 * User: VStudent
 * Date: 16/07/2015
 * Time: 04:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Inventory_System
{
	partial class Add_Item
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.categoryCmbox = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addNewSupplierLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.supplierCmBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.unitCmbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReorderTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.itemNameTxtbox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.itemCodeTxtbox = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.costNumeric);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.categoryLbl);
            this.groupBox1.Controls.Add(this.categoryCmbox);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.addNewSupplierLink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.supplierCmBox);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.unitCmbBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ReorderTxtBx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insertBtn);
            this.groupBox1.Controls.Add(this.itemNameTxtbox);
            this.groupBox1.Controls.Add(this.itemDescriptionTxtBox);
            this.groupBox1.Controls.Add(this.itemCodeTxtbox);
            this.groupBox1.Location = new System.Drawing.Point(0, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 538);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // costNumeric
            // 
            this.costNumeric.DecimalPlaces = 2;
            this.costNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.costNumeric.Location = new System.Drawing.Point(184, 430);
            this.costNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costNumeric.Name = "costNumeric";
            this.costNumeric.Size = new System.Drawing.Size(231, 26);
            this.costNumeric.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(105, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cost ($)";
            // 
            // categoryLbl
            // 
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryLbl.Location = new System.Drawing.Point(105, 221);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(73, 19);
            this.categoryLbl.TabIndex = 21;
            this.categoryLbl.Text = "Category";
            // 
            // categoryCmbox
            // 
            this.categoryCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.categoryCmbox.FormattingEnabled = true;
            this.categoryCmbox.Location = new System.Drawing.Point(184, 220);
            this.categoryCmbox.Name = "categoryCmbox";
            this.categoryCmbox.Size = new System.Drawing.Size(254, 28);
            this.categoryCmbox.TabIndex = 20;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(185, 363);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 23);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New Unit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // addNewSupplierLink
            // 
            this.addNewSupplierLink.Location = new System.Drawing.Point(183, 311);
            this.addNewSupplierLink.Name = "addNewSupplierLink";
            this.addNewSupplierLink.Size = new System.Drawing.Size(100, 23);
            this.addNewSupplierLink.TabIndex = 18;
            this.addNewSupplierLink.TabStop = true;
            this.addNewSupplierLink.Text = "Add New Supplier";
            this.addNewSupplierLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewSupplierLinkLinkClicked);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(113, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Supplier";
            // 
            // supplierCmBox
            // 
            this.supplierCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.supplierCmBox.FormattingEnabled = true;
            this.supplierCmBox.Location = new System.Drawing.Point(186, 280);
            this.supplierCmBox.Name = "supplierCmBox";
            this.supplierCmBox.Size = new System.Drawing.Size(252, 28);
            this.supplierCmBox.TabIndex = 16;
            this.supplierCmBox.SelectedIndexChanged += new System.EventHandler(this.SupplierCmBoxSelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip1.Location = new System.Drawing.Point(3, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(459, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // unitCmbBox
            // 
            this.unitCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.unitCmbBox.FormattingEnabled = true;
            this.unitCmbBox.Location = new System.Drawing.Point(186, 335);
            this.unitCmbBox.Name = "unitCmbBox";
            this.unitCmbBox.Size = new System.Drawing.Size(103, 26);
            this.unitCmbBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(138, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Unit";
            // 
            // ReorderTxtBx
            // 
            this.ReorderTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ReorderTxtBx.Location = new System.Drawing.Point(184, 386);
            this.ReorderTxtBx.Name = "ReorderTxtBx";
            this.ReorderTxtBx.Size = new System.Drawing.Size(250, 26);
            this.ReorderTxtBx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(69, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reorder Level";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_System.Resource1._1438216260_icon_105_folder_add;
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(106, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(69, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Description";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(109, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Code";
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.insertBtn.FlatAppearance.BorderSize = 0;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.insertBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertBtn.Location = new System.Drawing.Point(236, 462);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(107, 43);
            this.insertBtn.TabIndex = 7;
            this.insertBtn.Text = "Add";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.InsertBtnClick);
            // 
            // itemNameTxtbox
            // 
            this.itemNameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.itemNameTxtbox.Location = new System.Drawing.Point(192, 84);
            this.itemNameTxtbox.Name = "itemNameTxtbox";
            this.itemNameTxtbox.Size = new System.Drawing.Size(246, 26);
            this.itemNameTxtbox.TabIndex = 2;
            // 
            // itemDescriptionTxtBox
            // 
            this.itemDescriptionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.itemDescriptionTxtBox.Location = new System.Drawing.Point(69, 138);
            this.itemDescriptionTxtBox.Multiline = true;
            this.itemDescriptionTxtBox.Name = "itemDescriptionTxtBox";
            this.itemDescriptionTxtBox.Size = new System.Drawing.Size(369, 69);
            this.itemDescriptionTxtBox.TabIndex = 3;
            // 
            // itemCodeTxtbox
            // 
            this.itemCodeTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.itemCodeTxtbox.Location = new System.Drawing.Point(191, 43);
            this.itemCodeTxtbox.Name = "itemCodeTxtbox";
            this.itemCodeTxtbox.Size = new System.Drawing.Size(247, 26);
            this.itemCodeTxtbox.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(185, 251);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(104, 23);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add New Category";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Add_Item
            // 
            this.AcceptButton = this.insertBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 523);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_ItemFormClosed);
            this.Load += new System.EventHandler(this.Add_Item_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox supplierCmBox;
		private System.Windows.Forms.LinkLabel addNewSupplierLink;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ComboBox unitCmbBox;
		private System.Windows.Forms.TextBox ReorderTxtBx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox itemCodeTxtbox;
		private System.Windows.Forms.TextBox itemDescriptionTxtBox;
		private System.Windows.Forms.TextBox itemNameTxtbox;
		private System.Windows.Forms.Button insertBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ComboBox categoryCmbox;
        private System.Windows.Forms.NumericUpDown costNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
