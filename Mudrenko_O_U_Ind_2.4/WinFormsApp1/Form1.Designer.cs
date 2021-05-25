
namespace WinFormsApp1
{
    partial class Form1
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
            this.firstVector = new System.Windows.Forms.TextBox();
            this.secondVector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.scals = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstVector
            // 
            this.firstVector.Location = new System.Drawing.Point(241, 75);
            this.firstVector.Name = "firstVector";
            this.firstVector.Size = new System.Drawing.Size(267, 23);
            this.firstVector.TabIndex = 0;
            // 
            // secondVector
            // 
            this.secondVector.Location = new System.Drawing.Point(241, 174);
            this.secondVector.Name = "secondVector";
            this.secondVector.Size = new System.Drawing.Size(267, 23);
            this.secondVector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(241, 290);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(267, 23);
            this.result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 334);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(267, 23);
            this.add.TabIndex = 6;
            this.add.Text = "додавання";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // scals
            // 
            this.scals.Location = new System.Drawing.Point(241, 373);
            this.scals.Name = "scals";
            this.scals.Size = new System.Drawing.Size(267, 23);
            this.scals.TabIndex = 7;
            this.scals.Text = "скалярний добуток";
            this.scals.UseVisualStyleBackColor = true;
            this.scals.Click += new System.EventHandler(this.scals_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "множення на конст";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(285, 334);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(267, 23);
            this.sub.TabIndex = 9;
            this.sub.Text = "віднімання";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.scals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondVector);
            this.Controls.Add(this.firstVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstVector;
        private System.Windows.Forms.TextBox secondVector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button scals;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sub;
    }
}

