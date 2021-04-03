
namespace ExcelAddIn3
{
    partial class IteratorForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox inputBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox destinationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox EvaluationBox;

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
            this.inputBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EvaluationBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destinationBox_Mirror = new System.Windows.Forms.RichTextBox();
            this.inputBox2_Mirror = new System.Windows.Forms.RichTextBox();
            this.inputBox1_Mirror = new System.Windows.Forms.RichTextBox();
            this.destinationBox_RefEdit = new System.Windows.Forms.Button();
            this.inputBox2_RefEdit = new System.Windows.Forms.Button();
            this.inputBox1_RefEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputBox1_RefEdit_Done = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputBox2_RefEdit_Done = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.destinationBox_RefEdit_Done = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(3, 3);
            this.inputBox1.Multiline = false;
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(340, 28);
            this.inputBox1.TabIndex = 0;
            this.inputBox1.Text = "";
            this.inputBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select input ranges and sum the values !";
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(3, 3);
            this.inputBox2.Multiline = false;
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(340, 28);
            this.inputBox2.TabIndex = 2;
            this.inputBox2.Text = "";
            this.inputBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Augend";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Addend";
            // 
            // destinationBox
            // 
            this.destinationBox.Location = new System.Drawing.Point(3, 3);
            this.destinationBox.Multiline = false;
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(340, 28);
            this.destinationBox.TabIndex = 5;
            this.destinationBox.Text = "";
            this.destinationBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InsertButton.Location = new System.Drawing.Point(9, 203);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(219, 30);
            this.InsertButton.TabIndex = 7;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Evaluation";
            // 
            // EvaluationBox
            // 
            this.EvaluationBox.Location = new System.Drawing.Point(75, 254);
            this.EvaluationBox.Name = "EvaluationBox";
            this.EvaluationBox.ReadOnly = true;
            this.EvaluationBox.Size = new System.Drawing.Size(342, 28);
            this.EvaluationBox.TabIndex = 9;
            this.EvaluationBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destinationBox_Mirror);
            this.groupBox1.Controls.Add(this.inputBox2_Mirror);
            this.groupBox1.Controls.Add(this.EvaluationBox);
            this.groupBox1.Controls.Add(this.inputBox1_Mirror);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.destinationBox_RefEdit);
            this.groupBox1.Controls.Add(this.InsertButton);
            this.groupBox1.Controls.Add(this.inputBox2_RefEdit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputBox1_RefEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 342);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // destinationBox_Mirror
            // 
            this.destinationBox_Mirror.BackColor = System.Drawing.SystemColors.Window;
            this.destinationBox_Mirror.Location = new System.Drawing.Point(75, 151);
            this.destinationBox_Mirror.Multiline = false;
            this.destinationBox_Mirror.Name = "destinationBox_Mirror";
            this.destinationBox_Mirror.ReadOnly = true;
            this.destinationBox_Mirror.Size = new System.Drawing.Size(323, 28);
            this.destinationBox_Mirror.TabIndex = 0;
            this.destinationBox_Mirror.Text = "";
            // 
            // inputBox2_Mirror
            // 
            this.inputBox2_Mirror.BackColor = System.Drawing.SystemColors.Window;
            this.inputBox2_Mirror.Location = new System.Drawing.Point(58, 87);
            this.inputBox2_Mirror.Multiline = false;
            this.inputBox2_Mirror.Name = "inputBox2_Mirror";
            this.inputBox2_Mirror.ReadOnly = true;
            this.inputBox2_Mirror.Size = new System.Drawing.Size(340, 28);
            this.inputBox2_Mirror.TabIndex = 0;
            this.inputBox2_Mirror.Text = "";
            // 
            // inputBox1_Mirror
            // 
            this.inputBox1_Mirror.BackColor = System.Drawing.SystemColors.Window;
            this.inputBox1_Mirror.Location = new System.Drawing.Point(58, 48);
            this.inputBox1_Mirror.Name = "inputBox1_Mirror";
            this.inputBox1_Mirror.ReadOnly = true;
            this.inputBox1_Mirror.Size = new System.Drawing.Size(340, 28);
            this.inputBox1_Mirror.TabIndex = 0;
            this.inputBox1_Mirror.Text = "";
            // 
            // destinationBox_RefEdit
            // 
            this.destinationBox_RefEdit.Image = global::ExcelAddIn3.Properties.Resources.RefEdit0;
            this.destinationBox_RefEdit.Location = new System.Drawing.Point(404, 151);
            this.destinationBox_RefEdit.Name = "destinationBox_RefEdit";
            this.destinationBox_RefEdit.Size = new System.Drawing.Size(27, 28);
            this.destinationBox_RefEdit.TabIndex = 12;
            this.destinationBox_RefEdit.UseVisualStyleBackColor = true;
            this.destinationBox_RefEdit.Click += new System.EventHandler(this.destinationBox_RefEdit_Click);
            // 
            // inputBox2_RefEdit
            // 
            this.inputBox2_RefEdit.Image = global::ExcelAddIn3.Properties.Resources.RefEdit0;
            this.inputBox2_RefEdit.Location = new System.Drawing.Point(404, 87);
            this.inputBox2_RefEdit.Name = "inputBox2_RefEdit";
            this.inputBox2_RefEdit.Size = new System.Drawing.Size(27, 28);
            this.inputBox2_RefEdit.TabIndex = 11;
            this.inputBox2_RefEdit.UseVisualStyleBackColor = true;
            this.inputBox2_RefEdit.Click += new System.EventHandler(this.inputBox2_RefEdit_Click);
            // 
            // inputBox1_RefEdit
            // 
            this.inputBox1_RefEdit.Image = global::ExcelAddIn3.Properties.Resources.RefEdit0;
            this.inputBox1_RefEdit.Location = new System.Drawing.Point(404, 48);
            this.inputBox1_RefEdit.Name = "inputBox1_RefEdit";
            this.inputBox1_RefEdit.Size = new System.Drawing.Size(27, 33);
            this.inputBox1_RefEdit.TabIndex = 10;
            this.inputBox1_RefEdit.UseVisualStyleBackColor = true;
            this.inputBox1_RefEdit.Click += new System.EventHandler(this.inputBox1_RefEdit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(449, 464);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.inputBox1);
            this.flowLayoutPanel2.Controls.Add(this.inputBox1_RefEdit_Done);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(384, 34);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // inputBox1_RefEdit_Done
            // 
            this.inputBox1_RefEdit_Done.Image = global::ExcelAddIn3.Properties.Resources.RefEdit1;
            this.inputBox1_RefEdit_Done.Location = new System.Drawing.Point(349, 3);
            this.inputBox1_RefEdit_Done.Name = "inputBox1_RefEdit_Done";
            this.inputBox1_RefEdit_Done.Size = new System.Drawing.Size(32, 28);
            this.inputBox1_RefEdit_Done.TabIndex = 14;
            this.inputBox1_RefEdit_Done.UseVisualStyleBackColor = true;
            this.inputBox1_RefEdit_Done.Visible = false;
            this.inputBox1_RefEdit_Done.Click += new System.EventHandler(this.inputBox1_RefEdit_Done_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.inputBox2);
            this.flowLayoutPanel3.Controls.Add(this.inputBox2_RefEdit_Done);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(384, 34);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // inputBox2_RefEdit_Done
            // 
            this.inputBox2_RefEdit_Done.Image = global::ExcelAddIn3.Properties.Resources.RefEdit1;
            this.inputBox2_RefEdit_Done.Location = new System.Drawing.Point(349, 3);
            this.inputBox2_RefEdit_Done.Name = "inputBox2_RefEdit_Done";
            this.inputBox2_RefEdit_Done.Size = new System.Drawing.Size(32, 28);
            this.inputBox2_RefEdit_Done.TabIndex = 14;
            this.inputBox2_RefEdit_Done.UseVisualStyleBackColor = true;
            this.inputBox2_RefEdit_Done.Visible = false;
            this.inputBox2_RefEdit_Done.Click += new System.EventHandler(this.inputBox2_RefEdit_Done_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.destinationBox);
            this.flowLayoutPanel4.Controls.Add(this.destinationBox_RefEdit_Done);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 83);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(384, 34);
            this.flowLayoutPanel4.TabIndex = 17;
            // 
            // destinationBox_RefEdit_Done
            // 
            this.destinationBox_RefEdit_Done.Image = global::ExcelAddIn3.Properties.Resources.RefEdit1;
            this.destinationBox_RefEdit_Done.Location = new System.Drawing.Point(349, 3);
            this.destinationBox_RefEdit_Done.Name = "destinationBox_RefEdit_Done";
            this.destinationBox_RefEdit_Done.Size = new System.Drawing.Size(32, 28);
            this.destinationBox_RefEdit_Done.TabIndex = 14;
            this.destinationBox_RefEdit_Done.UseVisualStyleBackColor = true;
            this.destinationBox_RefEdit_Done.Visible = false;
            this.destinationBox_RefEdit_Done.Click += new System.EventHandler(this.destinationBox_RefEdit_Done_Click);
            // 
            // IteratorForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 489);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 39);
            this.Name = "IteratorForm2";
            this.Text = "RefEdit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputBox1_RefEdit;
        private System.Windows.Forms.Button inputBox2_RefEdit;
        private System.Windows.Forms.Button destinationBox_RefEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox inputBox1_Mirror;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button inputBox1_RefEdit_Done;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RichTextBox inputBox2_Mirror;
        private System.Windows.Forms.Button inputBox2_RefEdit_Done;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RichTextBox destinationBox_Mirror;
        private System.Windows.Forms.Button destinationBox_RefEdit_Done;
    }
}