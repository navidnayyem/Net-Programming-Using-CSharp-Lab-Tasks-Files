﻿namespace CSharpDBOperation
{
    partial class ViewAllStudentData
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.course = new System.Windows.Forms.ColumnHeader();
            this.mark = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.course,
            this.mark});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 396);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "                  id";
            this.id.Width = 123;
            // 
            // name
            // 
            this.name.Text = "   name";
            this.name.Width = 81;
            // 
            // course
            // 
            this.course.Text = "    course";
            this.course.Width = 110;
            // 
            // mark
            // 
            this.mark.Text = "  mark";
            this.mark.Width = 65;
            // 
            // ViewAllStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 396);
            this.Controls.Add(this.listView1);
            this.Name = "ViewAllStudentData";
            this.Text = "ViewAllStudentData";
            this.Load += new System.EventHandler(this.ViewAllStudentData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader course;
        private System.Windows.Forms.ColumnHeader mark;
    }
}