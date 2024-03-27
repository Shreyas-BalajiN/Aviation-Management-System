namespace Aviation
{
    partial class passenger_UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.namesearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SEARCH_BUTTON = new System.Windows.Forms.Button();
            this.ADD_BUTTON = new System.Windows.Forms.Button();
            this.UPDATE_BUTTON = new System.Windows.Forms.Button();
            this.DELETE_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.passcheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // namesearch
            // 
            this.namesearch.AutoSize = true;
            this.namesearch.BackColor = System.Drawing.Color.Transparent;
            this.namesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.namesearch.Location = new System.Drawing.Point(212, 39);
            this.namesearch.Name = "namesearch";
            this.namesearch.Size = new System.Drawing.Size(51, 17);
            this.namesearch.TabIndex = 2;
            this.namesearch.Text = "NAME:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(281, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SEARCH_BUTTON
            // 
            this.SEARCH_BUTTON.BackColor = System.Drawing.Color.SlateBlue;
            this.SEARCH_BUTTON.ForeColor = System.Drawing.Color.White;
            this.SEARCH_BUTTON.Location = new System.Drawing.Point(245, 78);
            this.SEARCH_BUTTON.Name = "SEARCH_BUTTON";
            this.SEARCH_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.SEARCH_BUTTON.TabIndex = 4;
            this.SEARCH_BUTTON.Text = "SEARCH";
            this.SEARCH_BUTTON.UseVisualStyleBackColor = false;
            this.SEARCH_BUTTON.Click += new System.EventHandler(this.SEARCH_BUTTON_Click);
            // 
            // ADD_BUTTON
            // 
            this.ADD_BUTTON.BackColor = System.Drawing.Color.SlateBlue;
            this.ADD_BUTTON.ForeColor = System.Drawing.Color.White;
            this.ADD_BUTTON.Location = new System.Drawing.Point(83, 262);
            this.ADD_BUTTON.Name = "ADD_BUTTON";
            this.ADD_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.ADD_BUTTON.TabIndex = 5;
            this.ADD_BUTTON.Text = "ADD";
            this.ADD_BUTTON.UseVisualStyleBackColor = false;
            this.ADD_BUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // UPDATE_BUTTON
            // 
            this.UPDATE_BUTTON.BackColor = System.Drawing.Color.SlateBlue;
            this.UPDATE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.UPDATE_BUTTON.Location = new System.Drawing.Point(245, 262);
            this.UPDATE_BUTTON.Name = "UPDATE_BUTTON";
            this.UPDATE_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.UPDATE_BUTTON.TabIndex = 6;
            this.UPDATE_BUTTON.Text = "UPDATE";
            this.UPDATE_BUTTON.UseVisualStyleBackColor = false;
            this.UPDATE_BUTTON.Click += new System.EventHandler(this.button2_Click);
            // 
            // DELETE_BUTTON
            // 
            this.DELETE_BUTTON.BackColor = System.Drawing.Color.SlateBlue;
            this.DELETE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.DELETE_BUTTON.Location = new System.Drawing.Point(419, 262);
            this.DELETE_BUTTON.Name = "DELETE_BUTTON";
            this.DELETE_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.DELETE_BUTTON.TabIndex = 7;
            this.DELETE_BUTTON.Text = "DELETE";
            this.DELETE_BUTTON.UseVisualStyleBackColor = false;
            this.DELETE_BUTTON.Click += new System.EventHandler(this.DELETE_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(120, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(43, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PASSPORT NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(352, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "AGE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(328, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "GENDER";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 360);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(394, 356);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(394, 397);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(63, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "TICKET NUMBER";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(181, 404);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(602, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(328, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "FLIGHT NO.";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(394, 319);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // passcheck
            // 
            this.passcheck.BackColor = System.Drawing.Color.SlateBlue;
            this.passcheck.ForeColor = System.Drawing.Color.White;
            this.passcheck.Location = new System.Drawing.Point(17, 58);
            this.passcheck.Name = "passcheck";
            this.passcheck.Size = new System.Drawing.Size(96, 23);
            this.passcheck.TabIndex = 21;
            this.passcheck.Text = "CHECK YEAR";
            this.passcheck.UseVisualStyleBackColor = false;
            this.passcheck.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // passenger_UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Aviation.Properties.Resources.flight_interface;
            this.Controls.Add(this.passcheck);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DELETE_BUTTON);
            this.Controls.Add(this.UPDATE_BUTTON);
            this.Controls.Add(this.ADD_BUTTON);
            this.Controls.Add(this.SEARCH_BUTTON);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.namesearch);
            this.Name = "passenger_UserControl1";
            this.Size = new System.Drawing.Size(622, 427);
            this.Load += new System.EventHandler(this.passenger_UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label namesearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SEARCH_BUTTON;
        private System.Windows.Forms.Button ADD_BUTTON;
        private System.Windows.Forms.Button UPDATE_BUTTON;
        private System.Windows.Forms.Button DELETE_BUTTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button passcheck;
    }
}
